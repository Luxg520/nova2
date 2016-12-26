﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_GUITexture_G
{
    ////////////////////// GUITexture ///////////////////////////////////////
    // constructors
    static bool GUITexture_GUITexture(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.GUITexture());
        }
        return true;
    }
    // fields
    // properties
    static void GUITexture_border(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.GUITexture _this = (UnityEngine.GUITexture)vc.csObj;
            var result = _this.border;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.RectOffset arg0 = (UnityEngine.RectOffset)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.GUITexture _this = (UnityEngine.GUITexture)vc.csObj;
            _this.border = arg0;
        }
    }
    static void GUITexture_color(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.GUITexture _this = (UnityEngine.GUITexture)vc.csObj;
            var result = _this.color;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.GUITexture _this = (UnityEngine.GUITexture)vc.csObj;
            _this.color = arg0;
        }
    }
    static void GUITexture_pixelInset(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.GUITexture _this = (UnityEngine.GUITexture)vc.csObj;
            var result = _this.pixelInset;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.GUITexture _this = (UnityEngine.GUITexture)vc.csObj;
            _this.pixelInset = arg0;
        }
    }
    static void GUITexture_texture(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.GUITexture _this = (UnityEngine.GUITexture)vc.csObj;
            var result = _this.texture;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Texture arg0 = (UnityEngine.Texture)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.GUITexture _this = (UnityEngine.GUITexture)vc.csObj;
            _this.texture = arg0;
        }
    }
    // methods
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.GUITexture);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            GUITexture_border,
            GUITexture_color,
            GUITexture_pixelInset,
            GUITexture_texture,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(GUITexture_GUITexture, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}