
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine.UI;
using jsval = JSApi.jsval;
public class UnityEngine_UI_IMaskable_G
{
    ////////////////////// IMaskable ///////////////////////////////////////
    // constructors
    // fields
    // properties
    // methods
    static bool IMaskable_ParentMaskStateChanged(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.IMaskable)vc.csObj).ParentMaskStateChanged();
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.UI.IMaskable);
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
            new JSMgr.MethodCallBackInfo(IMaskable_ParentMaskStateChanged, "ParentMaskStateChanged"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}