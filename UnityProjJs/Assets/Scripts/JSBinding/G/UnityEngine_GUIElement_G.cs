﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_GUIElement_G
{
    ////////////////////// GUIElement ///////////////////////////////////////
    // constructors
    static bool GUIElement_GUIElement(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.GUIElement());
        }
        return true;
    }
    // fields
    // properties
    // methods
    static bool GUIElement_GetScreenRect(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.GUIElement)vc.csObj).GetScreenRect());
        }
        return true;
    }
    static bool GUIElement_GetScreenRect__Camera(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Camera arg0 = (UnityEngine.Camera)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.GUIElement)vc.csObj).GetScreenRect(arg0));
        }
        return true;
    }
    static bool GUIElement_HitTest__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.GUIElement)vc.csObj).HitTest(arg0)));
        }
        return true;
    }
    static bool GUIElement_HitTest__Vector3__Camera(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Camera arg1 = (UnityEngine.Camera)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.GUIElement)vc.csObj).HitTest(arg0, arg1)));
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.GUIElement);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(GUIElement_GUIElement, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(GUIElement_GetScreenRect, "GetScreenRect"),
            new JSMgr.MethodCallBackInfo(GUIElement_GetScreenRect__Camera, "GetScreenRect"),
            new JSMgr.MethodCallBackInfo(GUIElement_HitTest__Vector3, "HitTest"),
            new JSMgr.MethodCallBackInfo(GUIElement_HitTest__Vector3__Camera, "HitTest"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}