using System;
using System.Collections.Generic;
using System.Text;
using Swift;
using Nova;

namespace Server
{
    /// <summary>
    /// 通知客户端进行数据更新的模块
    /// </summary>
    public class UserDataNotifier : NetComponent
    {
        public class ActionList
        {
            List<Action<IWriteableBuffer>> lst = null;
            public void Add(Action<IWriteableBuffer> a)
            {
                if (lst == null)
                    lst = new List<Action<IWriteableBuffer>>();
                lst.Add(a);
            }
            public void Notify(IWriteableBuffer w)
            {
                if (lst != null)
                {
                    foreach (var a in lst)
                    {
                        a(w);
                    }
                    lst.Clear();
                }
            }
        }

        public SessionContainer SC = null;

        // 客户端对应的模块名称
        public string ClientComponentName = null;

        // 通知客户端数据更新
        public void Notify(UserInfo userInfo, Action<IWriteableBuffer> callback)
        {
            Session s = SC.GetByID(userInfo.ID);
            if (s == null || s.Conn == null)
                return;

            NetUtils.Send("DataUpdated", ClientComponentName, callback, s.Conn);
        }

        public void Notify(string id, Action<IWriteableBuffer, UserInfo> callback)
        {
            Session s = SC.GetByID(id);
            if (s == null || s.Conn == null || s.User == null)
                return;

            NetUtils.Send("DataUpdated", ClientComponentName, (buff) => { callback(buff, s.User.Info); }, s.Conn);
        }

        public void Notify(Session s, Action<IWriteableBuffer> callback)
        {
            if (s == null || s.Conn == null)
                return;
            NetUtils.Send("DataUpdated", ClientComponentName, callback, s.Conn);
        }

        public void Notify(Connection conn, Action<IWriteableBuffer> callback)
        {
            NetUtils.Send("DataUpdated", ClientComponentName, callback, conn);
        }
        

        // 通知客户端错误消息
        public void Error(UserInfo userInfo, ReasonEnums r)
        {
            if (r == ReasonEnums.Ok)
                return;

            Session s = SC.GetByID(userInfo.ID);
            if (s == null || s.Conn == null)
                return;

            NetUtils.Send("ErrorMessage", ClientComponentName, (IWriteableBuffer buff) => { buff.Write((int)r); }, s.Conn);
        }
    }
}
