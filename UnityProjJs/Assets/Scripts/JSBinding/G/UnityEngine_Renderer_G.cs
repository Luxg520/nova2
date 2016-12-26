﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Renderer_G
{
    ////////////////////// Renderer ///////////////////////////////////////
    // constructors
    static bool Renderer_Renderer(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Renderer());
        }
        return true;
    }
    // fields
    // properties
    static void Renderer_bounds(JSVCall vc)
    {
        UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
        var result = _this.bounds;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Renderer_castShadows(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            var result = _this.castShadows;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            _this.castShadows = arg0;
        }
    }
    static void Renderer_enabled(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            var result = _this.enabled;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            _this.enabled = arg0;
        }
    }
    static void Renderer_isPartOfStaticBatch(JSVCall vc)
    {
        UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
        var result = _this.isPartOfStaticBatch;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Renderer_isVisible(JSVCall vc)
    {
        UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
        var result = _this.isVisible;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Renderer_lightmapIndex(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            var result = _this.lightmapIndex;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            _this.lightmapIndex = arg0;
        }
    }
    static void Renderer_lightmapTilingOffset(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            var result = _this.lightmapTilingOffset;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector4 arg0 = (UnityEngine.Vector4)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            _this.lightmapTilingOffset = arg0;
        }
    }
    static void Renderer_lightProbeAnchor(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            var result = _this.lightProbeAnchor;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Transform arg0 = (UnityEngine.Transform)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            _this.lightProbeAnchor = arg0;
        }
    }
    static void Renderer_localToWorldMatrix(JSVCall vc)
    {
        UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
        var result = _this.localToWorldMatrix;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Renderer_material(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            var result = _this.material;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Material arg0 = (UnityEngine.Material)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            _this.material = arg0;
        }
    }
    static void Renderer_materials(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            var result = _this.materials;
                var arrRet = (UnityEngine.Material[])result;
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        else
        {
            UnityEngine.Material[] arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Material[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Material[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Material)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            _this.materials = arg0;
        }
    }
    static void Renderer_receiveShadows(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            var result = _this.receiveShadows;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            _this.receiveShadows = arg0;
        }
    }
    static void Renderer_sharedMaterial(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            var result = _this.sharedMaterial;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Material arg0 = (UnityEngine.Material)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            _this.sharedMaterial = arg0;
        }
    }
    static void Renderer_sharedMaterials(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            var result = _this.sharedMaterials;
                var arrRet = (UnityEngine.Material[])result;
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        else
        {
            UnityEngine.Material[] arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Material[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Material[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Material)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            _this.sharedMaterials = arg0;
        }
    }
    static void Renderer_sortingLayerID(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            var result = _this.sortingLayerID;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            _this.sortingLayerID = arg0;
        }
    }
    static void Renderer_sortingLayerName(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            var result = _this.sortingLayerName;
            JSApi.setStringS((int)JSApi.SetType.Rval, result);
        }
        else
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            _this.sortingLayerName = arg0;
        }
    }
    static void Renderer_sortingOrder(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            var result = _this.sortingOrder;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            _this.sortingOrder = arg0;
        }
    }
    static void Renderer_useLightProbes(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            var result = _this.useLightProbes;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
            _this.useLightProbes = arg0;
        }
    }
    static void Renderer_worldToLocalMatrix(JSVCall vc)
    {
        UnityEngine.Renderer _this = (UnityEngine.Renderer)vc.csObj;
        var result = _this.worldToLocalMatrix;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    // methods
    static bool Renderer_GetPropertyBlock__MaterialPropertyBlock(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.MaterialPropertyBlock arg0 = (UnityEngine.MaterialPropertyBlock)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Renderer)vc.csObj).GetPropertyBlock(arg0);
        }
        return true;
    }
    static bool Renderer_Render__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.Renderer)vc.csObj).Render(arg0);
        }
        return true;
    }
    static bool Renderer_SetPropertyBlock__MaterialPropertyBlock(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.MaterialPropertyBlock arg0 = (UnityEngine.MaterialPropertyBlock)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Renderer)vc.csObj).SetPropertyBlock(arg0);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Renderer);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Renderer_bounds,
            Renderer_castShadows,
            Renderer_enabled,
            Renderer_isPartOfStaticBatch,
            Renderer_isVisible,
            Renderer_lightmapIndex,
            Renderer_lightmapTilingOffset,
            Renderer_lightProbeAnchor,
            Renderer_localToWorldMatrix,
            Renderer_material,
            Renderer_materials,
            Renderer_receiveShadows,
            Renderer_sharedMaterial,
            Renderer_sharedMaterials,
            Renderer_sortingLayerID,
            Renderer_sortingLayerName,
            Renderer_sortingOrder,
            Renderer_useLightProbes,
            Renderer_worldToLocalMatrix,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Renderer_Renderer, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Renderer_GetPropertyBlock__MaterialPropertyBlock, "GetPropertyBlock"),
            new JSMgr.MethodCallBackInfo(Renderer_Render__Int32, "Render"),
            new JSMgr.MethodCallBackInfo(Renderer_SetPropertyBlock__MaterialPropertyBlock, "SetPropertyBlock"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}