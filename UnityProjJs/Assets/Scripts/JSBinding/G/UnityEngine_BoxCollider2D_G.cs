
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_BoxCollider2D_G
{
    ////////////////////// BoxCollider2D ///////////////////////////////////////
    // constructors
    static bool BoxCollider2D_BoxCollider2D(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.BoxCollider2D());
        }
        return true;
    }
    // fields
    // properties
    static void BoxCollider2D_center(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.BoxCollider2D _this = (UnityEngine.BoxCollider2D)vc.csObj;
            var result = _this.center;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.BoxCollider2D _this = (UnityEngine.BoxCollider2D)vc.csObj;
            _this.center = arg0;
        }
    }
    static void BoxCollider2D_size(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.BoxCollider2D _this = (UnityEngine.BoxCollider2D)vc.csObj;
            var result = _this.size;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.BoxCollider2D _this = (UnityEngine.BoxCollider2D)vc.csObj;
            _this.size = arg0;
        }
    }
    // methods
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.BoxCollider2D);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            BoxCollider2D_center,
            BoxCollider2D_size,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(BoxCollider2D_BoxCollider2D, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}