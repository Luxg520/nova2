
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine.UI;
using jsval = JSApi.jsval;
public class UnityEngine_UI_ICanvasElement_G
{
    ////////////////////// ICanvasElement ///////////////////////////////////////
    // constructors
    // fields
    // properties
    static void ICanvasElement_transform(JSVCall vc)
    {
        UnityEngine.UI.ICanvasElement _this = (UnityEngine.UI.ICanvasElement)vc.csObj;
        var result = _this.transform;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    // methods
    static bool ICanvasElement_IsDestroyed(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.UI.ICanvasElement)vc.csObj).IsDestroyed()));
        }
        return true;
    }
    static bool ICanvasElement_Rebuild__CanvasUpdate(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.UI.CanvasUpdate arg0 = (UnityEngine.UI.CanvasUpdate)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.UI.ICanvasElement)vc.csObj).Rebuild(arg0);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.UI.ICanvasElement);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            ICanvasElement_transform,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(ICanvasElement_IsDestroyed, "IsDestroyed"),
            new JSMgr.MethodCallBackInfo(ICanvasElement_Rebuild__CanvasUpdate, "Rebuild"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}