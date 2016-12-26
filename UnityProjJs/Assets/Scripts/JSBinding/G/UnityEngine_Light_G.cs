
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
    static void Light_bakedIndex(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.bakedIndex;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.bakedIndex = arg0;
        }
    }
    static void Light_bounceIntensity(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.bounceIntensity;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.bounceIntensity = arg0;
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
    static void Light_commandBufferCount(JSVCall vc)
    {
        UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
        var result = _this.commandBufferCount;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
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
    static void Light_isBaked(JSVCall vc)
    {
        UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
        var result = _this.isBaked;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
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
    static void Light_shadowCustomResolution(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.shadowCustomResolution;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.shadowCustomResolution = arg0;
        }
    }
    static void Light_shadowNearPlane(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.shadowNearPlane;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.shadowNearPlane = arg0;
        }
    }
    static void Light_shadowNormalBias(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.shadowNormalBias;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.shadowNormalBias = arg0;
        }
    }
    static void Light_shadowResolution(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            var result = _this.shadowResolution;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.LightShadowResolution arg0 = (UnityEngine.LightShadowResolution)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Light _this = (UnityEngine.Light)vc.csObj;
            _this.shadowResolution = arg0;
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
    static bool Light_AddCommandBuffer__LightEvent__CommandBuffer(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Rendering.LightEvent arg0 = (UnityEngine.Rendering.LightEvent)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Rendering.CommandBuffer arg1 = (UnityEngine.Rendering.CommandBuffer)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Light)vc.csObj).AddCommandBuffer(arg0, arg1);
        }
        return true;
    }
    static bool Light_GetCommandBuffers__LightEvent(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Rendering.LightEvent arg0 = (UnityEngine.Rendering.LightEvent)JSApi.getEnum((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Rendering.CommandBuffer[])((UnityEngine.Light)vc.csObj).GetCommandBuffers(arg0);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Light_RemoveAllCommandBuffers(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Light)vc.csObj).RemoveAllCommandBuffers();
        }
        return true;
    }
    static bool Light_RemoveCommandBuffer__LightEvent__CommandBuffer(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Rendering.LightEvent arg0 = (UnityEngine.Rendering.LightEvent)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Rendering.CommandBuffer arg1 = (UnityEngine.Rendering.CommandBuffer)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Light)vc.csObj).RemoveCommandBuffer(arg0, arg1);
        }
        return true;
    }
    static bool Light_RemoveCommandBuffers__LightEvent(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Rendering.LightEvent arg0 = (UnityEngine.Rendering.LightEvent)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Light)vc.csObj).RemoveCommandBuffers(arg0);
        }
        return true;
    }
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
            Light_bakedIndex,
            Light_bounceIntensity,
            Light_color,
            Light_commandBufferCount,
            Light_cookie,
            Light_cookieSize,
            Light_cullingMask,
            Light_flare,
            Light_intensity,
            Light_isBaked,
            Light_range,
            Light_renderMode,
            Light_shadowBias,
            Light_shadowCustomResolution,
            Light_shadowNearPlane,
            Light_shadowNormalBias,
            Light_shadowResolution,
            Light_shadows,
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
            new JSMgr.MethodCallBackInfo(Light_AddCommandBuffer__LightEvent__CommandBuffer, "AddCommandBuffer"),
            new JSMgr.MethodCallBackInfo(Light_GetCommandBuffers__LightEvent, "GetCommandBuffers"),
            new JSMgr.MethodCallBackInfo(Light_RemoveAllCommandBuffers, "RemoveAllCommandBuffers"),
            new JSMgr.MethodCallBackInfo(Light_RemoveCommandBuffer__LightEvent__CommandBuffer, "RemoveCommandBuffer"),
            new JSMgr.MethodCallBackInfo(Light_RemoveCommandBuffers__LightEvent, "RemoveCommandBuffers"),
            new JSMgr.MethodCallBackInfo(Light_GetLights__LightType__Int32, "GetLights"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}