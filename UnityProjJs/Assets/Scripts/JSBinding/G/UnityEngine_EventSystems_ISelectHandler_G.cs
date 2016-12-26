
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine.EventSystems;
using jsval = JSApi.jsval;
public class UnityEngine_EventSystems_ISelectHandler_G
{
    ////////////////////// ISelectHandler ///////////////////////////////////////
    // constructors
    // fields
    // properties
    // methods
    static bool ISelectHandler_OnSelect__BaseEventData(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.EventSystems.ISelectHandler)vc.csObj).OnSelect(arg0);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.EventSystems.ISelectHandler);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(ISelectHandler_OnSelect__BaseEventData, "OnSelect"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}