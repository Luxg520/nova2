
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_GUIText_G
{
    ////////////////////// GUIText ///////////////////////////////////////
    // constructors
    static bool GUIText_GUIText(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.GUIText());
        }
        return true;
    }
    // fields
    // properties
    static void GUIText_alignment(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            var result = _this.alignment;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.TextAlignment arg0 = (UnityEngine.TextAlignment)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            _this.alignment = arg0;
        }
    }
    static void GUIText_anchor(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            var result = _this.anchor;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.TextAnchor arg0 = (UnityEngine.TextAnchor)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            _this.anchor = arg0;
        }
    }
    static void GUIText_color(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            var result = _this.color;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            _this.color = arg0;
        }
    }
    static void GUIText_font(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            var result = _this.font;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Font arg0 = (UnityEngine.Font)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            _this.font = arg0;
        }
    }
    static void GUIText_fontSize(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            var result = _this.fontSize;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            _this.fontSize = arg0;
        }
    }
    static void GUIText_fontStyle(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            var result = _this.fontStyle;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.FontStyle arg0 = (UnityEngine.FontStyle)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            _this.fontStyle = arg0;
        }
    }
    static void GUIText_lineSpacing(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            var result = _this.lineSpacing;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            _this.lineSpacing = arg0;
        }
    }
    static void GUIText_material(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            var result = _this.material;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Material arg0 = (UnityEngine.Material)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            _this.material = arg0;
        }
    }
    static void GUIText_pixelOffset(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            var result = _this.pixelOffset;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            _this.pixelOffset = arg0;
        }
    }
    static void GUIText_richText(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            var result = _this.richText;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            _this.richText = arg0;
        }
    }
    static void GUIText_tabSize(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            var result = _this.tabSize;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            _this.tabSize = arg0;
        }
    }
    static void GUIText_text(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            var result = _this.text;
            JSApi.setStringS((int)JSApi.SetType.Rval, result);
        }
        else
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.GUIText _this = (UnityEngine.GUIText)vc.csObj;
            _this.text = arg0;
        }
    }
    // methods
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.GUIText);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            GUIText_alignment,
            GUIText_anchor,
            GUIText_color,
            GUIText_font,
            GUIText_fontSize,
            GUIText_fontStyle,
            GUIText_lineSpacing,
            GUIText_material,
            GUIText_pixelOffset,
            GUIText_richText,
            GUIText_tabSize,
            GUIText_text,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(GUIText_GUIText, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}