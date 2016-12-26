﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Sprite_G
{
    ////////////////////// Sprite ///////////////////////////////////////
    // constructors
    static bool Sprite_Sprite(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Sprite());
        }
        return true;
    }
    // fields
    // properties
    static void Sprite_associatedAlphaSplitTexture(JSVCall vc)
    {
        UnityEngine.Sprite _this = (UnityEngine.Sprite)vc.csObj;
        var result = _this.associatedAlphaSplitTexture;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Sprite_border(JSVCall vc)
    {
        UnityEngine.Sprite _this = (UnityEngine.Sprite)vc.csObj;
        var result = _this.border;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Sprite_bounds(JSVCall vc)
    {
        UnityEngine.Sprite _this = (UnityEngine.Sprite)vc.csObj;
        var result = _this.bounds;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Sprite_packed(JSVCall vc)
    {
        UnityEngine.Sprite _this = (UnityEngine.Sprite)vc.csObj;
        var result = _this.packed;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Sprite_packingMode(JSVCall vc)
    {
        UnityEngine.Sprite _this = (UnityEngine.Sprite)vc.csObj;
        var result = _this.packingMode;
        JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    static void Sprite_packingRotation(JSVCall vc)
    {
        UnityEngine.Sprite _this = (UnityEngine.Sprite)vc.csObj;
        var result = _this.packingRotation;
        JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    static void Sprite_pivot(JSVCall vc)
    {
        UnityEngine.Sprite _this = (UnityEngine.Sprite)vc.csObj;
        var result = _this.pivot;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Sprite_pixelsPerUnit(JSVCall vc)
    {
        UnityEngine.Sprite _this = (UnityEngine.Sprite)vc.csObj;
        var result = _this.pixelsPerUnit;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Sprite_rect(JSVCall vc)
    {
        UnityEngine.Sprite _this = (UnityEngine.Sprite)vc.csObj;
        var result = _this.rect;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Sprite_texture(JSVCall vc)
    {
        UnityEngine.Sprite _this = (UnityEngine.Sprite)vc.csObj;
        var result = _this.texture;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Sprite_textureRect(JSVCall vc)
    {
        UnityEngine.Sprite _this = (UnityEngine.Sprite)vc.csObj;
        var result = _this.textureRect;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Sprite_textureRectOffset(JSVCall vc)
    {
        UnityEngine.Sprite _this = (UnityEngine.Sprite)vc.csObj;
        var result = _this.textureRectOffset;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Sprite_triangles(JSVCall vc)
    {
        UnityEngine.Sprite _this = (UnityEngine.Sprite)vc.csObj;
        var result = _this.triangles;
            var arrRet = (ushort[])result;
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSApi.setUInt16((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }
    static void Sprite_uv(JSVCall vc)
    {
        UnityEngine.Sprite _this = (UnityEngine.Sprite)vc.csObj;
        var result = _this.uv;
            var arrRet = (UnityEngine.Vector2[])result;
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }
    static void Sprite_vertices(JSVCall vc)
    {
        UnityEngine.Sprite _this = (UnityEngine.Sprite)vc.csObj;
        var result = _this.vertices;
            var arrRet = (UnityEngine.Vector2[])result;
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }
    // methods
    static bool Sprite_OverrideGeometry__Vector2_Array__UInt16_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2[] arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Vector2[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Vector2[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            ushort[] arg1 = 
                JSDataExchangeMgr.GetJSArg<ushort[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new ushort[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (ushort)JSApi.getUInt16((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            ((UnityEngine.Sprite)vc.csObj).OverrideGeometry(arg0, arg1);
        }
        return true;
    }
    static bool Sprite_Create__Texture2D__Rect__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Texture2D arg0 = (UnityEngine.Texture2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Rect arg1 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Sprite.Create(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Sprite_Create__Texture2D__Rect__Vector2__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Texture2D arg0 = (UnityEngine.Texture2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Rect arg1 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Sprite.Create(arg0, arg1, arg2, arg3));
        }
        return true;
    }
    static bool Sprite_Create__Texture2D__Rect__Vector2__Single__UInt32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Texture2D arg0 = (UnityEngine.Texture2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Rect arg1 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            uint arg4 = JSApi.getUInt32((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Sprite.Create(arg0, arg1, arg2, arg3, arg4));
        }
        return true;
    }
    static bool Sprite_Create__Texture2D__Rect__Vector2__Single__UInt32__SpriteMeshType(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Texture2D arg0 = (UnityEngine.Texture2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Rect arg1 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            uint arg4 = JSApi.getUInt32((int)JSApi.GetType.Arg);
            UnityEngine.SpriteMeshType arg5 = (UnityEngine.SpriteMeshType)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Sprite.Create(arg0, arg1, arg2, arg3, arg4, arg5));
        }
        return true;
    }
    static bool Sprite_Create__Texture2D__Rect__Vector2__Single__UInt32__SpriteMeshType__Vector4(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 7)
        {
            UnityEngine.Texture2D arg0 = (UnityEngine.Texture2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Rect arg1 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            uint arg4 = JSApi.getUInt32((int)JSApi.GetType.Arg);
            UnityEngine.SpriteMeshType arg5 = (UnityEngine.SpriteMeshType)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Vector4 arg6 = (UnityEngine.Vector4)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Sprite.Create(arg0, arg1, arg2, arg3, arg4, arg5, arg6));
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Sprite);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Sprite_associatedAlphaSplitTexture,
            Sprite_border,
            Sprite_bounds,
            Sprite_packed,
            Sprite_packingMode,
            Sprite_packingRotation,
            Sprite_pivot,
            Sprite_pixelsPerUnit,
            Sprite_rect,
            Sprite_texture,
            Sprite_textureRect,
            Sprite_textureRectOffset,
            Sprite_triangles,
            Sprite_uv,
            Sprite_vertices,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Sprite_Sprite, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Sprite_OverrideGeometry__Vector2_Array__UInt16_Array, "OverrideGeometry"),
            new JSMgr.MethodCallBackInfo(Sprite_Create__Texture2D__Rect__Vector2, "Create"),
            new JSMgr.MethodCallBackInfo(Sprite_Create__Texture2D__Rect__Vector2__Single, "Create"),
            new JSMgr.MethodCallBackInfo(Sprite_Create__Texture2D__Rect__Vector2__Single__UInt32, "Create"),
            new JSMgr.MethodCallBackInfo(Sprite_Create__Texture2D__Rect__Vector2__Single__UInt32__SpriteMeshType, "Create"),
            new JSMgr.MethodCallBackInfo(Sprite_Create__Texture2D__Rect__Vector2__Single__UInt32__SpriteMeshType__Vector4, "Create"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}