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
    static void Collider2D_density(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Collider2D _this = (UnityEngine.Collider2D)vc.csObj;
            var result = _this.density;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D _this = (UnityEngine.Collider2D)vc.csObj;
            _this.density = arg0;
        }
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
    static void Collider2D_offset(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Collider2D _this = (UnityEngine.Collider2D)vc.csObj;
            var result = _this.offset;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D _this = (UnityEngine.Collider2D)vc.csObj;
            _this.offset = arg0;
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
    static void Collider2D_usedByEffector(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Collider2D _this = (UnityEngine.Collider2D)vc.csObj;
            var result = _this.usedByEffector;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D _this = (UnityEngine.Collider2D)vc.csObj;
            _this.usedByEffector = arg0;
        }
    }
    // methods
    static bool Collider2D_Cast__Vector2__RaycastHit2D_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg1 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.Collider2D)vc.csObj).Cast(arg0, arg1)));
        }
        return true;
    }
    static bool Collider2D_Cast__Vector2__RaycastHit2D_Array__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg1 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.Collider2D)vc.csObj).Cast(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Collider2D_Cast__Vector2__RaycastHit2D_Array__Single__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg1 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            bool arg3 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.Collider2D)vc.csObj).Cast(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Collider2D_IsTouching__Collider2D(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Collider2D arg0 = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Collider2D)vc.csObj).IsTouching(arg0)));
        }
        return true;
    }
    static bool Collider2D_IsTouchingLayers(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Collider2D)vc.csObj).IsTouchingLayers()));
        }
        return true;
    }
    static bool Collider2D_IsTouchingLayers__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Collider2D)vc.csObj).IsTouchingLayers(arg0)));
        }
        return true;
    }
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
    static bool Collider2D_Raycast__Vector2__RaycastHit2D_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg1 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.Collider2D)vc.csObj).Raycast(arg0, arg1)));
        }
        return true;
    }
    static bool Collider2D_Raycast__Vector2__RaycastHit2D_Array__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg1 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.Collider2D)vc.csObj).Raycast(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Collider2D_Raycast__Vector2__RaycastHit2D_Array__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg1 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.Collider2D)vc.csObj).Raycast(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Collider2D_Raycast__Vector2__RaycastHit2D_Array__Single__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg1 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.Collider2D)vc.csObj).Raycast(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Collider2D_Raycast__Vector2__RaycastHit2D_Array__Single__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg1 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.Collider2D)vc.csObj).Raycast(arg0, arg1, arg2, arg3, arg4, arg5)));
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
            Collider2D_density,
            Collider2D_isTrigger,
            Collider2D_offset,
            Collider2D_shapeCount,
            Collider2D_sharedMaterial,
            Collider2D_usedByEffector,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Collider2D_Collider2D, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Collider2D_Cast__Vector2__RaycastHit2D_Array, "Cast"),
            new JSMgr.MethodCallBackInfo(Collider2D_Cast__Vector2__RaycastHit2D_Array__Single, "Cast"),
            new JSMgr.MethodCallBackInfo(Collider2D_Cast__Vector2__RaycastHit2D_Array__Single__Boolean, "Cast"),
            new JSMgr.MethodCallBackInfo(Collider2D_IsTouching__Collider2D, "IsTouching"),
            new JSMgr.MethodCallBackInfo(Collider2D_IsTouchingLayers, "IsTouchingLayers"),
            new JSMgr.MethodCallBackInfo(Collider2D_IsTouchingLayers__Int32, "IsTouchingLayers"),
            new JSMgr.MethodCallBackInfo(Collider2D_OverlapPoint__Vector2, "OverlapPoint"),
            new JSMgr.MethodCallBackInfo(Collider2D_Raycast__Vector2__RaycastHit2D_Array, "Raycast"),
            new JSMgr.MethodCallBackInfo(Collider2D_Raycast__Vector2__RaycastHit2D_Array__Single, "Raycast"),
            new JSMgr.MethodCallBackInfo(Collider2D_Raycast__Vector2__RaycastHit2D_Array__Single__Int32, "Raycast"),
            new JSMgr.MethodCallBackInfo(Collider2D_Raycast__Vector2__RaycastHit2D_Array__Single__Int32__Single, "Raycast"),
            new JSMgr.MethodCallBackInfo(Collider2D_Raycast__Vector2__RaycastHit2D_Array__Single__Int32__Single__Single, "Raycast"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}