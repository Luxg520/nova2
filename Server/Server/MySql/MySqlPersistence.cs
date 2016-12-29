/*
 * creator(s): chenm
 * reviser(s): chenm
 */

using System;
using System.Threading;
using System.Collections.Generic;
using Swift;
using Nova;
using System.Data;
using System.Data.Common;
using System.Data.Sql;
using System.Linq;
using MySql;
using MySql.Data;
using MySql.Data.Types;
using MySql.Data.MySqlClient;

namespace Server
{
    #region 用于统计调试所有 MySql 序列化器

    public interface IMySqlPersistenceStatistic
    {
        string Name { get; } // 唯一名称
        int OpQueueLength { get; } // 当前操作队列长度
    }

    public sealed class MySqlPersistenceRegister
    {
        public static bool needRegister = false;

        private MySqlPersistenceRegister() { }

        public static MySqlPersistenceRegister Instance = new MySqlPersistenceRegister();

        private Dictionary<string, IMySqlPersistenceStatistic> dict = new Dictionary<string, IMySqlPersistenceStatistic>();
        public void Register(string key, IMySqlPersistenceStatistic p)
        {
            if (dict.ContainsKey(key))
                throw new Exception(key + " already exists");

            dict[key] = p;
        }

        public void TravleAll(Func<string, IMySqlPersistenceStatistic, bool> fun)
        {
            if (fun == null)
                return;

            string[] keys = dict.Keys.ToArray();
            foreach (string k in keys)
            {
                IMySqlPersistenceStatistic p = dict[k];
                if (!fun(k, p))
                    break;
            }
        }

        public string Print()
        {
            string r = "";
            TravleAll((key, p) =>
            {
                r += p.Name + " ops count=" + p.OpQueueLength + "\r\n";
                return true;
            });

            return r;
        }
    }

    #endregion

    public sealed class MySqlConnectionPool
    {
        private MySqlConnectionPool() { }

        public static Dictionary<string, Queue<MySqlConnection>> conns = new Dictionary<string, Queue<MySqlConnection>>();
        public static MySqlConnectionPool Instance = new MySqlConnectionPool();
        public static int ConnectionNum = 0;
        public static int AbandonNum = 0;
        public static int DefaultConnectionPoolSize = 5;
        public static int WarningConnectCount = 20;
        
        public MySqlConnection Open(string connectionStr)
        {
            Queue<MySqlConnection> q = null;
            lock (conns)
            {
                if (!conns.ContainsKey(connectionStr))
                    conns[connectionStr] = new Queue<MySqlConnection>();

                q = conns[connectionStr];
            }

            MySqlConnection conn = null;
            lock (q)
            {
                if (q.Count > 0)
                    conn = q.Dequeue();

                if (conn != null && (conn.State == ConnectionState.Broken || conn.State == ConnectionState.Closed))
                {
                    Abandon(connectionStr, conn);
                    conn = null;
                }
            }

            if (conn == null)
            {
                conn = new MySqlConnection(connectionStr);
                conn.Open();
                ConnectionNum++;

                if (ConnectionNum >= WarningConnectCount)
                    Console.WriteLine("MySqlConnection number exceeded the warning line: " + ConnectionNum);
            }

            return conn;
        }

        public Dictionary<string, int> Count(out int totalCount, out int abandonCount)
        {
            Dictionary<string, int> dict = new Dictionary<string,int>();
            Queue<MySqlConnection> q = null;
            lock (conns)
            {
                foreach (string k in conns.Keys)
                {
                    q = conns[k];
                    lock (q)
                        dict[k] = q.Count;
                }
            }

            totalCount = ConnectionNum;
            abandonCount = AbandonNum;
            return dict;
        }

        public void Close(string connectionStr, MySqlConnection conn)
        {
            Queue<MySqlConnection> q = null;
            lock (conns)
            {
                if (!conns.ContainsKey(connectionStr))
                    conns[connectionStr] = new Queue<MySqlConnection>();

                q = conns[connectionStr];
            }

            lock (q)
            {
                // 剩余的连接数超过一定程度的，就直接关掉
                if (q.Count >= DefaultConnectionPoolSize)
                {
                    conn.Close();
                    ConnectionNum--;
                }
                else
                    q.Enqueue(conn);
            }
        }

        public void Abandon(string connectionStr, MySqlConnection conn)
        {
            if (conn != null)
                conn.Close();

            AbandonNum++;
            ConnectionNum--;
        }
    }

    /// <summary>
    /// MySql 序列化器
    /// </summary>
    public class MySqlPersistence<T, IDType> : SqlDbPersistence<T, IDType>, IMySqlPersistenceStatistic where T : DataItem<IDType>
    {
        #region implement IMySqlPersistenceStatistic interface

        public string Name { get { return tbName; } }
        public int OpQueueLength { get { return base.OperationQueueLength; } }

        #endregion

        // 数据库连接字串
        public string ConnStr
        {
            get { return connStr; }
        } string connStr = null;

        // 构造器，需要指明数据映射工具
        public MySqlPersistence(string dbName, string dbServer, string username, string password, string tableName, string createTableCommander, string[] additionalCols, Action<T, IWriteableBuffer> data2BufferHandler, Func<IReadableBuffer, T> buff2DataHandler, Func<T, string, object> colValueMap)
            : base(tableName, additionalCols, (T obj) =>
                {
                    WriteBuffer buff = new WriteBuffer();
                    if (data2BufferHandler == null)
                        return null;

                    data2BufferHandler(obj, buff);
                    byte[] data = new byte[buff.Available];
                    for (int i = 0; i <data.Length; i++)
                    {
                        data[i] = buff.Data[i];
                    }
                    return data;
                },
                (byte[] buff) =>
                {
                    RingBuffer data = new RingBuffer();
                    if (buff2DataHandler == null)
                        return null;
                    else if (buff == null)
                        return buff2DataHandler(null);
                    else
                    {
                        data.Write(buff, 0, buff.Length);
                        return buff2DataHandler(data);
                    }
                }, colValueMap)
        {
            if (!MySqlPersistenceRegister.needRegister)
                MySqlPersistenceRegister.Instance.Register(tableName, this);

            tbName = tableName;
            connStr = string.Format(@"Server={0};Database={1};User Id={2};Password={3};charset=utf8;pooling=true",
                dbServer, dbName, username, password);

            if (!TableExists(tbName))
            {
                OpenConnection();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = createTableCommander;
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        // 检查指定表是否存在
        bool TableExists(string tableName)
        {
            if (running)
                throw new Exception("only supported before persistence started.");

            OpenConnection();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format("show tables like '{0}';", tableName);
            MySqlDataReader r = cmd.ExecuteReader();
            bool exists = r.Read();
            r.Close();

            CloseConnection();
            return exists;
        }

        #region 执行裸的 sql 查询

        public int QeuryInt(string cmdStr, int defaultValue = 0)
        {
            if (running)
                throw new Exception("only supported before persistence started.");

            OpenConnection();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = cmdStr;
            MySqlDataReader r = cmd.ExecuteReader();
            bool exists = r.Read();
            int n = exists && !r.IsDBNull(0) ? r.GetInt32(0) : defaultValue;
            r.Close();

            CloseConnection();
            return n;
        }

        public long QeuryLong(string cmdStr, long defaultValue = 0)
        {
            if (running)
                throw new Exception("only supported before persistence started.");

            OpenConnection();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = cmdStr;
            MySqlDataReader r = cmd.ExecuteReader();
            bool exists = r.Read();
            long n = exists && !r.IsDBNull(0) ? r.GetInt64(0) : defaultValue;
            r.Close();

            CloseConnection();
            return n;
        }

        #endregion

        // 为工作线程加上保护和 log
        protected override void WorkThread()
        {
            while (running)
            {
                bool interruptted = false;
                try
                {
                    if (!Prepared())
                    {
                        interruptted = true;
                        Thread.Sleep(50);
                        continue;
                    }

                    OpenConnection();
                    interruptted = !WorkOneStep();
                }
                catch (Exception ex)
                {
                    log.Error("\r\n mysql connection state = " 
                        + (conn == null ? "null" : conn.State.ToString())
                        + "\r\n==========\r\n" + ex.Message + "\r\n==========\r\n"
                        + ex.StackTrace + "\r\n==========\r\n");

                    // 不管什么错误，置空重连
                    AbandonConnection();
                    interruptted = true;
                }
                finally
                {
                    if (interruptted)
                    {
                        CloseConnection();
                        Thread.Sleep(50);
                    }
                }
            }

            try
            {
                // 退出之前要处理完所有等待中的操作
                OpenConnection();
                ProcessAll();
            }
            catch (Exception ex)
            {
                log.Error("\r\n!!! MySqlPersistence exception on closing down my cause data lost !!! ==========\r\n" + ex.Message + "\r\n==========\r\n" + ex.StackTrace + "\r\n==========\r\n");
            }
            finally
            {
                CloseConnection();
            }
        }

        // 确保数据库连接
        public void OpenConnection()
        {
            if (conn != null)
                return;

            conn = MySqlConnectionPool.Instance.Open(connStr);
        }

        public void CloseConnection()
        {
            if (conn == null)
                return;

            MySqlConnectionPool.Instance.Close(connStr, conn);
            conn = null;
        }

        public void AbandonConnection()
        {
            MySqlConnectionPool.Instance.Abandon(connStr, conn);
            conn = null;
        }

        #region 需要继承实现的部分

        // 数据库连接对象
        public override IDbConnection Conn
        {
            get
            {
                return conn;
            }
        } MySqlConnection conn = null;

        // 包装形参名
        protected override string NamedParam(string name)
        {
            return "?" + name;
        }

        // 包装实参名
        protected override string RealParam(string name)
        {
            return name;
        }

        #endregion
    }
}
