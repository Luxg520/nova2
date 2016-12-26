
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine.EventSystems;
using jsval = JSApi.jsval;
public class UnityEngine_EventSystems_IDeselectHandler_G
{
    ////////////////////// IDeselectHandler ///////////////////////////////////////
    // constructors
    // fields
    // properties
    // methods
    static bool IDeselectHandler_OnDeselect__BaseEventData(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.EventSystems.IDeselectHandler)vc.csObj).OnDeselect(arg0);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.EventSystems.IDeselectHandler);
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
            new JSMgr.MethodCallBackInfo(IDeselectHandler_OnDeselect__BaseEventData, "OnDeselect"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}