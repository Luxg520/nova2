using System.Collections;
using Swift;

/// <summary>
/// 客户端游戏核心对象，引用所有逻辑模块并负责主要驱动
/// </summary>
public class GameCore : ObjSingleton<GameCore>
{
//     static GameCore instance = null;
//     public static GameCore Instance
//     {
//         get
//         {
//             if (instance == null)
//                 instance = new GameCore();
//             return instance;
//         }
//     }

    void AddAgent(Agent_Logic agent, string comName, string serverComName)
    {
        agent.A.ServerComponentName = serverComName;
        core_Logic.Add(comName, agent);
    }

    void InitAgents()
    {
        AddAgent(new LoginAgent(), "LoginAgent", "LoginPort");
    }

    public void Init()
    {
        // iTweenRoot
        new UnityEngine.GameObject("iTweenRoot").AddComponent<iTweenRoot>();
    }

    // 连接服务器
    public void ConnectServer(string ip, int port, System.Action<Connection, string> callback)
    {
        NetCore nc = core.Get<NetCore>();
        nc.Close();

        UnityEngine.Debug.Log("ConnectServer " + ip + ":" + port);

        nc.Connect2Peer(ip, port, (Connection conn, string reason) =>
        {
            ResetAllConnection(conn);
            callback(conn, reason);
        });
    }

    // 关闭网络连接
    public void CloseNetConnections()
    {
        NetCore nc = core.Get<NetCore>();
        nc.Close();
    }

    // 当前服务器连接对象
    public Connection CurrentServerConnection { get { return srvConn; } }
    Connection srvConn = null;

    public void OnTimeElapsed(int te)
    {
        core.RunOneFrame(te);
        core_Logic.RunOneFrame(te);
    }

    #region 保护部分

    // 等待服务器连接成功后，设置好所有网络相关模块的连接对象
    void ResetAllConnection(Connection conn)
    {
        srvConn = conn;
        Component[] arr = core.All;
        for (int i = 0; i < arr.Length; i++)
        {
            Component c = arr[i];
            if (c is PortAgent)
            {
                PortAgent pa = c as PortAgent;
                pa.Setup(conn);
            }
        }
    }

    Core core = new Core();
    Core_Logic core_Logic = new Core_Logic();

    #endregion
}
