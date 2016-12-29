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
    /// 登录端口
    /// </summary>
    public class LoginPort : NovaPort
    {
        // 登录管理器
        public LoginManager LgMgr
        {
            get;
            set;
        }

        // ping 管理器
        public PingManager PingMgr
        {
            get;
            set;
        }
        
        // 构造器中预制好所有的消息映射
        public LoginPort()
        {
            OnRequest("Login", OnLogin);
            OnRequest("Ping", OnPing);
            OnRequest("RandomName", OnRandomName);
        }

        #region 保护部分

        public static List<string> ClientVersionNeedForceUpdate = new List<string>()
        {
            //"1.300.07",
        };

        // 登录请求
        void OnLogin(Connection conn, IReadableBuffer data, IWriteableBuffer buff, Action end)
        {
            string uidPart1 = data.ReadString();

            // 注意，这种方式固定为内网
            // 强制加前缀
            // uid = "neiwang_" + uid;

            string name = data.ReadString();
            string pwd = data.ReadString();
            LoginType type = (LoginType)data.ReadInt();

            string uid = uidPart1;
            LgMgr.Login(conn, uid, name, pwd, type, buff, end);
        }


        // Ping 检测
        void OnPing(User usr, IReadableBuffer data, IWriteableBuffer buff)
        {
            ulong client2015 = data.ReadULong();
            ulong server2015 = TimeMgr.Inst.SecondsSince2015;
            ulong d = client2015 > server2015 ? client2015 - server2015 : server2015 - client2015;
            if (d > 5)
            {
                buff.Write(false);
                buff.Write(server2015);
            }
            else
            {
                buff.Write(true);
            }
            PingMgr.OnPing(usr,LoginType.Simple);
        }

        // 随机名字
        void OnRandomName(Connection conn, IReadableBuffer data, IWriteableBuffer buff, Action end)
        {
            LgMgr.RandomName(buff, end);
        }

        #endregion
    }
}
