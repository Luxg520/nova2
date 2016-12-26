
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_SphereCollider_G
{
    ////////////////////// SphereCollider ///////////////////////////////////////
    // constructors
    static bool SphereCollider_SphereCollider(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.SphereCollider());
        }
        return true;
    }
    // fields
    // properties
    static void SphereCollider_center(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.SphereCollider _this = (UnityEngine.SphereCollider)vc.csObj;
            var result = _this.center;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.SphereCollider _this = (UnityEngine.SphereCollider)vc.csObj;
            _this.center = arg0;
        }
    }
    static void SphereCollider_radius(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.SphereCollider _this = (UnityEngine.SphereCollider)vc.csObj;
            var result = _this.radius;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.SphereCollider _this = (UnityEngine.SphereCollider)vc.csObj;
            _this.radius = arg0;
        }
    }
    // methods
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.SphereCollider);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            SphereCollider_center,
            SphereCollider_radius,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(SphereCollider_SphereCollider, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}