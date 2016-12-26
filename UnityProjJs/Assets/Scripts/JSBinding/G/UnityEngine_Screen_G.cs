﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Screen_G
{
    ////////////////////// Screen ///////////////////////////////////////
    // constructors
    static bool Screen_Screen(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Screen());
        }
        return true;
    }
    // fields
    // properties
    static void Screen_autorotateToLandscapeLeft(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Screen.autorotateToLandscapeLeft;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Screen.autorotateToLandscapeLeft = arg0;
        }
    }
    static void Screen_autorotateToLandscapeRight(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Screen.autorotateToLandscapeRight;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Screen.autorotateToLandscapeRight = arg0;
        }
    }
    static void Screen_autorotateToPortrait(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Screen.autorotateToPortrait;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Screen.autorotateToPortrait = arg0;
        }
    }
    static void Screen_autorotateToPortraitUpsideDown(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Screen.autorotateToPortraitUpsideDown;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Screen.autorotateToPortraitUpsideDown = arg0;
        }
    }
    static void Screen_currentResolution(JSVCall vc)
    {
        var result = UnityEngine.Screen.currentResolution;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Screen_dpi(JSVCall vc)
    {
        var result = UnityEngine.Screen.dpi;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Screen_fullScreen(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Screen.fullScreen;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Screen.fullScreen = arg0;
        }
    }
    static void Screen_height(JSVCall vc)
    {
        var result = UnityEngine.Screen.height;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Screen_orientation(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Screen.orientation;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.ScreenOrientation arg0 = (UnityEngine.ScreenOrientation)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Screen.orientation = arg0;
        }
    }
    static void Screen_resolutions(JSVCall vc)
    {
        var result = UnityEngine.Screen.resolutions;
            var arrRet = (UnityEngine.Resolution[])result;
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }
    static void Screen_sleepTimeout(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Screen.sleepTimeout;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Screen.sleepTimeout = arg0;
        }
    }
    static void Screen_width(JSVCall vc)
    {
        var result = UnityEngine.Screen.width;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    // methods
    static bool Screen_SetResolution__Int32__Int32__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            bool arg2 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Screen.SetResolution(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Screen_SetResolution__Int32__Int32__Boolean__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            bool arg2 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Screen.SetResolution(arg0, arg1, arg2, arg3);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Screen);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Screen_autorotateToLandscapeLeft,
            Screen_autorotateToLandscapeRight,
            Screen_autorotateToPortrait,
            Screen_autorotateToPortraitUpsideDown,
            Screen_currentResolution,
            Screen_dpi,
            Screen_fullScreen,
            Screen_height,
            Screen_orientation,
            Screen_resolutions,
            Screen_sleepTimeout,
            Screen_width,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Screen_Screen, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Screen_SetResolution__Int32__Int32__Boolean, "SetResolution"),
            new JSMgr.MethodCallBackInfo(Screen_SetResolution__Int32__Int32__Boolean__Int32, "SetResolution"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}