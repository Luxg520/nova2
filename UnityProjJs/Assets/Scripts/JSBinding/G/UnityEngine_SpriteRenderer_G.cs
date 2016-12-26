
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_SpriteRenderer_G
{
    ////////////////////// SpriteRenderer ///////////////////////////////////////
    // constructors
    static bool SpriteRenderer_SpriteRenderer(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.SpriteRenderer());
        }
        return true;
    }
    // fields
    // properties
    static void SpriteRenderer_color(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.SpriteRenderer _this = (UnityEngine.SpriteRenderer)vc.csObj;
            var result = _this.color;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.SpriteRenderer _this = (UnityEngine.SpriteRenderer)vc.csObj;
            _this.color = arg0;
        }
    }
    static void SpriteRenderer_sprite(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.SpriteRenderer _this = (UnityEngine.SpriteRenderer)vc.csObj;
            var result = _this.sprite;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Sprite arg0 = (UnityEngine.Sprite)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.SpriteRenderer _this = (UnityEngine.SpriteRenderer)vc.csObj;
            _this.sprite = arg0;
        }
    }
    // methods
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.SpriteRenderer);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            SpriteRenderer_color,
            SpriteRenderer_sprite,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(SpriteRenderer_SpriteRenderer, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}