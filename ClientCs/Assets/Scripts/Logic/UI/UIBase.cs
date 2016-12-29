using UnityEngine;
using System.Collections;

public class UIBase : MonoBehaviour
{
    // UI信息    
    public UIInfo UIInfo;


    // 隐藏该界面
    public void Hide()
    {
        OnHide();
        gameObject.SetActive(false);
    }


    /// <summary>
    /// 仅首次显示前调用
    /// 优先级高于Init
    /// </summary>
    protected virtual void Awake()
    {

    }
    protected virtual void Start()
    {

    }

    /// <summary>
    /// 界面初始化阶段（主要用于界面数据处理）
    /// 每次开启界面都会调用一次
    /// 不要在这里面播放UI动画相关操作
    /// </summary>
    public virtual void OnInit(params object[] _params)
    {

    }

    /// <summary>
    /// 界面显示阶段（相当于Start）
    /// 可用于播放动画
    /// </summary>
    protected virtual void OnShow()
    {

    }

    /// <summary>
    /// 界面隐藏前调用
    /// </summary>
    protected virtual void OnHide()
    {

    }

    /// <summary>
    /// 每帧执行函数
    /// 尽量不用，非必要时才用
    /// </summary>
    protected virtual void OnUpdate(float _deltaTime)
    {

    }

    /// <summary>
    /// 当界面被卸载时
    /// </summary>
    protected virtual void OnDestroy()
    {

    }


    #region 内部函数

    /// <summary>
    /// 每帧运行（内部函数）
    /// </summary>
    void Update()
    {
        OnUpdate(Time.deltaTime);
    }

    #endregion
}
