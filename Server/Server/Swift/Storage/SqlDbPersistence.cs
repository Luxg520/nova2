/*
 * creator(s): chenm
 * reviser(s): chenm
 */

using System;
using System.Collections.Generic;
using Swift;
using Nova;
using System.Data;
using System.Data.Common;
using System.Data.Sql;
using System.Text;

namespace Server
{
    /// <summary>
    /// SqlDb 序列化器基类
    /// </summary>
    public abstract class SqlDbPersistence<T, IDType> : CachedAsyncPersistence<T, IDType, byte[]> where T : DataItem<IDType>
    {
        public SqlDbPersistence(string tableName, string[] additionalCols, Func<T, byte[]> data2BuffHandler, Func<byte[], T> buff2DataHandler, Func<T, string, object> colValueMap)
            : base(data2BuffHandler, buff2DataHandler)
        {
            tbName = tableName;
            cols = additionalCols;

            // cvm is not thread safety, need to be improved
            cvm = colValueMap;
        }

        /// <summary>
        /// log 辅助类型
        /// </summary>
        protected ServerLogger log = new ServerLogger("SqlPersistence for: " + typeof(T).FullName);

        #region 需要继承实现的部分

        // 将缓冲同步落地保存
        protected override void AddImpl(IDType id, T d, byte[] buff)
        {
            string addCols = "";
            string addNamedPs = "";

            if (cols != null && cols.Length > 0)
            {
                foreach (string c in cols)
                {
                    object v = cvm(d, c);
                    if (v != null)
                    {
                        addCols += ", " + c;
                        addNamedPs += ", " + NamedParam(c);
                    }
                }
            }

            IDbCommand cmd = Conn.CreateCommand();

            try
            {
                cmd.CommandText = string.Format(@"insert into {0} (ID, Data{1}) values ({2}, {3}{4})", tbName, addCols, NamedParam("ID"), NamedParam("Data"), addNamedPs);

                IDbDataParameter idParam = cmd.CreateParameter();
                idParam.ParameterName = RealParam("ID");
                idParam.DbType = GetDbType(id, "ID");
                idParam.Value = id;
                cmd.Parameters.Add(idParam);

                IDbDataParameter dataParam = cmd.CreateParameter();
                dataParam.ParameterName = RealParam("Data");
                dataParam.DbType = DbType.Binary;
                dataParam.Value = buff;
                cmd.Parameters.Add(dataParam);

                if (cols != null && cols.Length > 0)
                {
                    foreach (string c in cols)
                    {
                        object v = cvm(d, c);
                        if (v == null)
                            continue;

                        IDbDataParameter p = cmd.CreateParameter();
                        p.ParameterName = RealParam(c);
                        p.DbType = GetDbType(v, c);
                        p.Value = v;
                        cmd.Parameters.Add(p);
                    }
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                log.Error("\r\n==========\r\n" + cmd.CommandText + "\r\n" + ex.Message + "\r\n==========\r\n" + ex.StackTrace + "\r\n==========\r\n");
                throw ex;
            }
        }

        // 将缓冲同步落地保存
        protected override void UpdateImpl(IDType id, T d, byte[] buff)
        {
            string addCols = "";
            if (cols != null && cols.Length > 0)
            {
                foreach (string c in cols)
                {
                    object v = cvm(d, c);
                    if (v != null)
                        addCols += ", " + c + "=" + NamedParam(c);
                }
            }

            IDbCommand cmd = Conn.CreateCommand();
            try
            {
                cmd.CommandText = string.Format(@"update {0} set Data = {1}{2} where ID = {3}", tbName, NamedParam("Data"), addCols, NamedParam("ID"));

                IDbDataParameter idParam = cmd.CreateParameter();
                idParam.ParameterName = RealParam("ID");
                idParam.DbType = GetDbType(id, "ID");
                idParam.Value = id;
                cmd.Parameters.Add(idParam);

                IDbDataParameter dataParam = cmd.CreateParameter();
                dataParam.ParameterName = RealParam("Data");
                dataParam.DbType = DbType.Binary;
                dataParam.Value = buff;
                cmd.Parameters.Add(dataParam);

                if (cols != null && cols.Length > 0)
                {
                    foreach (string c in cols)
                    {
                        object v = cvm(d, c);
                        if (v == null)
                            continue;

                        IDbDataParameter p = cmd.CreateParameter();
                        p.ParameterName = RealParam(c);
                        p.DbType = GetDbType(v, c);
                        p.Value = v;
                        cmd.Parameters.Add(p);
                    }
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                log.Error("\r\n==========\r\n" + cmd.CommandText + "\r\n" + ex.Message + "\r\n==========\r\n" + ex.StackTrace + "\r\n==========\r\n");
                throw ex;
            }
        }

        // 同步删除指定 id 的数据
        protected override void DeleteImpl(IDType id)
        {
            IDbCommand cmd = Conn.CreateCommand();
            try
            {
                cmd.CommandText = string.Format(@"Delete from {0} where ID = {1}", tbName, NamedParam("ID"));

                IDbDataParameter idParam = cmd.CreateParameter();
                idParam.ParameterName = RealParam("ID");
                idParam.DbType = GetDbType(id, "ID");
                idParam.Value = id;
                cmd.Parameters.Add(idParam);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                log.Error("\r\n==========\r\n" + cmd.CommandText + "\r\n" + ex.Message + "\r\n==========\r\n" + ex.StackTrace + "\r\n==========\r\n");
                throw ex;
            }
        }

        // 同步加载指定 id 的数据
        protected override byte[] LoadImpl(IDType id)
        {
            IDbCommand cmd = Conn.CreateCommand();
            IDataReader r = null;
            byte[] data = null;

            try
            {
                cmd.CommandText = string.Format(@"select Data from {0} where ID = {1}", tbName, NamedParam("ID"));

                IDbDataParameter idParam = cmd.CreateParameter();
                idParam.ParameterName = RealParam("ID");
                idParam.DbType = GetDbType(id, "ID");
                idParam.Value = id;
                cmd.Parameters.Add(idParam);

                r = cmd.ExecuteReader();
                if (r.Read())
                    data = (byte[])r.GetValue(0);
            }
            catch (Exception ex)
            {
                log.Error("\r\n==========\r\n" + cmd.CommandText + "\r\n" + ex.Message + "\r\n==========\r\n" + ex.StackTrace + "\r\n==========\r\n");
                throw ex;
            }
            finally
            {
                if (r != null)
                    r.Close();
            }

            return data;
        }

        // 同步加载所有数据
        protected override byte[][] LoadAllImpl(string whereClause)
        {
            IDbCommand cmd = Conn.CreateCommand();
            IDataReader r = null;
            List<byte[]> dataLst = new List<byte[]>();

            try
            {
                cmd.CommandText = string.Format(@"select Data from {0} {1}", tbName, whereClause);

                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    object dataObj = r.GetValue(0);
                    byte[] data = dataObj is DBNull ? null : (byte[])dataObj;
                    dataLst.Add(data);
                }
            }
            catch (Exception ex)
            {
                log.Error("\r\n==========\r\n" + cmd.CommandText + "\r\n" + ex.Message + "\r\n==========\r\n" + ex.StackTrace + "\r\n==========\r\n");
                throw ex;
            }
            finally
            {
                if (r != null)
                    r.Close();
            }

            return dataLst.ToArray();
        }

        // 同步加载所有数据
        protected override IDType[] LoadAllIDImpl(string whereClause)
        {
            IDbCommand cmd = Conn.CreateCommand();
            IDataReader r = null;
            List<IDType> dataLst = new List<IDType>();

            try
            {
                cmd.CommandText = string.Format(@"select ID from {0} {1}", tbName, whereClause);

                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    IDType uid = (IDType)r.GetValue(0);
                    dataLst.Add(uid);
                }
            }
            catch (Exception ex)
            {
                log.Error("\r\n==========\r\n" + cmd.CommandText + "\r\n" + ex.Message + "\r\n==========\r\n" + ex.StackTrace + "\r\n==========\r\n");
                throw ex;
            }
            finally
            {
                if (r != null)
                    r.Close();
            }

            return dataLst.ToArray();
        }

        #endregion

        #region 保护部分

        // 根据字段名取存放到数据库中的对应值
        protected Func<T, string, object> cvm = null;

        // 额外的列
        protected string[] cols = null;

        // 数据库连接
        public abstract IDbConnection Conn
        {
            get;
        }

        // 包装形参名
        protected abstract string NamedParam(string name);

        // 包装实参名
        protected abstract string RealParam(string name);

        // 数据表名
        protected string tbName = null;

        // 获取对应的 MySql 类型
        public static DbType GetDbType(object d, string paraName)
        {
            if (d == null)
                throw new Exception("unsupported null type by GetDbType: " + paraName);
            else if (d is bool)
                return DbType.Boolean;
            else if (d is string)
                return DbType.String;
            else if (d is DateTime)
                return DbType.DateTime;
            else if (d is float)
                return DbType.Single;
            else if (d is Int16)
                return DbType.Int16;
            else if (d is Int32)
                return DbType.Int32;
            else if (d is Int64)
                return DbType.Int64;
            else if (d is UInt16)
                return DbType.UInt16;
            else if (d is UInt32)
                return DbType.UInt32;
            else if (d is UInt64)
                return DbType.UInt64;
            else if (d is byte)
                return DbType.Byte;
            else if (d is byte[])
                return DbType.Binary;
            else
                throw new Exception("unsupported type: " + paraName + ":" + d.GetType().Name);
        }

        // 获取对应的 MySql 类型名称
        public static string GetDbTypeName(Type t, string paraName)
        {
            if (t == null)
                throw new Exception("unsupported null type by GetDbTypeName: " + paraName);
            else if (t == typeof(bool)) // if (d is bool)
                return "Bool";
            else if (t == typeof(string)) // if (d is string)
                return "Blob";
            else if (t == typeof(DateTime)) // if (d is DateTime)
                return "DateTime";
            else if (t == typeof(float)) // else if (d is float)
                return "Float";
            else if (t == typeof(Int16)) // else if (d is Int16)
                return "SmallInt";
            else if (t == typeof(Int32)) // else if (d is Int32)
                return "Int";
            else if (t == typeof(Int64)) // else if (d is Int64)
                return "BigInt";
            else if (t == typeof(Int16)) // else if (d is UInt16)
                return "SmallInt";
            else if (t == typeof(UInt32)) // else if (d is UInt32)
                return "Int";
            else if (t == typeof(UInt64)) // else if (d == typeof(UInt64)) // else if (d is UInt64)
                return "BigInt";
            else if (t == typeof(byte)) // else if (d is byte)
                return "TinyInt";
            else if (t == typeof(byte[])) // else if (d is byte[])
                return "Blob";
            else
                throw new Exception("unsupported type: " + paraName + ":" + t.Name);
        }

        #endregion
    }
}
