
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine.EventSystems;
using jsval = JSApi.jsval;
public class UnityEngine_EventSystems_IPointerExitHandler_G
{
    ////////////////////// IPointerExitHandler ///////////////////////////////////////
    // constructors
    // fields
    // properties
    // methods
    static bool IPointerExitHandler_OnPointerExit__PointerEventData(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.EventSystems.IPointerExitHandler)vc.csObj).OnPointerExit(arg0);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.EventSystems.IPointerExitHandler);
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
            new JSMgr.MethodCallBackInfo(IPointerExitHandler_OnPointerExit__PointerEventData, "OnPointerExit"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}