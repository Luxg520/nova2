using UnityEngine;
using System.Collections;

/// <summary>
/// 客户端游戏核心对象，引用所有逻辑模块并负责主要驱动
/// </summary>
public class GameCore
{
    // 单件实例对象
    public static GameCore Instance
    {
        get
        {
            return inst;
        }
    }
    static GameCore inst = new GameCore();

    // 初始化标记
    bool inited = false;
    // 初始化，重复执行初始化会被自动忽略
    public void Init()
    {
        if (inited)
            return;

        inited = true;

        // 显示登录界面
        GameObject prefab = (GameObject)EditorEnv.LoadMainAssetAtPath("Assets/AssetBundles/Prefabs/LoginUI.prefab");
        GameObject go = (GameObject)UnityEngine.Object.Instantiate(prefab);
        Transform uiCanvas = GameObject.Find("Root/UICanvas").transform;
        go.transform.SetParent(uiCanvas, false);
        go.AddComponent<LoginUI>();
    }
}
