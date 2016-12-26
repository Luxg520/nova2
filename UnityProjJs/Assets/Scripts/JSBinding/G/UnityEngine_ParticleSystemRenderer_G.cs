﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_ParticleSystemRenderer_G
{
    ////////////////////// ParticleSystemRenderer ///////////////////////////////////////
    // constructors
    static bool ParticleSystemRenderer_ParticleSystemRenderer(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.ParticleSystemRenderer());
        }
        return true;
    }
    // fields
    // properties
    static void ParticleSystemRenderer_alignment(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            var result = _this.alignment;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.ParticleSystemRenderSpace arg0 = (UnityEngine.ParticleSystemRenderSpace)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            _this.alignment = arg0;
        }
    }
    static void ParticleSystemRenderer_cameraVelocityScale(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            var result = _this.cameraVelocityScale;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            _this.cameraVelocityScale = arg0;
        }
    }
    static void ParticleSystemRenderer_lengthScale(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            var result = _this.lengthScale;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            _this.lengthScale = arg0;
        }
    }
    static void ParticleSystemRenderer_maxParticleSize(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            var result = _this.maxParticleSize;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            _this.maxParticleSize = arg0;
        }
    }
    static void ParticleSystemRenderer_mesh(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            var result = _this.mesh;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Mesh arg0 = (UnityEngine.Mesh)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            _this.mesh = arg0;
        }
    }
    static void ParticleSystemRenderer_meshCount(JSVCall vc)
    {
        UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
        var result = _this.meshCount;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void ParticleSystemRenderer_minParticleSize(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            var result = _this.minParticleSize;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            _this.minParticleSize = arg0;
        }
    }
    static void ParticleSystemRenderer_normalDirection(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            var result = _this.normalDirection;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            _this.normalDirection = arg0;
        }
    }
    static void ParticleSystemRenderer_pivot(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            var result = _this.pivot;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            _this.pivot = arg0;
        }
    }
    static void ParticleSystemRenderer_renderMode(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            var result = _this.renderMode;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.ParticleSystemRenderMode arg0 = (UnityEngine.ParticleSystemRenderMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            _this.renderMode = arg0;
        }
    }
    static void ParticleSystemRenderer_sortingFudge(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            var result = _this.sortingFudge;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            _this.sortingFudge = arg0;
        }
    }
    static void ParticleSystemRenderer_sortMode(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            var result = _this.sortMode;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.ParticleSystemSortMode arg0 = (UnityEngine.ParticleSystemSortMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            _this.sortMode = arg0;
        }
    }
    static void ParticleSystemRenderer_velocityScale(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            var result = _this.velocityScale;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystemRenderer _this = (UnityEngine.ParticleSystemRenderer)vc.csObj;
            _this.velocityScale = arg0;
        }
    }
    // methods
    static bool ParticleSystemRenderer_GetMeshes__Mesh_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Mesh[] arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Mesh[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Mesh[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Mesh)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.ParticleSystemRenderer)vc.csObj).GetMeshes(arg0)));
        }
        return true;
    }
    static bool ParticleSystemRenderer_SetMeshes__Mesh_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Mesh[] arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Mesh[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Mesh[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Mesh)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            ((UnityEngine.ParticleSystemRenderer)vc.csObj).SetMeshes(arg0);
        }
        return true;
    }
    static bool ParticleSystemRenderer_SetMeshes__Mesh_Array__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Mesh[] arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Mesh[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Mesh[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Mesh)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.ParticleSystemRenderer)vc.csObj).SetMeshes(arg0, arg1);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.ParticleSystemRenderer);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            ParticleSystemRenderer_alignment,
            ParticleSystemRenderer_cameraVelocityScale,
            ParticleSystemRenderer_lengthScale,
            ParticleSystemRenderer_maxParticleSize,
            ParticleSystemRenderer_mesh,
            ParticleSystemRenderer_meshCount,
            ParticleSystemRenderer_minParticleSize,
            ParticleSystemRenderer_normalDirection,
            ParticleSystemRenderer_pivot,
            ParticleSystemRenderer_renderMode,
            ParticleSystemRenderer_sortingFudge,
            ParticleSystemRenderer_sortMode,
            ParticleSystemRenderer_velocityScale,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(ParticleSystemRenderer_ParticleSystemRenderer, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(ParticleSystemRenderer_GetMeshes__Mesh_Array, "GetMeshes"),
            new JSMgr.MethodCallBackInfo(ParticleSystemRenderer_SetMeshes__Mesh_Array, "SetMeshes"),
            new JSMgr.MethodCallBackInfo(ParticleSystemRenderer_SetMeshes__Mesh_Array__Int32, "SetMeshes"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}