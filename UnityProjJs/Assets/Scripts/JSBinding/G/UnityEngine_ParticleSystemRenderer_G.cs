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
            ParticleSystemRenderer_cameraVelocityScale,
            ParticleSystemRenderer_lengthScale,
            ParticleSystemRenderer_maxParticleSize,
            ParticleSystemRenderer_mesh,
            ParticleSystemRenderer_renderMode,
            ParticleSystemRenderer_velocityScale,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(ParticleSystemRenderer_ParticleSystemRenderer, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}