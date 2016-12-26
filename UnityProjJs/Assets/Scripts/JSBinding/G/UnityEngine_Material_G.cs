
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Material_G
{
    ////////////////////// Material ///////////////////////////////////////
    // constructors
    static bool Material_Material(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSMgr.addJSCSRel(_this, new UnityEngine.Material(arg0));
        }
        return true;
    }
    static bool Material_Material1(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Material arg0 = (UnityEngine.Material)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.addJSCSRel(_this, new UnityEngine.Material(arg0));
        }
        return true;
    }
    static bool Material_Material2(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Shader arg0 = (UnityEngine.Shader)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.addJSCSRel(_this, new UnityEngine.Material(arg0));
        }
        return true;
    }
    // fields
    // properties
    static void Material_color(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Material _this = (UnityEngine.Material)vc.csObj;
            var result = _this.color;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Material _this = (UnityEngine.Material)vc.csObj;
            _this.color = arg0;
        }
    }
    static void Material_mainTexture(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Material _this = (UnityEngine.Material)vc.csObj;
            var result = _this.mainTexture;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Texture arg0 = (UnityEngine.Texture)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Material _this = (UnityEngine.Material)vc.csObj;
            _this.mainTexture = arg0;
        }
    }
    static void Material_mainTextureOffset(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Material _this = (UnityEngine.Material)vc.csObj;
            var result = _this.mainTextureOffset;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Material _this = (UnityEngine.Material)vc.csObj;
            _this.mainTextureOffset = arg0;
        }
    }
    static void Material_mainTextureScale(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Material _this = (UnityEngine.Material)vc.csObj;
            var result = _this.mainTextureScale;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Material _this = (UnityEngine.Material)vc.csObj;
            _this.mainTextureScale = arg0;
        }
    }
    static void Material_passCount(JSVCall vc)
    {
        UnityEngine.Material _this = (UnityEngine.Material)vc.csObj;
        var result = _this.passCount;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Material_renderQueue(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Material _this = (UnityEngine.Material)vc.csObj;
            var result = _this.renderQueue;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Material _this = (UnityEngine.Material)vc.csObj;
            _this.renderQueue = arg0;
        }
    }
    static void Material_shader(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Material _this = (UnityEngine.Material)vc.csObj;
            var result = _this.shader;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Shader arg0 = (UnityEngine.Shader)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Material _this = (UnityEngine.Material)vc.csObj;
            _this.shader = arg0;
        }
    }
    static void Material_shaderKeywords(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Material _this = (UnityEngine.Material)vc.csObj;
            var result = _this.shaderKeywords;
                var arrRet = (string[])result;
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSApi.setStringS((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        else
        {
            string[] arg0 = 
                JSDataExchangeMgr.GetJSArg<string[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new string[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (string)JSApi.getStringS((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            UnityEngine.Material _this = (UnityEngine.Material)vc.csObj;
            _this.shaderKeywords = arg0;
        }
    }
    // methods
    static bool Material_CopyPropertiesFromMaterial__Material(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Material arg0 = (UnityEngine.Material)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Material)vc.csObj).CopyPropertiesFromMaterial(arg0);
        }
        return true;
    }
    static bool Material_DisableKeyword__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            ((UnityEngine.Material)vc.csObj).DisableKeyword(arg0);
        }
        return true;
    }
    static bool Material_EnableKeyword__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            ((UnityEngine.Material)vc.csObj).EnableKeyword(arg0);
        }
        return true;
    }
    static bool Material_GetColor__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Material)vc.csObj).GetColor(arg0));
        }
        return true;
    }
    static bool Material_GetColor__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Material)vc.csObj).GetColor(arg0));
        }
        return true;
    }
    static bool Material_GetFloat__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(((UnityEngine.Material)vc.csObj).GetFloat(arg0)));
        }
        return true;
    }
    static bool Material_GetFloat__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(((UnityEngine.Material)vc.csObj).GetFloat(arg0)));
        }
        return true;
    }
    static bool Material_GetInt__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.Material)vc.csObj).GetInt(arg0)));
        }
        return true;
    }
    static bool Material_GetInt__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.Material)vc.csObj).GetInt(arg0)));
        }
        return true;
    }
    static bool Material_GetMatrix__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Material)vc.csObj).GetMatrix(arg0));
        }
        return true;
    }
    static bool Material_GetMatrix__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Material)vc.csObj).GetMatrix(arg0));
        }
        return true;
    }
    static bool Material_GetTag__String__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            bool arg1 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            JSApi.setStringS((int)JSApi.SetType.Rval, ((UnityEngine.Material)vc.csObj).GetTag(arg0, arg1));
        }
        return true;
    }
    static bool Material_GetTag__String__Boolean__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            bool arg1 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            string arg2 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setStringS((int)JSApi.SetType.Rval, ((UnityEngine.Material)vc.csObj).GetTag(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Material_GetTexture__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Material)vc.csObj).GetTexture(arg0));
        }
        return true;
    }
    static bool Material_GetTexture__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Material)vc.csObj).GetTexture(arg0));
        }
        return true;
    }
    static bool Material_GetTextureOffset__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Material)vc.csObj).GetTextureOffset(arg0));
        }
        return true;
    }
    static bool Material_GetTextureScale__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Material)vc.csObj).GetTextureScale(arg0));
        }
        return true;
    }
    static bool Material_GetVector__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Material)vc.csObj).GetVector(arg0));
        }
        return true;
    }
    static bool Material_GetVector__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Material)vc.csObj).GetVector(arg0));
        }
        return true;
    }
    static bool Material_HasProperty__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Material)vc.csObj).HasProperty(arg0)));
        }
        return true;
    }
    static bool Material_HasProperty__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Material)vc.csObj).HasProperty(arg0)));
        }
        return true;
    }
    static bool Material_Lerp__Material__Material__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Material arg0 = (UnityEngine.Material)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Material arg1 = (UnityEngine.Material)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Material)vc.csObj).Lerp(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Material_SetBuffer__String__ComputeBuffer(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.ComputeBuffer arg1 = (UnityEngine.ComputeBuffer)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Material)vc.csObj).SetBuffer(arg0, arg1);
        }
        return true;
    }
    static bool Material_SetColor__Int32__Color(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Color arg1 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Material)vc.csObj).SetColor(arg0, arg1);
        }
        return true;
    }
    static bool Material_SetColor__String__Color(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.Color arg1 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Material)vc.csObj).SetColor(arg0, arg1);
        }
        return true;
    }
    static bool Material_SetFloat__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Material)vc.csObj).SetFloat(arg0, arg1);
        }
        return true;
    }
    static bool Material_SetFloat__String__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Material)vc.csObj).SetFloat(arg0, arg1);
        }
        return true;
    }
    static bool Material_SetInt__Int32__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.Material)vc.csObj).SetInt(arg0, arg1);
        }
        return true;
    }
    static bool Material_SetInt__String__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.Material)vc.csObj).SetInt(arg0, arg1);
        }
        return true;
    }
    static bool Material_SetMatrix__Int32__Matrix4x4(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Matrix4x4 arg1 = (UnityEngine.Matrix4x4)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Material)vc.csObj).SetMatrix(arg0, arg1);
        }
        return true;
    }
    static bool Material_SetMatrix__String__Matrix4x4(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.Matrix4x4 arg1 = (UnityEngine.Matrix4x4)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Material)vc.csObj).SetMatrix(arg0, arg1);
        }
        return true;
    }
    static bool Material_SetPass__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Material)vc.csObj).SetPass(arg0)));
        }
        return true;
    }
    static bool Material_SetTexture__Int32__Texture(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Texture arg1 = (UnityEngine.Texture)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Material)vc.csObj).SetTexture(arg0, arg1);
        }
        return true;
    }
    static bool Material_SetTexture__String__Texture(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.Texture arg1 = (UnityEngine.Texture)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Material)vc.csObj).SetTexture(arg0, arg1);
        }
        return true;
    }
    static bool Material_SetTextureOffset__String__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Material)vc.csObj).SetTextureOffset(arg0, arg1);
        }
        return true;
    }
    static bool Material_SetTextureScale__String__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Material)vc.csObj).SetTextureScale(arg0, arg1);
        }
        return true;
    }
    static bool Material_SetVector__Int32__Vector4(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Vector4 arg1 = (UnityEngine.Vector4)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Material)vc.csObj).SetVector(arg0, arg1);
        }
        return true;
    }
    static bool Material_SetVector__String__Vector4(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.Vector4 arg1 = (UnityEngine.Vector4)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Material)vc.csObj).SetVector(arg0, arg1);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Material);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Material_color,
            Material_mainTexture,
            Material_mainTextureOffset,
            Material_mainTextureScale,
            Material_passCount,
            Material_renderQueue,
            Material_shader,
            Material_shaderKeywords,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Material_Material, ".ctor"),
            new JSMgr.MethodCallBackInfo(Material_Material1, ".ctor"),
            new JSMgr.MethodCallBackInfo(Material_Material2, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Material_CopyPropertiesFromMaterial__Material, "CopyPropertiesFromMaterial"),
            new JSMgr.MethodCallBackInfo(Material_DisableKeyword__String, "DisableKeyword"),
            new JSMgr.MethodCallBackInfo(Material_EnableKeyword__String, "EnableKeyword"),
            new JSMgr.MethodCallBackInfo(Material_GetColor__Int32, "GetColor"),
            new JSMgr.MethodCallBackInfo(Material_GetColor__String, "GetColor"),
            new JSMgr.MethodCallBackInfo(Material_GetFloat__Int32, "GetFloat"),
            new JSMgr.MethodCallBackInfo(Material_GetFloat__String, "GetFloat"),
            new JSMgr.MethodCallBackInfo(Material_GetInt__Int32, "GetInt"),
            new JSMgr.MethodCallBackInfo(Material_GetInt__String, "GetInt"),
            new JSMgr.MethodCallBackInfo(Material_GetMatrix__Int32, "GetMatrix"),
            new JSMgr.MethodCallBackInfo(Material_GetMatrix__String, "GetMatrix"),
            new JSMgr.MethodCallBackInfo(Material_GetTag__String__Boolean, "GetTag"),
            new JSMgr.MethodCallBackInfo(Material_GetTag__String__Boolean__String, "GetTag"),
            new JSMgr.MethodCallBackInfo(Material_GetTexture__Int32, "GetTexture"),
            new JSMgr.MethodCallBackInfo(Material_GetTexture__String, "GetTexture"),
            new JSMgr.MethodCallBackInfo(Material_GetTextureOffset__String, "GetTextureOffset"),
            new JSMgr.MethodCallBackInfo(Material_GetTextureScale__String, "GetTextureScale"),
            new JSMgr.MethodCallBackInfo(Material_GetVector__Int32, "GetVector"),
            new JSMgr.MethodCallBackInfo(Material_GetVector__String, "GetVector"),
            new JSMgr.MethodCallBackInfo(Material_HasProperty__Int32, "HasProperty"),
            new JSMgr.MethodCallBackInfo(Material_HasProperty__String, "HasProperty"),
            new JSMgr.MethodCallBackInfo(Material_Lerp__Material__Material__Single, "Lerp"),
            new JSMgr.MethodCallBackInfo(Material_SetBuffer__String__ComputeBuffer, "SetBuffer"),
            new JSMgr.MethodCallBackInfo(Material_SetColor__Int32__Color, "SetColor"),
            new JSMgr.MethodCallBackInfo(Material_SetColor__String__Color, "SetColor"),
            new JSMgr.MethodCallBackInfo(Material_SetFloat__Int32__Single, "SetFloat"),
            new JSMgr.MethodCallBackInfo(Material_SetFloat__String__Single, "SetFloat"),
            new JSMgr.MethodCallBackInfo(Material_SetInt__Int32__Int32, "SetInt"),
            new JSMgr.MethodCallBackInfo(Material_SetInt__String__Int32, "SetInt"),
            new JSMgr.MethodCallBackInfo(Material_SetMatrix__Int32__Matrix4x4, "SetMatrix"),
            new JSMgr.MethodCallBackInfo(Material_SetMatrix__String__Matrix4x4, "SetMatrix"),
            new JSMgr.MethodCallBackInfo(Material_SetPass__Int32, "SetPass"),
            new JSMgr.MethodCallBackInfo(Material_SetTexture__Int32__Texture, "SetTexture"),
            new JSMgr.MethodCallBackInfo(Material_SetTexture__String__Texture, "SetTexture"),
            new JSMgr.MethodCallBackInfo(Material_SetTextureOffset__String__Vector2, "SetTextureOffset"),
            new JSMgr.MethodCallBackInfo(Material_SetTextureScale__String__Vector2, "SetTextureScale"),
            new JSMgr.MethodCallBackInfo(Material_SetVector__Int32__Vector4, "SetVector"),
            new JSMgr.MethodCallBackInfo(Material_SetVector__String__Vector4, "SetVector"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}