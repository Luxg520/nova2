
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_RaycastHit_G
{
    ////////////////////// RaycastHit ///////////////////////////////////////
    // constructors
    public static ConstructorID constructorID0 = new ConstructorID(null, null);
     
    static bool RaycastHit_RaycastHit(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.RaycastHit());
        }
        return true;
    }
    // fields
    // properties
    static void RaycastHit_barycentricCoordinate(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.RaycastHit _this = (UnityEngine.RaycastHit)vc.csObj;
            var result = _this.barycentricCoordinate;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit _this = (UnityEngine.RaycastHit)vc.csObj;
            _this.barycentricCoordinate = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void RaycastHit_collider(JSVCall vc)
    {
        UnityEngine.RaycastHit _this = (UnityEngine.RaycastHit)vc.csObj;
        var result = _this.collider;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void RaycastHit_distance(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.RaycastHit _this = (UnityEngine.RaycastHit)vc.csObj;
            var result = _this.distance;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit _this = (UnityEngine.RaycastHit)vc.csObj;
            _this.distance = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void RaycastHit_lightmapCoord(JSVCall vc)
    {
        UnityEngine.RaycastHit _this = (UnityEngine.RaycastHit)vc.csObj;
        var result = _this.lightmapCoord;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void RaycastHit_normal(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.RaycastHit _this = (UnityEngine.RaycastHit)vc.csObj;
            var result = _this.normal;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit _this = (UnityEngine.RaycastHit)vc.csObj;
            _this.normal = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void RaycastHit_point(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.RaycastHit _this = (UnityEngine.RaycastHit)vc.csObj;
            var result = _this.point;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit _this = (UnityEngine.RaycastHit)vc.csObj;
            _this.point = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void RaycastHit_rigidbody(JSVCall vc)
    {
        UnityEngine.RaycastHit _this = (UnityEngine.RaycastHit)vc.csObj;
        var result = _this.rigidbody;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void RaycastHit_textureCoord(JSVCall vc)
    {
        UnityEngine.RaycastHit _this = (UnityEngine.RaycastHit)vc.csObj;
        var result = _this.textureCoord;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void RaycastHit_textureCoord2(JSVCall vc)
    {
        UnityEngine.RaycastHit _this = (UnityEngine.RaycastHit)vc.csObj;
        var result = _this.textureCoord2;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void RaycastHit_transform(JSVCall vc)
    {
        UnityEngine.RaycastHit _this = (UnityEngine.RaycastHit)vc.csObj;
        var result = _this.transform;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void RaycastHit_triangleIndex(JSVCall vc)
    {
        UnityEngine.RaycastHit _this = (UnityEngine.RaycastHit)vc.csObj;
        var result = _this.triangleIndex;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    // methods
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.RaycastHit);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            RaycastHit_barycentricCoordinate,
            RaycastHit_collider,
            RaycastHit_distance,
            RaycastHit_lightmapCoord,
            RaycastHit_normal,
            RaycastHit_point,
            RaycastHit_rigidbody,
            RaycastHit_textureCoord,
            RaycastHit_textureCoord2,
            RaycastHit_transform,
            RaycastHit_triangleIndex,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(RaycastHit_RaycastHit, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}