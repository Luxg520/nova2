﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Collider2D_G
{
    ////////////////////// Collider2D ///////////////////////////////////////
    // constructors
    static bool Collider2D_Collider2D(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Collider2D());
        }
        return true;
    }
    // fields
    // properties
    static void Collider2D_attachedRigidbody(JSVCall vc)
    {
        UnityEngine.Collider2D _this = (UnityEngine.Collider2D)vc.csObj;
        var result = _this.attachedRigidbody;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Collider2D_bounds(JSVCall vc)
    {
        UnityEngine.Collider2D _this = (UnityEngine.Collider2D)vc.csObj;
        var result = _this.bounds;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Collider2D_isTrigger(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Collider2D _this = (UnityEngine.Collider2D)vc.csObj;
            var result = _this.isTrigger;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D _this = (UnityEngine.Collider2D)vc.csObj;
            _this.isTrigger = arg0;
        }
    }
    static void Collider2D_shapeCount(JSVCall vc)
    {
        UnityEngine.Collider2D _this = (UnityEngine.Collider2D)vc.csObj;
        var result = _this.shapeCount;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Collider2D_sharedMaterial(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Collider2D _this = (UnityEngine.Collider2D)vc.csObj;
            var result = _this.sharedMaterial;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.PhysicsMaterial2D arg0 = (UnityEngine.PhysicsMaterial2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D _this = (UnityEngine.Collider2D)vc.csObj;
            _this.sharedMaterial = arg0;
        }
    }
    // methods
    static bool Collider2D_OverlapPoint__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Collider2D)vc.csObj).OverlapPoint(arg0)));
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Collider2D);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Collider2D_attachedRigidbody,
            Collider2D_bounds,
            Collider2D_isTrigger,
            Collider2D_shapeCount,
            Collider2D_sharedMaterial,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Collider2D_Collider2D, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Collider2D_OverlapPoint__Vector2, "OverlapPoint"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}