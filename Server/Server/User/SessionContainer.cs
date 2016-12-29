/*
 * creator(s): chenm
 * reviser(s): chenm
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swift;
using Nova;

namespace Server
{
    /// <summary>
    /// 会话容器
    /// </summary>
    public class SessionContainer
    {
        // 根据 uid 获取会话对象
        public Session GetByID(string uid)
        {
            Session s = null;
            if (uid == null)
                return null;
            if (ss.TryGetValue(uid, out s))
                return s;
            else
                return null;
        }

        // 添加会话
        public void Add(Session s)
        {
            if (s == null)
                throw new Exception("can not add null session");
            else if (s.ID == null)
                throw new Exception("can not add a session with null id");
            else if (ss.ContainsKey(s.ID))
                throw new Exception("session already exists: " + s.ID);

            ss[s.ID] = s;
        }

        // 移除会话
        public void Remove(Session s)
        {
            Remove(s.ID);
        }

        // 移除会话
        public void Remove(string id)
        {
            ss.Remove(id);
        }

        // 获取所有会话
        public Session[] All
        {
            get
            {
                return ss.Values.ToArray();
            }
        }

        // 获取数量
        public int Count
        {
            get
            {
                return ss.Count;
            }
        }

        // 获取所有有效连接
        public Connection[] AllConnections
        {
            get
            {
                List<Connection> conns = new List<Connection>();
                foreach (Session s in ss.Values)
                {
                    if (s != null && s.Conn != null && s.Conn.IsConnected)
                        conns.Add(s.Conn);
                }

                return conns.ToArray();
            }
        }

        //// 获取所有会话
        //public Session[] AllSessions
        //{
        //    get
        //    {
        //        List<Session> sessions = new List<Session>();
        //        foreach (Session s in ss.Values)
        //            sessions.Add(s);
        //        return sessions.ToArray();
        //    }
        //}
        //public Connection[] GetConnections(Func<Session, bool> result)
        //{
        //    List<Connection> conns = new List<Connection>();
        //    foreach (Session s in ss.Values)
        //    {
        //        if (s != null && s.Conn != null && s.Conn.IsConnected
        //            && result(s))
        //            conns.Add(s.Conn);
        //    }

        //    return conns.ToArray();
        //}

        #region 保护部分

        // 会话对象表
        Dictionary<string, Session> ss = new Dictionary<string, Session>();

        #endregion
    }
}
