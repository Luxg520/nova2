
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Collider_G
{
    ////////////////////// Collider ///////////////////////////////////////
    // constructors
    static bool Collider_Collider(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Collider());
        }
        return true;
    }
    // fields
    // properties
    static void Collider_attachedRigidbody(JSVCall vc)
    {
        UnityEngine.Collider _this = (UnityEngine.Collider)vc.csObj;
        var result = _this.attachedRigidbody;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Collider_bounds(JSVCall vc)
    {
        UnityEngine.Collider _this = (UnityEngine.Collider)vc.csObj;
        var result = _this.bounds;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Collider_contactOffset(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Collider _this = (UnityEngine.Collider)vc.csObj;
            var result = _this.contactOffset;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Collider _this = (UnityEngine.Collider)vc.csObj;
            _this.contactOffset = arg0;
        }
    }
    static void Collider_enabled(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Collider _this = (UnityEngine.Collider)vc.csObj;
            var result = _this.enabled;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Collider _this = (UnityEngine.Collider)vc.csObj;
            _this.enabled = arg0;
        }
    }
    static void Collider_isTrigger(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Collider _this = (UnityEngine.Collider)vc.csObj;
            var result = _this.isTrigger;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Collider _this = (UnityEngine.Collider)vc.csObj;
            _this.isTrigger = arg0;
        }
    }
    static void Collider_material(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Collider _this = (UnityEngine.Collider)vc.csObj;
            var result = _this.material;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.PhysicMaterial arg0 = (UnityEngine.PhysicMaterial)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider _this = (UnityEngine.Collider)vc.csObj;
            _this.material = arg0;
        }
    }
    static void Collider_sharedMaterial(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Collider _this = (UnityEngine.Collider)vc.csObj;
            var result = _this.sharedMaterial;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.PhysicMaterial arg0 = (UnityEngine.PhysicMaterial)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider _this = (UnityEngine.Collider)vc.csObj;
            _this.sharedMaterial = arg0;
        }
    }
    // methods
    static bool Collider_ClosestPointOnBounds__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Collider)vc.csObj).ClosestPointOnBounds(arg0));
        }
        return true;
    }
    static bool Collider_Raycast__Ray__RaycastHit__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg1 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg1;
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Collider)vc.csObj).Raycast(arg0, out arg1, arg2)));
            JSApi.setArgIndex(r_arg1);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg1);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Collider);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Collider_attachedRigidbody,
            Collider_bounds,
            Collider_contactOffset,
            Collider_enabled,
            Collider_isTrigger,
            Collider_material,
            Collider_sharedMaterial,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Collider_Collider, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Collider_ClosestPointOnBounds__Vector3, "ClosestPointOnBounds"),
            new JSMgr.MethodCallBackInfo(Collider_Raycast__Ray__RaycastHit__Single, "Raycast"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}