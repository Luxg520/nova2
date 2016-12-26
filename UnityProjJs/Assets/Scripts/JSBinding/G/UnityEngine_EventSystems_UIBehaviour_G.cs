
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine.EventSystems;
using jsval = JSApi.jsval;
public class UnityEngine_EventSystems_UIBehaviour_G
{
    ////////////////////// UIBehaviour ///////////////////////////////////////
    // constructors
    // fields
    // properties
    // methods
    static bool UIBehaviour_IsActive(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.EventSystems.UIBehaviour)vc.csObj).IsActive()));
        }
        return true;
    }
    static bool UIBehaviour_IsDestroyed(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.EventSystems.UIBehaviour)vc.csObj).IsDestroyed()));
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.EventSystems.UIBehaviour);
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
            new JSMgr.MethodCallBackInfo(UIBehaviour_IsActive, "IsActive"),
            new JSMgr.MethodCallBackInfo(UIBehaviour_IsDestroyed, "IsDestroyed"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}