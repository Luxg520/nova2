﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_CircleCollider2D_G
{
    ////////////////////// CircleCollider2D ///////////////////////////////////////
    // constructors
    static bool CircleCollider2D_CircleCollider2D(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.CircleCollider2D());
        }
        return true;
    }
    // fields
    // properties
    static void CircleCollider2D_center(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.CircleCollider2D _this = (UnityEngine.CircleCollider2D)vc.csObj;
            var result = _this.center;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.CircleCollider2D _this = (UnityEngine.CircleCollider2D)vc.csObj;
            _this.center = arg0;
        }
    }
    static void CircleCollider2D_radius(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.CircleCollider2D _this = (UnityEngine.CircleCollider2D)vc.csObj;
            var result = _this.radius;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.CircleCollider2D _this = (UnityEngine.CircleCollider2D)vc.csObj;
            _this.radius = arg0;
        }
    }
    // methods
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.CircleCollider2D);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            CircleCollider2D_center,
            CircleCollider2D_radius,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(CircleCollider2D_CircleCollider2D, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}