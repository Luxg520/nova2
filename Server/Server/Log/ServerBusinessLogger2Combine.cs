using System;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Swift;
using Nova;
using System.Data.Sql;
using MySql.Data.Types;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;

namespace Server.Log.CanQuery
{
    public interface ICombineContain
    {
        void LoadAllData(Action<object[]> cb);
        void Combine(ICombineContain other);
    }

    public interface IQueryContain
    {
        void QueryLogs(string cmdStr, Action<object[]> callBack);
    }

    public class ServerBusinessLogger2Combine<T> : ServerBusinessLogger<T>, ICombineContain, IQueryContain where T : class
    {
        public ServerBusinessLogger2Combine() { }
        public ServerBusinessLogger2Combine(ServerBusinessLogger<T> logger)
        {
            this.tableName = logger.tableName;
            this.p = logger.p;
        }

        public void LoadAllData(Action<object[]> cb)
        {
            string tableName = typeof(T).FullName.Replace(".", "_");
            string createTableCmd = "select * ";
            createTableCmd += "from " + tableName;

            QueryLogs(createTableCmd, cb);
        }

        public void Combine(ICombineContain other)
        {
            other.LoadAllData((data) =>
            {
                for (int i = 0; i < data.Length; i++)
                {
                    T item = (T)data[i];
                    ServerBusinessLogItem<T> d = new ServerBusinessLogItem<T>(++maxID);
                    d.d = item;
                    p.AddNew(d);
                }
            });
        }

        //查询登陆LOG
        public void QueryLogs(string cmdStr, Action<object[]> callBack)
        {
            //log列表
            List<T> logArr = new List<T>();
            //查找并加入列表
            ExecuteRawQuery(cmdStr, (r) =>
            {
                //List<string> fLst = new List<string>();
                FieldInfo[] fs = t.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                List<FieldInfo> fsList = new List<FieldInfo>();
                List<Type> pt_fs = new List<Type>();
                foreach (FieldInfo fi in fs)
                {
                    //fLst.Add(fi.Name);
                    fsList.Add(fi);
                    pt_fs.Add(GetFieldOrProperty(fi.Name));
                }

                PropertyInfo[] ps = t.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                List<PropertyInfo> psList = new List<PropertyInfo>();
                List<Type> pt_ps = new List<Type>();
                foreach (PropertyInfo pi in ps)
                {
                    if (pi.CanRead && pi.CanWrite)
                    {
                        //fLst.Add(pi.Name);
                        psList.Add(pi);
                        pt_ps.Add(GetFieldOrProperty(pi.Name));
                    }
                }
                //string[] fieldsName = fLst.ToArray();
                //List<Type> pt = new List<Type>();
                //for (int i = 0; i < fieldsName.Length; i++)
                //{
                //    string f = fieldsName[i];
                //    pt.Add(GetFieldOrProperty(f));
                //}
                //object[] obj = new object[pt.Count];
                //for (int i = 0; i < r.FieldCount; i++)
                //{
                //    object v = r.GetValue(i);
                //    string n = r.GetName(i);
                //    for (int j = 0; j < fieldsName.Length; j++)
                //    {
                //        string f = fieldsName[j];
                //        if (n == f)
                //        {
                //            obj[j] = GetValue(pt[j], v);
                //        }
                //    }
                //}
                //根据参数类型获取构造函数
                //ConstructorInfo ci = t.GetConstructor(pt.ToArray());
                //T logItem = (T)ci.Invoke(obj);
                ConstructorInfo ci = t.GetConstructor(new Type[0]);
                T logItem = (T)ci.Invoke(new object[0]);
                for (int i = 0; i < r.FieldCount; i++)
                {
                    object v = r.GetValue(i);
                    string n = r.GetName(i);
                    for (int j = 0; j < fsList.Count; j++)
                    {
                        FieldInfo f = fs[j];
                        if (n == f.Name)
                        {
                            f.SetValue(logItem, GetValue(pt_fs[j], v));
                        }
                    }
                }
                for (int i = 0; i < r.FieldCount; i++)
                {
                    object v = r.GetValue(i);
                    string n = r.GetName(i);
                    for (int j = 0; j < psList.Count; j++)
                    {
                        PropertyInfo f = ps[j];
                        if (n == f.Name)
                        {
                            f.SetValue(logItem, GetValue(pt_ps[j], v), null);
                        }
                    }
                }
                logArr.Add(logItem);
            });
            //列表转为数组并回调函数
            callBack(logArr.ToArray());
        }

        // 获取对应的 MySql 类型
        public static object GetValue(Type d, object v)
        {
            if (d == null)
                throw new Exception("unsupported null type by GetDbType: " + v);
            else if (d == typeof(bool))
                return (bool)v;
            else if (d == typeof(string))
                return v is DBNull ? null : v is string ? v : ASCIIEncoding.UTF8.GetString((byte[])v);
            else if (d == typeof(DateTime))
                return v is DBNull ? TimeMgr.Inst.DT2015 : (DateTime)v;
            else if (d == typeof(float))
                return v is DBNull ? 0f : (float)v;
            else if (d == typeof(Int16))
                return v is DBNull ? 0 : (Int16)v;
            else if (d == typeof(Int32))
                return v is DBNull ? 0 : (Int32)v;
            else if (d == typeof(Int64))
                return v is DBNull ? 0 : (Int64)v;
            else if (d == typeof(UInt16))
                return v is DBNull ? 0 : (UInt16)v;
            else if (d == typeof(UInt32))
                return v is DBNull ? 0 : (UInt32)v;
            else if (d == typeof(UInt64))
                return v is DBNull ? 0 : UInt64.Parse(v.ToString());
            else if (d == typeof(ulong))
                return v is DBNull ? 0 : (ulong)v;
            else if (d == typeof(byte))
                return v is DBNull ? null : ASCIIEncoding.UTF8.GetString((byte[])v);
            else if (d == typeof(byte[]))
                return v is DBNull ? null : ASCIIEncoding.UTF8.GetString((byte[])v);
            else
                throw new Exception("unsupported type: " + v + ":" + d.GetType().Name);
        }

        void ExecuteRawQuery(string cmdStr, Action<IDataReader> cb)
        {
            if (p.Conn == null || p.Conn.State != ConnectionState.Open)
                p.OpenConnection();
            lock (p.Conn)
            {
                IDbCommand cmd = p.Conn.CreateCommand();
                cmd.CommandText = cmdStr;

                List<object> lst = new List<object>();
                IDataReader r = cmd.ExecuteReader();

                try
                {
                    if (cb != null)
                    {
                        while (r.Read())
                            cb(r);
                    }
                }
                finally
                {
                    r.Close();
                    p.CloseConnection();
                }
            }
        }
    }
}
