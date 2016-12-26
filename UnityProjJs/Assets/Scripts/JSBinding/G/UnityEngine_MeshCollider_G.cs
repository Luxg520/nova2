﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_MeshCollider_G
{
    ////////////////////// MeshCollider ///////////////////////////////////////
    // constructors
    static bool MeshCollider_MeshCollider(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.MeshCollider());
        }
        return true;
    }
    // fields
    // properties
    static void MeshCollider_convex(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.MeshCollider _this = (UnityEngine.MeshCollider)vc.csObj;
            var result = _this.convex;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.MeshCollider _this = (UnityEngine.MeshCollider)vc.csObj;
            _this.convex = arg0;
        }
    }
    static void MeshCollider_sharedMesh(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.MeshCollider _this = (UnityEngine.MeshCollider)vc.csObj;
            var result = _this.sharedMesh;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Mesh arg0 = (UnityEngine.Mesh)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.MeshCollider _this = (UnityEngine.MeshCollider)vc.csObj;
            _this.sharedMesh = arg0;
        }
    }
    // methods
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.MeshCollider);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            MeshCollider_convex,
            MeshCollider_sharedMesh,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(MeshCollider_MeshCollider, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}