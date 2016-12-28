using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 缓动动画工具类
/// </summary>
public static class ItweenUtils
{
    private static float scale = 0;
    
    #region                                                 界 面 动 画 处 理
	
	// 弹出小界面
	public static void PopupLittleFrame(this GameObject frame, Action<float> alphaCallBack, Action endCallBack = null)
	{
        // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
        frame.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);   //clipped panel  缩放比必须一致
		frame.Extend(iTween.EaseType.easeOutBack, 0.15f).Delay(0.05f).OnComplete(()=>{EndCallBack(endCallBack);}).Start();
		
		alphaCallBack (0);
		frame.Value0To1(0.1f, alphaCallBack).Delay(0.05f).Start();
	}
	public static void PopupLittleFrameEnd(this GameObject frame, Action<float> alphaCallBack, Action endCallBack)
	{
		// TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
		frame.StopTween();
		frame.ScaleTo(new Vector3(0.6f, 0.6f, 0.6f), iTween.EaseType.easeInBack, 0.15f).OnComplete(()=>{EndCallBack(endCallBack);}).Start();
		
		frame.Value1To0(0.15f, alphaCallBack).EaseType(iTween.EaseType.easeInSine).Start();
	}

    // 弹出界面
    public static void PopupFrame(this GameObject frame, Action<float> alphaCallBack, Action endCallBack = null)
    {
        // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
        frame.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);   //clipped panel  缩放比必须一致
		frame.Extend(iTween.EaseType.easeOutBack, 0.25f).Delay(0.05f).OnComplete(()=>{EndCallBack(endCallBack);}).Start();
		
		alphaCallBack (0);
		frame.Value0To1(0.15f, alphaCallBack).Delay(0.05f).Start();
    }

    public static void PopupFrameEnd(this GameObject frame, Action<float> alphaCallBack, Action endCallBack)
    {
        // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
        frame.StopTween();
		frame.ScaleTo(new Vector3(0.4f, 0.4f, 0.4f), iTween.EaseType.easeInBack, 0.25f).OnComplete(()=>{EndCallBack(endCallBack);}).Start();

		frame.Value1To0(0.25f, alphaCallBack).EaseType(iTween.EaseType.easeInSine).Start();
    }

	
	// 弹出大界面 (参照皇室战争)
	public static void PopupBigFrame(this GameObject frame, Action<float> alphaCallBack = null, Action endCallBack = null)
	{
        // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
        Vector3[] scalePath = new Vector3[]{
			new Vector3(1.005f, 1.005f, 1.005f),
			new Vector3(1.015f, 1.015f, 1.015f),
			new Vector3(1.012f, 1.012f, 1.012f), 
			new Vector3(1.003f, 1.003f, 1.003f),
			new Vector3(1f, 1f, 1f)
		};
		frame.transform.localScale = new Vector3(0.0001f, 0.0001f, 0.0001f);
		frame.ScaleToPath(scalePath, iTween.EaseType.easeOutSine, 0.25f).Delay(0.05f).OnComplete(()=>{EndCallBack(endCallBack);}).Start();

		if (alphaCallBack != null)
			alphaCallBack (1);
	}    
	public static void PopupBigFrameEnd(this GameObject frame, Action endCallBack = null)
	{
        // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
        Vector3[] scalePath = new Vector3[]{
			new Vector3(1f, 1f, 1f),
			new Vector3(1.01f, 1.01f, 1.01f), 
			new Vector3(0.995f, 0.995f, 0.995f),
			new Vector3(0.96f, 0.96f, 0.96f)
		};
		frame.StopTween();
		frame.ScaleToPath(scalePath, iTween.EaseType.easeOutSine, 0.2f).OnComplete(()=>{EndCallBack(endCallBack);}).Start();
	}

	//数字弹动表现 (参照炉石传说)
	public static void PopupNum(this GameObject frame, float delay = 0, Action endCallBack = null)
	{
		frame.StopTween ();
		Vector3[] scalePath = new Vector3[]{
			new Vector3(1f, 1f, 1f),
			new Vector3(1.35f, 1.35f, 1.35f),
			new Vector3(1.5f, 1.5f, 1.5f), 
			new Vector3(1.35f, 1.35f, 1.35f),
			new Vector3(1f, 1f, 1f),
			new Vector3(0.85f, 0.85f, 0.85f),
			new Vector3(0.95f, 0.95f, 0.95f),
			new Vector3(1.05f, 1.05f, 1.05f),
			new Vector3(1.15f, 1.15f, 1.15f),
			new Vector3(1.1f, 1.1f, 1.1f),
			new Vector3(1f, 1f, 1f)};
		frame.ScaleToPath (scalePath, iTween.EaseType.linear, 0.35f).Delay(delay).Start ();

		if (endCallBack != null)
			frame.CallBackLater(0.35f + delay, endCallBack);
	}
	public static void PopupNum2(this GameObject frame, float delay = 0, Action endCallBack = null)
	{
		frame.StopTween ();
		Vector3[] scalePath = new Vector3[]{
			new Vector3(1f, 1f, 1f),
			new Vector3(1.25f, 1.25f, 1.25f),
			new Vector3(1.35f, 1.35f, 1.35f), 
			new Vector3(1.25f, 1.25f, 1.25f),
			new Vector3(1f, 1f, 1f),
			new Vector3(0.85f, 0.85f, 0.85f),
			new Vector3(0.95f, 0.95f, 0.95f),
			new Vector3(1.05f, 1.05f, 1.05f),
			new Vector3(1.1f, 1.1f, 1.1f),
			new Vector3(1f, 1f, 1f)};
		frame.ScaleToPath (scalePath, iTween.EaseType.linear, 0.4f).Delay(delay).Start ();
		
		if (endCallBack != null)
			frame.CallBackLater(0.4f + delay, endCallBack);
	}	
	public static void PopupNum3(this GameObject frame, float delay = 0, Action endCallBack = null)
	{
		frame.StopTween ();
		Vector3[] scalePath = new Vector3[]{
			new Vector3(1f, 1f, 1f),
			new Vector3(1.15f, 1.15f, 1.15f),
			new Vector3(1.2f, 1.2f, 1.2f), 
			new Vector3(1.15f, 1.15f, 1.15f),
			new Vector3(1f, 1f, 1f),
			new Vector3(0.9f, 0.9f, 0.9f),
			new Vector3(0.93f, 0.93f, 0.93f),
			new Vector3(1.03f, 1.03f, 1.03f),
			new Vector3(1.08f, 1.08f, 1.08f),
			new Vector3(1.04f, 1.04f, 1.04f),
			new Vector3(1f, 1f, 1f)};
		frame.ScaleToPath (scalePath, iTween.EaseType.linear, 0.35f).Delay(delay).Start ();
		
		if (endCallBack != null)
			frame.CallBackLater(0.35f + delay, endCallBack);
	}

	//数字弹动表现 (参照炉石传说)
	public static void PopupNumFromZero(this GameObject frame, float delay = 0, Action endCallBack = null)
	{
		frame.StopTween ();
		Vector3[] scalePath = new Vector3[]{
			new Vector3(0f, 0f, 0f),
			new Vector3(0.8f, 0.8f, 0.8f),
			new Vector3(1.3f, 1.3f, 1.3f),
			new Vector3(1f, 1f, 1f),
			new Vector3(0.85f, 0.85f, 0.85f),
			new Vector3(1f, 1f, 1f),
			new Vector3(1.1f, 1.1f, 1.1f),
			new Vector3(1f, 1f, 1f)};
		
		frame.transform.localScale = Vector3.zero;
		frame.ScaleToPath (scalePath, iTween.EaseType.linear, 0.35f).Delay(delay).Start ();
		
		if (endCallBack != null)
			frame.CallBackLater(0.35f + delay, endCallBack);
	}


	//物品摇动表现 (参照七骑士)
	public static void ShakeItem(this GameObject frame, float delay = 0, Action endCallBack = null)
	{
		frame.StopTween ();
		Vector3[] rotatePath = new Vector3[]{			
			new Vector3(0, 0, 0),
			new Vector3(0, 0, 15),
			new Vector3(0, 0, 0),
			new Vector3(0, 0, -13f),
			new Vector3(0, 0, 0),
			new Vector3(0, 0, 11f),
			new Vector3(0, 0, 0),
			new Vector3(0, 0, -9f),
			new Vector3(0, 0, 0),
			new Vector3(0, 0, 7f),
			new Vector3(0, 0, 0),
			new Vector3(0, 0, -6),
			new Vector3(0, 0, -4),
			new Vector3(0, 0, 0),
		};
		frame.RotateToPath (rotatePath, 0.5f).EaseType(iTween.EaseType.linear).Delay(delay).Start ();
		
		if (endCallBack != null)
			frame.CallBackLater(0.5f + delay, endCallBack);
	}
	//弹幕颜色摇动
	public static void ShakeDanmakuItem(this GameObject frame, float delay = 0, Action endCallBack = null)
	{
		Vector3[] rotatePath = new Vector3[]{	
			new Vector3(0, 0, -17),	
			new Vector3(0, 0, 0),
			new Vector3(0, 0, 15),
			new Vector3(0, 0, 0),
			new Vector3(0, 0, -13f),
			new Vector3(0, 0, 0),
			new Vector3(0, 0, 11f),
			new Vector3(0, 0, 0),
			new Vector3(0, 0, -9f),
			new Vector3(0, 0, 0),
			new Vector3(0, 0, 7f),
			new Vector3(0, 0, 0),
			new Vector3(0, 0, -6),
			new Vector3(0, 0, -4),
			new Vector3(0, 0, 0),
		};
		frame.RotateToPath (rotatePath, 0.5f).EaseType(iTween.EaseType.linear).Delay(delay).Start ();
		
		if (endCallBack != null)
			frame.CallBackLater(0.5f + delay, endCallBack);
	}


//	public static void PopupBigFrameEnd(this GameObject frame, Action<float> alphaCallBack, Action endCallBack)
//	{
//		frame.StopTween();
//		frame.ScaleTo(new Vector3(0.8f, 0.8f, 0.8f), iTween.EaseType.easeInBack, 0.25f).Delay(0.05f).OnComplete(endCallBack).Start();
//		
//		if (alphaCallBack != null)
//			frame.Value1To0(0.2f, alphaCallBack).Delay(0.05f).Start();
//	}
//
//    //弹出小选项  
//    public static void PopupSmallFrame(GameObject frame, GameObject panel, string alphaCallBack, string endCallBack)
//    {        
//        panel.transform.localScale = new Vector3(0.0001f, 0.0001f, 0.0001f);   //clipped panel  缩放比必须一致
//        ItweenUtils.Extend(panel, iTween.EaseType.easeOutBack, 0.1f);
//        if(!String.IsNullOrEmpty(alphaCallBack))
//            ItweenUtils.ValueToOne(frame, 0.08f, alphaCallBack);
//        if(!String.IsNullOrEmpty(endCallBack))
//            ItweenUtils.CallBackLater(frame, 0.1f, endCallBack);
//    }
//    public static void PopupSmallFrameEnd(GameObject frame, GameObject panel, string alphaCallBack, string endCallBack)
//    {        
//        ItweenUtils.Stop(frame);
//        ItweenUtils.Stop(panel);
//        ItweenUtils.Shrink(panel.gameObject, iTween.EaseType.easeInSine, 0.1f, frame, endCallBack);
//        if(!String.IsNullOrEmpty(alphaCallBack))
//            ItweenUtils.ValueToZero(frame, 0.1f, alphaCallBack);
//    }
//
    //下拉界面
	public static void PullDownFrame(this GameObject frame, Action<float> alphaCallBack = null, Action endCallBack = null)
	{
        // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
        frame.transform.localPosition = new Vector3(0, Screen.height);
		frame.MoveTo(frame.transform.localPosition - new Vector3(0, Screen.height, 0), iTween.EaseType.easeOutBack, 0.4f).Delay(0.05f).OnComplete(()=>{EndCallBack(endCallBack);}).Start();
		
		if (alphaCallBack != null)
		{
			alphaCallBack(0);
			frame.Value0To1 (0.2f, alphaCallBack).Delay (0.05f).Start ();
		}
    }
	public static void PullDownFrameEnd(this GameObject frame, Action<float> alphaCallBack = null, Action endCallBack = null, bool isBack = false)
    {
        // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
        frame.StopTween();
		iTween.EaseType easeTYpe = isBack ? iTween.EaseType.easeInExpo : iTween.EaseType.easeInSine;
		float time = isBack ? 0.4f : 0.3f;

		frame.MoveTo(frame.transform.localPosition + new Vector3(0, Screen.height, 0), easeTYpe, time).OnComplete(()=>{EndCallBack(endCallBack);}).Start();
		
		if (alphaCallBack != null)
			frame.Value1To0(0.2f, alphaCallBack).Start();
    }

	
	//下拉渐显界面
	public static void PullDownFadeFrame(this GameObject frame, Action<float> alphaCallBack = null, Action endCallBack = null)
	{
        // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
        frame.transform.localPosition = new Vector3(0, Screen.height/2);
		frame.MoveTo(frame.transform.localPosition - new Vector3(0, Screen.height/2, 0), iTween.EaseType.easeOutBack, 0.3f).Delay(0.05f).OnComplete(()=>{EndCallBack(endCallBack);}).Start();
		
		if (alphaCallBack != null)
			frame.Value0To1(0.15f, alphaCallBack).Delay(0.05f).Start();
	}
	public static void PullDownFadeFrameEnd(this GameObject frame, Action<float> alphaCallBack = null, Action endCallBack = null)
	{
        // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
        frame.StopTween();		
		frame.MoveTo(frame.transform.localPosition + new Vector3(0, Screen.height/2, 0), iTween.EaseType.easeInSine, 0.3f).OnComplete(()=>{EndCallBack(endCallBack);}).Start();
		
		if (alphaCallBack != null)
			frame.Value1To0(0.3f, alphaCallBack).Start();
	}

	//右拉界面
	public static void PullRightFrame(this GameObject frame, Action<float> alphaCallBack = null, Action endCallBack = null)
	{
        // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
        frame.transform.localPosition = new Vector3(-Screen.width/1.5f, 0);
		frame.MoveTo(frame.transform.localPosition + new Vector3(Screen.width/1.5f, 0, 0), iTween.EaseType.easeOutQuart, 0.3f).Delay(0.05f).OnComplete(()=>{EndCallBack(endCallBack);}).Start();
	}
	public static void PullRightFrameEnd(this GameObject frame, Action<float> alphaCallBack = null, Action endCallBack = null)
	{
        // TODO UnityEngine.Application.targetFrameRate = GameDriver.MaxFrameRate;
        frame.StopTween();		
		frame.MoveTo(frame.transform.localPosition + new Vector3(-Screen.width/1.5f, 0, 0), iTween.EaseType.easeInQuart, 0.3f).OnComplete(()=>{EndCallBack(endCallBack);}).Start();
	}

	public static void EndCallBack(Action call)
	{
        // TODO UnityEngine.Application.targetFrameRate = GameDriver.MinFrameRate;
        if (call != null)
			call ();
	}
    #endregion

    public class iTweenAct
    {
        public iTweenAct(GameObject go)
        {
            this.go = go;
        }
        public iTween.iTweenDictionary dict;

        public GameObject go;
        public virtual void Start() 
        {
            Debug.LogError("iTweenAct.Start should be override");
        }
        public void Stop()
        {
            iTween.Stop(go);
        }

        // 这个通常放最后（Start前）
        public iTweenAct OnComplete(Action cb)
        {
			if(cb != null)
            	dict.SetCb("onComplete", cb);
            return this;
        }
        // 这个通常放最后（Start前）
        public iTweenAct OnComplete(Action<object> cb, object param)
		{
			if (cb != null) {
				dict.SetCb ("onComplete", cb);
				dict.Set ("onCompleteParams", param);
			}
            return this;
        }
    }



    #region                                                     移  动

    // 外面一般不直接写这个类名
    public class iTweenMoveTo : iTweenAct
    {
        public iTweenMoveTo(GameObject go) : base(go) {

        }
        public iTweenMoveTo Delay(float delay) 
        {
            dict.Set("delay", delay);
            return this;
        }
        public iTweenMoveTo IsWorld()
        {
            dict.Set("islocal", false);
            return this;
        }
        public iTweenMoveTo Speed(float speed)
        {
            dict.Set("speed", speed);
            return this;
        }

        public iTweenMoveTo Loop()
        {
            dict.SetLoopType(iTween.LoopType.loop);
            return this;
        }

        public iTweenMoveTo PingPong()
        {
			dict.SetLoopType(iTween.LoopType.pingPong);
            return this;
        }

        // 开始动画
        public override void Start()
        {
            iTween.MoveTo(go, dict);
        }

        // -----------------------------------------------------------
        // Path

        public iTweenMoveTo LookTime(float looktime)
        {
            dict.Set("looktime", looktime);
            return this;
        }
        public iTweenMoveTo LookTarget(Transform target)
        {
            dict.Set("looktarget", target);
            return this;
        }
        public iTweenMoveTo OrientToPath()
        {
            dict.Set("orienttopath", true);
            return this;
        }
        public iTweenMoveTo Immediate()
        {
            dict.Set("moveToPath", false);
            return this;
        }
		
		new public iTweenMoveTo OnComplete(Action cb)
		{
			return (iTweenMoveTo)base.OnComplete(cb);
		}
    }

    public static iTweenMoveTo MoveTo(this GameObject go, Vector3 point, iTween.EaseType easeType, float time)
    {
        iTweenMoveTo t = new iTweenMoveTo(go);
		{
			t.dict = new iTween.iTweenDictionary();
			t.dict.Set("position", point);
			t.dict.SetEaseType(easeType);
			t.dict.Set("time", time);
			t.dict.Set("islocal", true);
		}
        return t;
	}
	public static iTweenMoveTo MoveToSpeed(this GameObject go, Vector3 point, iTween.EaseType easeType, float speed)
	{
		iTweenMoveTo t = new iTweenMoveTo(go);
		{
			t.dict = new iTween.iTweenDictionary();
			t.dict.Set("position", point);
			t.dict.SetEaseType(easeType);
			t.dict.Set("speed", speed);
			t.dict.Set("islocal", true);
		}
		return t;
	}
    public static iTweenMoveTo MoveToPath(this GameObject go, iTweenPath path, iTween.EaseType easeType, float time)
    {
		iTweenMoveTo t = new iTweenMoveTo(go);
		{
			t.dict = new iTween.iTweenDictionary();
			t.dict.Set("path", path);
			t.dict.SetEaseType(easeType);
			t.dict.Set("time", time);
			t.dict.Set("islocal", true);
        }
        return t;
	}
    public static iTweenMoveTo MoveToPath(this GameObject go, Vector3[] path, iTween.EaseType easeType, float time)
    {
		iTweenMoveTo t = new iTweenMoveTo(go);
		{
			t.dict = new iTween.iTweenDictionary();
			t.dict.SetVector3Array("path", path);
			t.dict.SetEaseType(easeType);
			t.dict.Set("time", time);
			t.dict.Set("islocal", true);
		}
        return t;
    }
    public static iTweenMoveTo MoveToPathSpeed(this GameObject go, Vector3[] path, iTween.EaseType easeType, float speed)
    {
		iTweenMoveTo t = new iTweenMoveTo(go);
		{
			t.dict = new iTween.iTweenDictionary();
			t.dict.SetVector3Array("path", path);
			t.dict.SetEaseType(easeType);
			t.dict.Set("speed", speed);
			t.dict.Set("islocal", true);
        }
        return t;
    }
    #endregion

    
    #region                                                     朝  向

    public class iTweenLookTo : iTweenAct
    {
        public iTweenLookTo(GameObject go) : base(go)
        {

        }
        public override void Start()
        {
            iTween.LookTo(go, dict);
        }
    }

    ///朝向
    public static iTweenLookTo Look(this GameObject go, GameObject target, float time = 0)
    {        
        iTweenLookTo t = new iTweenLookTo(go);
		{
			t.dict = new iTween.iTweenDictionary();
			t.dict.Set("looktarget", target.transform);
			t.dict.Set("time", time);
        }
        return t;
    }
    #endregion

    
    #region                                                     旋  转
    public class iTweenRotate : iTweenAct
    {
        bool isBy = true;
        public iTweenRotate(bool isBy, GameObject go) : base(go)
        {
            this.isBy = isBy;
        }
        public iTweenRotate Delay(float delay)
        {
            dict.Set("delay", delay);
            return this;
		}
        public iTweenRotate EaseType(iTween.EaseType easeType)
        {
			dict.SetEaseType(easeType);
            return this;
        }
        public iTweenRotate Loop()
        {
			dict.SetLoopType(iTween.LoopType.loop);
            return this;
        }
        public override void Start()
        {
            if (isBy)
                iTween.RotateBy(go, dict);
            else
                iTween.RotateTo(go, dict);
        }
    }

    // 旋转
    public static iTweenRotate RotateBy(this GameObject go, Vector3 amount, float time)
    {
        iTweenRotate t = new iTweenRotate(true, go);
		{
			t.dict = new iTween.iTweenDictionary();
			t.dict.Set("amount", amount);
			t.dict.Set("time", time);
			t.dict.SetEaseType(iTween.EaseType.linear);
			t.dict.Set("islocal", true);
        }
        return t;
    }
    
    public static iTweenRotate RotateTo(this GameObject go, Vector3 rotation, float time)
    {
		iTweenRotate t = new iTweenRotate(false, go);
		{
			t.dict = new iTween.iTweenDictionary();
			t.dict.Set("rotation", rotation);
			t.dict.Set("time", time);
			t.dict.Set("islocal", true);
        }
        return t;
	}
	public static iTweenRotate RotateToPath(this GameObject go, Vector3[] path, float time)
	{
		iTweenRotate t = new iTweenRotate(false, go);
		{
			t.dict = new iTween.iTweenDictionary();
			t.dict.Set("path", path);
			t.dict.Set("time", time);
			t.dict.Set("islocal", true);
		}
		return t;
	}
	public static iTweenRotate RotateToPathSpeed(this GameObject go, Vector3[] path, float speed)
	{
		iTweenRotate t = new iTweenRotate(false, go);
		{
			t.dict = new iTween.iTweenDictionary();
			t.dict.Set("path", path);
			t.dict.Set("time", 0);
			t.dict.Set("speed", speed);
			t.dict.Set("islocal", true);
		}
		return t;
	}

    public static iTweenRotate RotateByX(this GameObject go, float x, float time)
    {
        return RotateBy(go, new Vector3(x, 0f, 0f), time);
    }
    public static iTweenRotate RotateByY(this GameObject go, float y, float time)
    {
        return RotateBy(go, new Vector3(0f, y, 0f), time);
    }
    public static iTweenRotate RotateByZ(this GameObject go, float z, float time)
    {
        return RotateBy(go, new Vector3(0f, 0f, z), time);
    }

    #endregion



    #region                                                     缩  放
    public class iTweenScaleTo : iTweenAct
    {
        public iTweenScaleTo(GameObject go) : base(go)
        {

        }
        public iTweenScaleTo Delay(float delay) 
        {
            dict.Set("delay", delay);
            return this;
        }
        public iTweenScaleTo PingPong()
        {
			dict.SetLoopType(iTween.LoopType.pingPong);
            return this;
		}
		public iTweenScaleTo Loop()
		{
			dict.SetLoopType(iTween.LoopType.loop);
			return this;
		}
        public override void Start()
        {
            iTween.ScaleTo(go, dict);
        }
    }

    public static iTweenScaleTo ScaleToPath(this GameObject go, Vector3[] scalePath, iTween.EaseType easeType, float time)
    {
		iTweenScaleTo t = new iTweenScaleTo(go);
		{
			t.dict = new iTween.iTweenDictionary();
			t.dict.SetVector3Array("path", scalePath);
			t.dict.SetEaseType(easeType);
			t.dict.Set("time", time);
        }
        return t;
    }
	
	
	public static iTweenScaleTo ScaleTo(this GameObject go, Vector3 scale, iTween.EaseType easeType, float time)
	{
		iTweenScaleTo t = new iTweenScaleTo(go);
		{
			t.dict = new iTween.iTweenDictionary();
			t.dict.Set("scale", scale);
			t.dict.SetEaseType(easeType);
			t.dict.Set("time", time);
		}
		return t;
	}

    /// 放大
    public static iTweenScaleTo Extend(this GameObject go, iTween.EaseType easeType, float time)
    {
        return ScaleTo(go, new Vector3(1f, 1f, 1f), easeType, time);
    }
    public static iTweenScaleTo HorizontalExtend(this GameObject go, iTween.EaseType easeType, float time)
    {
        return ScaleTo(go, new Vector3(1f, go.transform.localScale.y, 1f), easeType, time);
    }    
    public static iTweenScaleTo VerticalExtend(this GameObject go, iTween.EaseType easeType, float time)
    {
        return ScaleTo(go, new Vector3(go.transform.localScale.x, 1f, 1f), easeType, time);
    }
        
    /// 缩小
    public static iTweenScaleTo Shrink(this GameObject go, iTween.EaseType easeType, float time)
    { 
        return ScaleTo(go, new Vector3(0f, 0f, 0f), easeType, time);
    }

    #endregion

    
    #region                                                      数  值
    public class iTweenValueTo : iTweenAct
    {
        public iTweenValueTo(GameObject go) : base (go)
        {

        }
        
        public iTweenValueTo Delay(float delay) 
        {
            dict.Set("delay", delay);
            return this;
		}
		public iTweenValueTo EaseType(iTween.EaseType easeType)
		{
			dict.SetEaseType(easeType);
			return this;
		}
        public iTweenValueTo PingPong()
        {
			dict.SetLoopType(iTween.LoopType.pingPong);
            return this;
		}
		public iTweenValueTo Loop()
		{
			dict.SetLoopType(iTween.LoopType.loop);
			return this;
		}
        public override void Start() 
        {
            // shoule be override
            iTween.ValueTo(go, dict);
        }
    }
     
	public static iTweenValueTo ValueTo(this GameObject go, float oldValue, float newValue, float time, Action<float> callback)
    {
		iTweenValueTo t = new iTweenValueTo(go);
		{
			t.dict = new iTween.iTweenDictionary();
			t.dict.Set("from", oldValue);
			t.dict.Set("to", newValue);
			t.dict.SetEaseType(iTween.EaseType.linear);
			t.dict.Set("time", time);
			t.dict.SetCb("onupdate", callback);
        }
        return t;
	}
	public static iTweenValueTo ValueToSpeed(this GameObject go, float oldValue, float newValue, float speed, Action<float> callback)
	{
		iTweenValueTo t = new iTweenValueTo(go);
		{
			t.dict = new iTween.iTweenDictionary();
			t.dict.Set("from", oldValue);
			t.dict.Set("to", newValue);
			t.dict.SetEaseType(iTween.EaseType.linear);
			t.dict.Set("time",  Math.Abs(newValue - oldValue)/speed);
			t.dict.SetCb("onupdate", callback);
		}
		return t;
	}
	public static iTweenValueTo Value0To1(this GameObject go, float time, Action<float> callback)
    {
		return go.ValueTo(0f, 1f, time, callback);
    }
	public static iTweenValueTo Value1To0(this GameObject go, float time, Action<float> callback)
    {
		return go.ValueTo(1f, 0f, time, callback);
    }
    #endregion
	
	#region                                           相机
//	public class iTweenShake : iTweenAct
//	{
//	}
//	public static void CameraFade(this GameObject go, float x, float y, float z, float time)
//	{
//		iTweenShake t = new iTweenShake(true, go);
//		{
//			t.dict = new iTween.iTweenDictionary();
//			t.dict.Set("x", x);
//			t.dict.Set("y", y);
//			t.dict.SetEaseType(iTween.EaseType.linear);
//			t.dict.Set("z", z);
//			t.dict.Set("originalPos", Vector3.zero);
//			t.dict.Set("time", time);
//		}
//		return t;
//	}

	#endregion


    #region                                           抖动

    public class iTweenShake : iTweenAct
    {
        bool byPosition = true;
        public iTweenShake(bool byPosition, GameObject go) : base(go)
        {
            this.byPosition = byPosition;
        }
        public iTweenShake Loop()
        {
			dict.SetLoopType(iTween.LoopType.loop);
            return this;
        }
        public iTweenShake PingPong()
        {
			dict.SetLoopType(iTween.LoopType.pingPong);
            return this;
        }
        public iTweenShake OriginalPos(Vector3 originalPos)
        {
            dict.Set("originalPos", originalPos);
            return this;
        }
        public iTweenShake Delay(float delay)
        {
            dict.Set("delay", delay);
            return this;
        }

        public override void Start()
        {
			if (Time.timeScale == 100) //加速状态下 不震屏
				return;

            if (byPosition)
                iTween.ShakePosition(go, dict);
            else
                iTween.ShakeRotation(go, dict);
        }
    }
    public static iTweenShake ShakePosition(this GameObject go, float x, float y, float z, float time)
    {
		iTweenShake t = new iTweenShake(true, go);
		{
			t.dict = new iTween.iTweenDictionary();
			t.dict.Set("x", x);
			t.dict.Set("y", y);
			t.dict.SetEaseType(iTween.EaseType.linear);
			t.dict.Set("z", z);
			t.dict.Set("islocal", true);
			t.dict.Set("originalPos", Vector3.zero);
			t.dict.Set("time", time);
        }
        return t;
    }
	
	public static iTweenShake ShakePosition(this GameObject go, Vector3 amount, float time)
	{
		iTweenShake t = new iTweenShake(true, go);
		{
			t.dict = new iTween.iTweenDictionary();
			t.dict.Set("amount", amount);
			t.dict.SetEaseType(iTween.EaseType.linear);
			t.dict.Set("islocal", true);
			t.dict.Set("originalPos", Vector3.zero);
			t.dict.Set("time", time);
		}
		return t;
	}

    public static iTweenShake ShakeRotationZ(GameObject go, float z, float time)
    {
		iTweenShake t = new iTweenShake(false, go);
		{
			t.dict = new iTween.iTweenDictionary();
			t.dict.Set("z", z);
			t.dict.Set("time", time);
			t.dict.SetEaseType(iTween.EaseType.linear);
        }
        return t;
    }
    #endregion


    #region 结束 暂停 继续动画
    public static void PauseTween(this GameObject go)
    {
        iTween.Pause(go);
    }
    public static void ResumeTween(this GameObject go)
    {
        iTween.Resume(go);
    }
    public static void StopTween(this GameObject go)
    {
        iTween.Stop(go);
    }
    public static void StopTween(this GameObject go, string type)
    {
        iTween.Stop(go, type);
    }
    public static void StopByName(string name)
    {
        iTween.StopByName(name);
    }
    
    public static bool HasTween(this GameObject go)
    {
        return iTweenRoot.HasiTweens(go);
    }

    #endregion


    #region                                                      回  调
    ///延时回调
    public static void CallBackLater(this GameObject go, float time, Action callback)
	{
		var dict = new iTween.iTweenDictionary();
		dict.Set("time", time);
		dict.SetCb("onComplete", callback);
        iTween.CallBackLater(go, dict);
    }
    public static void CallBackLater(this GameObject go, float time, Action<object> callback, object param)
	{
		var dict = new iTween.iTweenDictionary();
		dict.Set("time", time);
		dict.SetCb("onComplete", callback);
		dict.Set("onCompleteParams", param);
		iTween.CallBackLater(go, dict);
    }
    #endregion

    
    #region                                                 平 面 坐 标 转 换
    ///将上角坐标转换成右上角坐标
    public static Vector3 TopToTopRight(Vector3 point)
    {
        return new Vector3(point.x - (Screen.width/2)/GetScale(), point.y);
    }
    ///将上角坐标转换成左下角坐标
    public static Vector3 TopToBottomLeft(Vector3 point)
    {
        return new Vector3(point.x + (Screen.width/2)/GetScale(), point.y + Screen.height/GetScale());
    }
    ///将左上角坐标转换成下角坐标
    public static Vector3 TopLeftToBottom(Vector3 point)
    {
        return new Vector3(point.x - (Screen.width/2)/GetScale(), point.y + Screen.height/GetScale());
    }
    #endregion

        
    #region                                                 三 维 坐 标 转 换
    /// 将世界坐标转换为屏幕左下角坐标
    public static Vector3 WorldToLeftBottom(Vector3 position, Camera camera)
    {
        Vector3 point = camera.WorldToScreenPoint(position);
        return new Vector3(point.x, point.y)/GetScale();
    }
    /// 将世界坐标转换为屏幕中心坐标
    public static Vector3 WorldToCenter(Vector3 position, Camera camera)
    {
        Vector3 point = camera.WorldToScreenPoint(position);
        return new Vector3(point.x - Screen.width/2, point.y - Screen.height/2)/GetScale();
    }
    /// 将世界坐标转换为屏幕上角坐标
    public static Vector3 WorldToTop(Vector3 position, Camera camera)
    {
        Vector3 point = camera.WorldToScreenPoint(position);
        return new Vector3(point.x - Screen.width/2, point.y - Screen.height)/GetScale();
    }
    /// 将世界坐标转换为屏幕右上角坐标
    public static Vector3 WorldToRightTop(Vector3 position, Camera camera)
    {
        Vector3 point = camera.WorldToScreenPoint(position);
        return new Vector3(point.x - Screen.width, point.y - Screen.height)/GetScale();
    }
    /// 将世界坐标转换为屏幕右下角坐标
    public static Vector3 WorldToRightBottom(Vector3 position, Camera camera)
    {
        Vector3 point = camera.WorldToScreenPoint(position);
        return new Vector3(point.x - Screen.width, point.y)/GetScale();
    }

    /// 屏幕下方坐标到世界坐标
    public static Vector3 BottomToWorld(Vector3 point, Camera camera)
    {
        point.x *= GetScale();
        point.y *= GetScale();
        point += new Vector3(Screen.width/2, 0);
        Vector3 position = camera.ScreenToWorldPoint(point);
        return position;
    }
    /// 屏幕左上坐标到世界坐标
    public static Vector3 LeftTopToWorld(Vector3 point, Camera camera)
    {
        point.x *= GetScale();
        point.y *= GetScale();
        point += new Vector3(0, Screen.height);
        Vector3 position = camera.ScreenToWorldPoint(point);
        return position;
    }
    /// 屏幕左坐标到世界坐标
    public static Vector3 LeftToWorld(Vector3 point, Camera camera)
    {
        point.x *= GetScale();
        point.y *= GetScale();
        point += new Vector3(0, 0);
        Vector3 position = camera.ScreenToWorldPoint(point);
        return position;
    } 
    /// 屏幕中心坐标到世界坐标
    public static Vector3 CenterToWorld(Vector3 point, Camera camera)
    {
        point.x *= GetScale();
        point.y *= GetScale();
        point += new Vector3(Screen.width/2, Screen.height/2);
        Vector3 position = camera.ScreenToWorldPoint(point);
        return position;
    }
    /// 屏幕左下坐标到世界坐标
    public static Vector3 LeftBottomToWorld(Vector3 point, Camera camera)
    {
        point.x *= GetScale();
        point.y *= GetScale();
        Vector3 position = camera.ScreenToWorldPoint(point);
        return position;
    }
    /// 屏幕右下方坐标到世界坐标
    public static Vector3 RightTopToWorld(Vector3 point, Camera camera)
    {
        point.x *= GetScale();
        point.y *= GetScale();
        point += new Vector3(Screen.width, Screen.height);
        Vector3 position = camera.ScreenToWorldPoint(point);
        return position;
    }
    /// 屏幕右坐标到世界坐标
    public static Vector3 RightToWorld(Vector3 point, Camera camera)
    {
        point.x *= GetScale();
        point.y *= GetScale();
        point += new Vector3(Screen.width, 0);
        Vector3 position = camera.ScreenToWorldPoint(point);
        return position;
    }
    #endregion

    
    #region                                                  路 径 处 理
    ///复制路径
    public static Transform[] CreatePath(int length, Transform parent)
    {
        Transform[] path = new Transform[length];
        GameObject child = CreateEmpty("path", parent);
        for(int index = 0; index < length; index++)
        {
            GameObject point = CreateEmpty("point" + index, child.transform);
            path[index] = point.transform;
        }
        return path;
    }
    ///摧毁路径
    public static void DestroyPath(Transform[] path)
    {
        UnityEngine.Object.Destroy(path[0].transform.parent.gameObject);
        path = null;
    }
    ///创造空对象
    private static GameObject CreateEmpty(string name, Transform parent)
    {
        GameObject go = new GameObject(name);
        go.transform.parent = parent;
        go.transform.localPosition = Vector3.zero;
        go.transform.localScale = Vector3.one;
        return go;
    }
    #endregion

    
    #region                                                 界 面 缩 放 比
    ///界面缩放比
    public static float GetScale()
    {
        if(scale == 0)
        {
            scale = 1;
        }
        return scale;
    }
    #endregion
}
