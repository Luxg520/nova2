
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Behaviour_G
{
    ////////////////////// Behaviour ///////////////////////////////////////
    // constructors
    static bool Behaviour_Behaviour(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Behaviour());
        }
        return true;
    }
    // fields
    // properties
    static void Behaviour_enabled(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Behaviour _this = (UnityEngine.Behaviour)vc.csObj;
            var result = _this.enabled;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Behaviour _this = (UnityEngine.Behaviour)vc.csObj;
            _this.enabled = arg0;
        }
    }
    static void Behaviour_isActiveAndEnabled(JSVCall vc)
    {
        UnityEngine.Behaviour _this = (UnityEngine.Behaviour)vc.csObj;
        var result = _this.isActiveAndEnabled;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    // methods
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Behaviour);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Behaviour_enabled,
            Behaviour_isActiveAndEnabled,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Behaviour_Behaviour, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}