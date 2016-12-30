using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Nova;

public class UIManager : MonoBehaviour// : GoSington<UIManager>
{
    static UIManager instance = null;
    public static UIManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject go = new GameObject("_UIManager");
                instance = go.AddComponent<UIManager>();
                DontDestroyOnLoad(go);
            }
            return instance;
        }
    }

    public Transform Root;
    public Transform UICanvas;

    // 所有已注册UI
    private Dictionary<UIType, UIInfo> m_UIDict = new Dictionary<UIType, UIInfo>();
    // 已加载UI
    private Dictionary<UIType, UIInfo> m_LoadedUI = new Dictionary<UIType, UIInfo>();

    private void Awake()
    {
        Root = GameObject.Find("Root").transform;
        UICanvas = Root.Find("UICanvas");

        RegisterUIs();
    }

    // 返回指定层级UICanvas
    public Transform GetUICanvas(UILayer _layer)
    {
        switch (_layer)
        {
            case UILayer.Game:
                return UICanvas;
//             case UILayer.Prepose:
//                 return PreposeUICanvas;
//             case UILayer.Guide:
//                 return GuideUICanvas;
//             case UILayer.Test:
//                 return TestUICanvas;
        }
        return null;
    }

    // 显示UI界面（采用异步方式）
    public void ShowUI<T>(UIType _type, UILayer _layer, params object[] _params) where T : UIBase
    {
        // UI 是否已注册
        if (!m_UIDict.ContainsKey(_type))
            throw new Exception("UI has not register!");

        // 加载并显示UI        
        if (m_LoadedUI.ContainsKey(_type))
            ShowUI_Internal(m_LoadedUI[_type], _layer, _params);
        else
        {
            // 加载UI
            Instance.LoadAsyncUI<T>(_type, (uiInfo) =>
            {
                ShowUI_Internal(uiInfo, _layer, _params);
            });
        }
    }

    // 异步加载UI
    private void LoadAsyncUI<T>(UIType _type, Action<UIInfo> cb) where T : UIBase
    {
        // 加载UI资源并实例化GameObject
        UIInfo uiInfo = m_UIDict[_type];
        string abName = ResourceConfig.GetUIPath(uiInfo.resName);
        ResourceManager.Instance.Load(abName, (obj) =>
        {
            GameObject go = (GameObject)Instantiate(obj);
            uiInfo.ui = go.AddComponent<T>();
            uiInfo.ui.UIInfo = uiInfo;

            // 缓存界面
            m_LoadedUI.Add(_type, uiInfo);

            // 回调
            if (cb != null)
                cb(uiInfo);
        });
    }

    // 显示UI界面内部函数
    private void ShowUI_Internal(UIInfo uiInfo, UILayer _layer, params object[] _params)
    {
        uiInfo.layer = _layer;
        UIBase ui = uiInfo.ui;

        // 显示UI
        Transform uiTrans = GetUICanvas(_layer);
        Utils.AddUIChild(uiTrans, ui.Trans);
        ui.gameObject.SetActive(true);

        // 初始化
        ui.OnInit(_params);
    }

    // 注册UI，所有需要显示的UI都要注册，否则无法显示
    private void AddUI(UIType _type, UIStyle _style, string _resName)
    {
        UIInfo uiInfo = new UIInfo();
        {
            uiInfo.type = _type;
            uiInfo.style = _style;
            uiInfo.resName = _resName;
        }

        m_UIDict.Add(_type, uiInfo);
    }

    private void RegisterUIs()
    {
        // 登录
        AddUI(UIType.LoginUI, UIStyle.Simple, "LoginUI");
    }
}