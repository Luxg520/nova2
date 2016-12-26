
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_BoxCollider_G
{
    ////////////////////// BoxCollider ///////////////////////////////////////
    // constructors
    static bool BoxCollider_BoxCollider(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.BoxCollider());
        }
        return true;
    }
    // fields
    // properties
    static void BoxCollider_center(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.BoxCollider _this = (UnityEngine.BoxCollider)vc.csObj;
            var result = _this.center;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.BoxCollider _this = (UnityEngine.BoxCollider)vc.csObj;
            _this.center = arg0;
        }
    }
    static void BoxCollider_size(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.BoxCollider _this = (UnityEngine.BoxCollider)vc.csObj;
            var result = _this.size;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.BoxCollider _this = (UnityEngine.BoxCollider)vc.csObj;
            _this.size = arg0;
        }
    }
    // methods
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.BoxCollider);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            BoxCollider_center,
            BoxCollider_size,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(BoxCollider_BoxCollider, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}