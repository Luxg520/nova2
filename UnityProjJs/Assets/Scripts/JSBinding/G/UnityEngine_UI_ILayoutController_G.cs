
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine.UI;
using jsval = JSApi.jsval;
public class UnityEngine_UI_ILayoutController_G
{
    ////////////////////// ILayoutController ///////////////////////////////////////
    // constructors
    // fields
    // properties
    // methods
    static bool ILayoutController_SetLayoutHorizontal(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.ILayoutController)vc.csObj).SetLayoutHorizontal();
        }
        return true;
    }
    static bool ILayoutController_SetLayoutVertical(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.ILayoutController)vc.csObj).SetLayoutVertical();
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.UI.ILayoutController);
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
            new JSMgr.MethodCallBackInfo(ILayoutController_SetLayoutHorizontal, "SetLayoutHorizontal"),
            new JSMgr.MethodCallBackInfo(ILayoutController_SetLayoutVertical, "SetLayoutVertical"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}