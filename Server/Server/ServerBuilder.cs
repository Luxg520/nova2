using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Swift;
using Nova;
using Server;

namespace Server
{
    /// <summary>
    /// 对给定的服务器对象进行执行的构建和装配工作
    /// </summary>
    public static class ServerBuilder
    {
        const int MS4OneMinutes = 60000;

        // 构建一个实验室内用的服务器
        public static void BuildLibServer(NovaServer srv, string ip, int port, 
            string dbName, string dbServer, string userName, string password, string inputFile,
            string logDbName, string logDbServer, string logUserName, string logPassword)
        {
            // 服务器崩溃异常日志
            ServerLogger log = new ServerLogger(typeof(ServerBuilder));

            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleAllUnhandledException);

            // 网络模块
            NetCore nc = new NetCore();
            srv.Add("NetCore", nc);

            // 会话容器
            SessionContainer sc = new SessionContainer();

            // 用户容器
            MySqlPersistence<User, string> p = new MySqlPersistence<User, string>(dbName, dbServer, userName, password, "Users"
                //SqlitePersistence<User, string> p = new SqlitePersistence<User, string>(@"data\users.db", "Users"
                , "CREATE TABLE Users(ID VARCHAR(100) BINARY, Data MediumBlob, Name VARCHAR(20) BINARY, Level INT, PRIMARY KEY(ID ASC));"
                , new string[] { "Name", "Level", },
                (User usr, IWriteableBuffer buff) =>
                {
                    buff.Write(usr.Info);
                }, (IReadableBuffer data) =>
                {
                    if (data == null)
                        return null;

                    UserInfo info = data.Read<UserInfo>();
                    User usr = new User(info);
                    return usr;
                }, (User usr, string col) =>
                {
                    switch (col)
                    {
                        case "Name":
                            return usr.Info.Name;
                        case "Level":
                            return usr.Info.Level;
                    }
                    return null;
                }
            );
            UserContainer uc = new UserContainer(p);
            uc.Interval = MS4OneMinutes;
            srv.Add("UserContainer", uc);
            uc.Start();

            // 杂项容器
            MySqlPersistence<MiscData, int> pMisc = new MySqlPersistence<MiscData, int>(dbName, dbServer, userName, password, "Misc",
                "CREATE TABLE Misc(ID INT, Data BLOB, PRIMARY KEY(ID ASC))", null,
                (MiscData d, IWriteableBuffer buff) =>
                {
                    buff.Write(d.ID);
                    d.Serialize(buff);
                }, (IReadableBuffer data) =>
                {
                    if (data == null)
                        return null;
                    int id = data.ReadInt();
                    MiscData d = new MiscData((MiscDataType)id);
                    d.Deserialize(data);
                    return d;
                }, null);
            MiscContainer mc = new MiscContainer(pMisc);
            mc.Interval = MS4OneMinutes;
            srv.Add("MiscContainer", mc);
            mc.Start();
            // 开服把杂项全载进来
            Action mcInit = srv.Get<LaunchWaitList>().Add("MiscData");
            mc.LoadAll((datas) =>
            {
                // 记录首次开服时间
                MiscData openGSTime = mc.GetByType(MiscDataType.OpenServerTime);
                if (openGSTime == null)
                {
                    openGSTime = new MiscData(MiscDataType.OpenServerTime);
                    openGSTime.SetObj(TimeMgr.Inst.SecondsSince2015);
                    mc.AddNew(openGSTime);
                }
                mcInit();
            }, null);

            // 用户数据更新模块
            UserDataNotifier udn = new UserDataNotifier();
            udn.SC = sc;
            udn.ClientComponentName = "UserDataNotifyPort";

            // 时钟管理
            TimeMgr tmMgr = TimeMgr.Inst; //new TimeMgr();
            tmMgr.MC = mc;

            // 定时器
            //Swift.Timer timer = new Swift.Timer();
            //srv.Add("Timer", timer);

            // 周期管理器
            PeriodMgr periodMgr;
            {
                periodMgr = new PeriodMgr();
                srv.Add("PeriodMgr", periodMgr);
            }
            // 随机名字库
            RndNameGenerator rng = new RndNameGenerator();
            rng.Load();


            // 登录管理
            LoginManager lgMgr = null;
            {
                lgMgr = new LoginManager();
                lgMgr.SC = sc;
                lgMgr.UC = uc;
                lgMgr.RNG = rng;
                lgMgr.ClientComponentName = "LoginPort";
                srv.Add("LoginManager", lgMgr);

                // ping 管理
                PingManager pingMgr = new PingManager();
                pingMgr.SC = sc;
                pingMgr.LgMgr = lgMgr;
                pingMgr.CheckInterval = 10; // 10 秒检查间隔
                pingMgr.ExpiredTime = 10; // 10秒超时
                lgMgr.AfterUserLogin += pingMgr.OnPing; // 登录后就马上登记 ping 时间
                srv.Add("PingManager", pingMgr);
                pingMgr.Start();

                LoginPort lgP = new LoginPort();
                lgP.LgMgr = lgMgr;
                lgP.PingMgr = pingMgr;
                srv.Add("LoginPort", lgP);
            }

            // 控制台
            NovaConsole console = new NovaConsole();
            console.ServerCore = srv;
            console.UC = uc;
            console.SC = sc;
            console.CloseServerFunc = () => { srv.Stop(); };
            srv.Add("NovaConsole", console);

            // 监听文件输入
            FileMonitor fm = new FileMonitor();
            fm.OnUpdated += (string f) =>
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(f);
                string[] cmds = sr.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                sr.Close();
                foreach (string c in cmds)
                    console.ProcessInputCommmand(c);
            };
            srv.Add("FileMonitor", fm);
            fm.Add(inputFile);
            fm.Start();

            // 这个放最后
            // 因为必须所有活动都注册完了才能 CheckActivity

            // 调试对象容器
            srv.Add("DebugObjContainer", new DebugObjContainer());

            // 等待各模块初始化操作完成
            srv.Get<LaunchWaitList>().OnWaitListFinished += () =>
            {
            };
        }



        // 处理所有未被处理的异常信息
        static void HandleAllUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            ServerLogger log = new ServerLogger(typeof(UnhandledExceptionEventArgs));
            try
            {
                // 已经没办法恢复了，只能死在这
                log.Error("Terminating " + e.IsTerminating.ToString());
                log.Error("ExceptionObject " + e.ExceptionObject == null ? " null " : e.ExceptionObject.ToString());
            }
            catch (Exception ex)
            {
                log.Error("Exception in HandleAllUnHandledException: " + ex.Message);
            }
        }
    }
}
