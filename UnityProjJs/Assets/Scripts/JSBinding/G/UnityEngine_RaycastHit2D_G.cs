
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_RaycastHit2D_G
{
    ////////////////////// RaycastHit2D ///////////////////////////////////////
    // constructors
    public static ConstructorID constructorID0 = new ConstructorID(null, null);
     
    static bool RaycastHit2D_RaycastHit2D(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.RaycastHit2D());
        }
        return true;
    }
    // fields
    // properties
    static void RaycastHit2D_centroid(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.RaycastHit2D _this = (UnityEngine.RaycastHit2D)vc.csObj;
            var result = _this.centroid;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D _this = (UnityEngine.RaycastHit2D)vc.csObj;
            _this.centroid = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void RaycastHit2D_collider(JSVCall vc)
    {
        UnityEngine.RaycastHit2D _this = (UnityEngine.RaycastHit2D)vc.csObj;
        var result = _this.collider;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void RaycastHit2D_distance(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.RaycastHit2D _this = (UnityEngine.RaycastHit2D)vc.csObj;
            var result = _this.distance;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D _this = (UnityEngine.RaycastHit2D)vc.csObj;
            _this.distance = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void RaycastHit2D_fraction(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.RaycastHit2D _this = (UnityEngine.RaycastHit2D)vc.csObj;
            var result = _this.fraction;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D _this = (UnityEngine.RaycastHit2D)vc.csObj;
            _this.fraction = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void RaycastHit2D_normal(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.RaycastHit2D _this = (UnityEngine.RaycastHit2D)vc.csObj;
            var result = _this.normal;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D _this = (UnityEngine.RaycastHit2D)vc.csObj;
            _this.normal = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void RaycastHit2D_point(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.RaycastHit2D _this = (UnityEngine.RaycastHit2D)vc.csObj;
            var result = _this.point;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D _this = (UnityEngine.RaycastHit2D)vc.csObj;
            _this.point = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void RaycastHit2D_rigidbody(JSVCall vc)
    {
        UnityEngine.RaycastHit2D _this = (UnityEngine.RaycastHit2D)vc.csObj;
        var result = _this.rigidbody;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void RaycastHit2D_transform(JSVCall vc)
    {
        UnityEngine.RaycastHit2D _this = (UnityEngine.RaycastHit2D)vc.csObj;
        var result = _this.transform;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    // methods
    static bool RaycastHit2D_CompareTo__RaycastHit2D(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.RaycastHit2D arg0 = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D argThis = (UnityEngine.RaycastHit2D)vc.csObj;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(argThis.CompareTo(arg0)));
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool RaycastHit2D_op_Implicit__RaycastHit2D_to_Boolean(JSVCall vc, int argc)
    {
        UnityEngine.RaycastHit2D arg0 = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)((bool)arg0));
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.RaycastHit2D);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            RaycastHit2D_centroid,
            RaycastHit2D_collider,
            RaycastHit2D_distance,
            RaycastHit2D_fraction,
            RaycastHit2D_normal,
            RaycastHit2D_point,
            RaycastHit2D_rigidbody,
            RaycastHit2D_transform,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(RaycastHit2D_RaycastHit2D, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(RaycastHit2D_CompareTo__RaycastHit2D, "CompareTo"),
            new JSMgr.MethodCallBackInfo(RaycastHit2D_op_Implicit__RaycastHit2D_to_Boolean, "op_Implicit"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}