
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine.EventSystems;
using jsval = JSApi.jsval;
public class UnityEngine_EventSystems_IMoveHandler_G
{
    ////////////////////// IMoveHandler ///////////////////////////////////////
    // constructors
    // fields
    // properties
    // methods
    static bool IMoveHandler_OnMove__AxisEventData(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.EventSystems.AxisEventData arg0 = (UnityEngine.EventSystems.AxisEventData)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.EventSystems.IMoveHandler)vc.csObj).OnMove(arg0);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.EventSystems.IMoveHandler);
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
            new JSMgr.MethodCallBackInfo(IMoveHandler_OnMove__AxisEventData, "OnMove"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}