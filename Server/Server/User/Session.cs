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
    /// 会话对象
    /// </summary>
    public class Session
    {
        // 会话 ID 就是用户 ID
        public string ID
        {
            get
            {
                return User == null ? null : User.ID;
            }
        }

        // 用户信息
        public User User
        {
            get;
            set;
        }

        // 网络连接对象
        public Connection Conn
        {
            get;
            set;
        }

        // 最近一次 ping 的时间
        public ulong LastPingTime
        {
            get;
            set;
        }
    }
}
