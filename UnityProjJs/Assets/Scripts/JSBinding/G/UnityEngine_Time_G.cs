
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Time_G
{
    ////////////////////// Time ///////////////////////////////////////
    // constructors
    static bool Time_Time(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Time());
        }
        return true;
    }
    // fields
    // properties
    static void Time_captureFramerate(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Time.captureFramerate;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Time.captureFramerate = arg0;
        }
    }
    static void Time_deltaTime(JSVCall vc)
    {
        var result = UnityEngine.Time.deltaTime;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Time_fixedDeltaTime(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Time.fixedDeltaTime;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Time.fixedDeltaTime = arg0;
        }
    }
    static void Time_fixedTime(JSVCall vc)
    {
        var result = UnityEngine.Time.fixedTime;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Time_frameCount(JSVCall vc)
    {
        var result = UnityEngine.Time.frameCount;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Time_maximumDeltaTime(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Time.maximumDeltaTime;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Time.maximumDeltaTime = arg0;
        }
    }
    static void Time_realtimeSinceStartup(JSVCall vc)
    {
        var result = UnityEngine.Time.realtimeSinceStartup;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Time_renderedFrameCount(JSVCall vc)
    {
        var result = UnityEngine.Time.renderedFrameCount;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Time_smoothDeltaTime(JSVCall vc)
    {
        var result = UnityEngine.Time.smoothDeltaTime;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Time_time(JSVCall vc)
    {
        var result = UnityEngine.Time.time;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Time_timeScale(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Time.timeScale;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Time.timeScale = arg0;
        }
    }
    static void Time_timeSinceLevelLoad(JSVCall vc)
    {
        var result = UnityEngine.Time.timeSinceLevelLoad;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Time_unscaledDeltaTime(JSVCall vc)
    {
        var result = UnityEngine.Time.unscaledDeltaTime;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Time_unscaledTime(JSVCall vc)
    {
        var result = UnityEngine.Time.unscaledTime;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    // methods
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Time);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Time_captureFramerate,
            Time_deltaTime,
            Time_fixedDeltaTime,
            Time_fixedTime,
            Time_frameCount,
            Time_maximumDeltaTime,
            Time_realtimeSinceStartup,
            Time_renderedFrameCount,
            Time_smoothDeltaTime,
            Time_time,
            Time_timeScale,
            Time_timeSinceLevelLoad,
            Time_unscaledDeltaTime,
            Time_unscaledTime,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Time_Time, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}