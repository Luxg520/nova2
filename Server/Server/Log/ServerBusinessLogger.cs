﻿using System;
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

namespace Server
{
    public class ServerBusinessLoggerConfig : Component
    {
        protected static string dbName = null; // 数据库名
        protected static string dbServer = null; // 数据库服务器
        protected static string usr = null; // 数据库登录用户名
        protected static string pwd = null; // 数据库登录密码

        public static void Config(string databaseName, string serverName, string userName, string password)
        {
            dbName = databaseName;
            dbServer = serverName;
            usr = userName;
            pwd = password;
        }
    }

    // 辅助类型
    public class ServerBusinessLogItem<T> : DataItem<int>
    {
        public DateTime dt = DateTime.Now;
        public T d; // 要 log 的数据
        public ServerBusinessLogItem(int id) : base(id) { }
    }

    /// <summary>
    /// 将服务器逻辑数据日志存入 mysql 数据库
    /// </summary>
    public class ServerBusinessLogger<T> : ServerBusinessLoggerConfig, IFrameDrived where T : class
    {
        public string tableName = null; // 表名
        protected int maxID = 0; // 当前最大 ID

        // mysql 序列化器
        public MySqlPersistence<ServerBusinessLogItem<T>, int> p = null;

        // 真正要 log 的类型
        protected Type t = typeof(T);

        // 构造器
        public ServerBusinessLogger(params string[] fieldsName)
        {
            // null 表示所有可读写的 field 和 property
            if (fieldsName == null || fieldsName.Length == 0)
            {
                List<string> fLst = new List<string>();
                FieldInfo[] fs = t.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                foreach (FieldInfo fi in fs)
                    fLst.Add(fi.Name);

                PropertyInfo[] ps = t.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                foreach (PropertyInfo pi in ps)
                {
                    if (pi.CanRead && pi.CanWrite)
                        fLst.Add(pi.Name);
                }

                fieldsName = fLst.ToArray();
            }

            // 表明和建表语句
            tableName = typeof(T).FullName.Replace(".", "_");
            string createTableCmd = "CREATE TABLE " + tableName + "(ID int, ";

            foreach (string f in fieldsName)
            {
                Type ft = GetFieldOrProperty(f);
                string dbTypeName = MySqlPersistence<ServerBusinessLogItem<T>, int>.GetDbTypeName(ft, f);
                createTableCmd += f + " " + dbTypeName + ", ";
            }

            createTableCmd += "Data BLOB, PRIMARY KEY(ID ASC))";

            // 序列化器
            List<string> fieldsWithTime = new List<string>();
            fieldsWithTime.AddRange(fieldsName);
            //fieldsWithTime.Add("DateTime");
            p = new MySqlPersistence<ServerBusinessLogItem<T>, int>(dbName, dbServer, usr, pwd, tableName, createTableCmd, fieldsWithTime.ToArray(), null, null, ColValueMap);
        }

        // 开始日志记录
        public void Start()
        {
            // 先获取最大 id 号，后面的在此基础上累加
            maxID = p.QeuryInt("SELECT MAX(ID) FROM " + tableName) + 1;

            // 启动序列化器
            p.Start();
        }

        // 停止记录
        public void Stop()
        {
            // 停止序列化器
            p.Stop();
        }

        public override void Close()
        {
            Stop();
        }

        public void OnTimeElapsed(int te)
        {
            p.ProcessPendingCallback();
        }

        // 记录数据
        public void Log(T data)
        {
            ServerBusinessLogItem<T> d = new ServerBusinessLogItem<T>(++maxID);
            d.d = data;
            p.AddNew(d);
        }

        // 获取字段或属性类型
        protected Type GetFieldOrProperty(string f)
        {
            FieldInfo fi = t.GetField(f);
            if (fi != null)
                return fi.FieldType;

            PropertyInfo pi = t.GetProperty(f);
            if (pi != null)
                return pi.PropertyType;

            return null;
        }

        // 获取字段或属性值
        object ColValueMap(ServerBusinessLogItem<T> item, string f)
        {
            if (f == "ID")
                return item.ID;
            else if (f == "DateTime")
                return item.dt;
            else if (f == "Data")
                return null;
            else
            {
                FieldInfo fi = t.GetField(f);
                if (fi != null)
                    return fi.GetValue(item.d);

                PropertyInfo pi = t.GetProperty(f);
                if (pi != null)
                    return pi.GetValue(item.d, null);

                return null;
            }
        }
    }
}
