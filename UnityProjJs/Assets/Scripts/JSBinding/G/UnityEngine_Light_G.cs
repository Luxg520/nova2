﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Light_G
{
    ////////////////////// Light ///////////////////////////////////////
    // constructors
    static bool Light_Light(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Light());
        }
        return true;
    }
    // fields
    // properties
    static void Light_alreadyLightmapped(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.alreadyLightmapped;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.alreadyLightmapped = arg0;
        }
    }
    static void Light_color(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.color;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.color = arg0;
        }
    }
    static void Light_cookie(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.cookie;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Texture arg0 = (UnityEngine.Texture)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.cookie = arg0;
        }
    }
    static void Light_cookieSize(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.cookieSize;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.cookieSize = arg0;
        }
    }
    static void Light_cullingMask(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.cullingMask;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.cullingMask = arg0;
        }
    }
    static void Light_flare(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.flare;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Flare arg0 = (UnityEngine.Flare)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.flare = arg0;
        }
    }
    static void Light_intensity(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.intensity;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.intensity = arg0;
        }
    }
    static void Light_range(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.range;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.range = arg0;
        }
    }
    static void Light_renderMode(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.renderMode;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.LightRenderMode arg0 = (UnityEngine.LightRenderMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.renderMode = arg0;
        }
    }
    static void Light_shadowBias(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.shadowBias;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.shadowBias = arg0;
        }
    }
    static void Light_shadows(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.shadows;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.LightShadows arg0 = (UnityEngine.LightShadows)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.shadows = arg0;
        }
    }
    static void Light_shadowSoftness(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.shadowSoftness;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.shadowSoftness = arg0;
        }
    }
    static void Light_shadowSoftnessFade(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.shadowSoftnessFade;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.shadowSoftnessFade = arg0;
        }
    }
    static void Light_shadowStrength(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.shadowStrength;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.shadowStrength = arg0;
        }
    }
    static void Light_spotAngle(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.spotAngle;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.spotAngle = arg0;
        }
    }
    static void Light_type(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.type;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.LightType arg0 = (UnityEngine.LightType)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.type = arg0;
        }
    }
    // methods
    static bool Light_GetLights__LightType__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.LightType arg0 = (UnityEngine.LightType)JSApi.getEnum((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Light[])UnityEngine.Light.GetLights(arg0, arg1);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Light);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Light_alreadyLightmapped,
            Light_color,
            Light_cookie,
            Light_cookieSize,
            Light_cullingMask,
            Light_flare,
            Light_intensity,
            Light_range,
            Light_renderMode,
            Light_shadowBias,
            Light_shadows,
            Light_shadowSoftness,
            Light_shadowSoftnessFade,
            Light_shadowStrength,
            Light_spotAngle,
            Light_type,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Light_Light, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Light_GetLights__LightType__Int32, "GetLights"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}