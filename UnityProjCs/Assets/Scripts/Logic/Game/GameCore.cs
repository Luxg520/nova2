using System.Collections;
using Swift;

/// <summary>
/// 客户端游戏核心对象，引用所有逻辑模块并负责主要驱动
/// </summary>
public class GameCore
{
    public static GameCore Instance { get { return inst; } }
    static GameCore inst = new GameCore();    

    void AddAgent(Agent_Logic agent, string comName, string serverComName)
    {
        agent.A.ServerComponentName = serverComName;
        core_Logic.Add(comName, agent);
    }

    public void Init()
    {
        AddAgent(new LoginAgent(), "LoginAgent", "LoginPort");

        // 显示登录界面
        UnityEngine.GameObject prefab = (UnityEngine.GameObject)EditorEnv.LoadMainAssetAtPath("Assets/AssetBundles/Prefabs/LoginUI.prefab");
        UnityEngine.GameObject go = (UnityEngine.GameObject)UnityEngine.Object.Instantiate(prefab);
        UnityEngine.Transform uiCanvas = UnityEngine.GameObject.Find("Root/UICanvas").transform;
        go.transform.SetParent(uiCanvas, false);
        go.AddComponent<LoginUI>();
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
