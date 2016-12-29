using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swift;
using Nova;

namespace Server
{
    // 必须携带会话容器的功能端口
    public class NovaPort : Port
    {

        #region User

        // 注册无需应答的网络消息处理函数
        public void OnMessage(string op, Action<User, IReadableBuffer> callback)
        {
            OnMessage(op, (Connection conn, IReadableBuffer data) =>
            {
                Session s = conn.Tag as Session;
                if (s == null || s.User == null)
                    return;
                else
                    callback(s.User, data);
            });
        }

        // 注册无需应答的网络消息处理函数
        public void OnMessage(string op, Action<User> callback)
        {
            OnMessage(op, (Connection conn, IReadableBuffer data) =>
            {
                Session s = conn.Tag as Session;
                if (s == null || s.User == null)
                    return;
                else
                    callback(s.User);
            });
        }

        // 注册需要应答的网络消息处理函数
        public void OnRequest(string op, Action<User, IReadableBuffer, IWriteableBuffer> callback)
        {
            OnRequest(op, (Connection conn, IReadableBuffer data, IWriteableBuffer buff) =>
            {
                Session s = conn.Tag as Session;
                if (s == null || s.User == null)
                    return;
                else
                    callback(s.User, data, buff);
            });
        }

        // 注册需要应答的网络消息函数
        public void OnRequest(string op, Func<User, IReadableBuffer, ReasonEnums> callback)
        {
            OnRequest(op, (Connection conn, IReadableBuffer data, IWriteableBuffer buff) =>
            {
                Session s = conn.Tag as Session;
                if (s == null || s.User == null)
                    return;

                ReasonEnums r = callback(s.User, data);
                buff.Write((int)r);
            });
        }

        // 注册需要应答的网络消息处理函数
        public void OnRequest(string op, Action<User, IReadableBuffer, IWriteableBuffer, Action> callback)
        {
            OnRequest(op, (Connection conn, IReadableBuffer data, IWriteableBuffer buff, Action end) =>
            {
                Session s = conn.Tag as Session;
                if (s == null || s.User == null)
                    return;
                else
                    callback(s.User, data, buff, end);
            });
        }

        // 注册需要应答的网络消息函数
        public void OnRequest(string op, Action<User, IReadableBuffer, Action<ReasonEnums>> callback)
        {
            OnRequest(op, (Connection conn, IReadableBuffer data, IWriteableBuffer buff, Action end) =>
            {
                Session s = conn.Tag as Session;
                if (s == null || s.User == null)
                    return;

                callback(s.User, data, (ReasonEnums r) => { buff.Write((int)r); end(); });
            });
        }
        #endregion

    }
}
