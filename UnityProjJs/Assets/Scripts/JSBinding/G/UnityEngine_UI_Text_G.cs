
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine.UI;
using jsval = JSApi.jsval;
public class UnityEngine_UI_Text_G
{
    ////////////////////// Text ///////////////////////////////////////
    // constructors
    // fields
    // properties
    static void Text_alignByGeometry(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            var result = _this.alignByGeometry;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            _this.alignByGeometry = arg0;
        }
    }
    static void Text_alignment(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            var result = _this.alignment;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.TextAnchor arg0 = (UnityEngine.TextAnchor)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            _this.alignment = arg0;
        }
    }
    static void Text_cachedTextGenerator(JSVCall vc)
    {
        UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
        var result = _this.cachedTextGenerator;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Text_cachedTextGeneratorForLayout(JSVCall vc)
    {
        UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
        var result = _this.cachedTextGeneratorForLayout;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Text_flexibleHeight(JSVCall vc)
    {
        UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
        var result = _this.flexibleHeight;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Text_flexibleWidth(JSVCall vc)
    {
        UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
        var result = _this.flexibleWidth;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Text_font(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            var result = _this.font;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Font arg0 = (UnityEngine.Font)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            _this.font = arg0;
        }
    }
    static void Text_fontSize(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            var result = _this.fontSize;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            _this.fontSize = arg0;
        }
    }
    static void Text_fontStyle(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            var result = _this.fontStyle;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.FontStyle arg0 = (UnityEngine.FontStyle)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            _this.fontStyle = arg0;
        }
    }
    static void Text_horizontalOverflow(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            var result = _this.horizontalOverflow;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.HorizontalWrapMode arg0 = (UnityEngine.HorizontalWrapMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            _this.horizontalOverflow = arg0;
        }
    }
    static void Text_layoutPriority(JSVCall vc)
    {
        UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
        var result = _this.layoutPriority;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Text_lineSpacing(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            var result = _this.lineSpacing;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            _this.lineSpacing = arg0;
        }
    }
    static void Text_mainTexture(JSVCall vc)
    {
        UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
        var result = _this.mainTexture;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Text_minHeight(JSVCall vc)
    {
        UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
        var result = _this.minHeight;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Text_minWidth(JSVCall vc)
    {
        UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
        var result = _this.minWidth;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Text_pixelsPerUnit(JSVCall vc)
    {
        UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
        var result = _this.pixelsPerUnit;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Text_preferredHeight(JSVCall vc)
    {
        UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
        var result = _this.preferredHeight;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Text_preferredWidth(JSVCall vc)
    {
        UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
        var result = _this.preferredWidth;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Text_resizeTextForBestFit(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            var result = _this.resizeTextForBestFit;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            _this.resizeTextForBestFit = arg0;
        }
    }
    static void Text_resizeTextMaxSize(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            var result = _this.resizeTextMaxSize;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            _this.resizeTextMaxSize = arg0;
        }
    }
    static void Text_resizeTextMinSize(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            var result = _this.resizeTextMinSize;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            _this.resizeTextMinSize = arg0;
        }
    }
    static void Text_supportRichText(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            var result = _this.supportRichText;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            _this.supportRichText = arg0;
        }
    }
    static void Text_text(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            var result = _this.text;
            JSApi.setStringS((int)JSApi.SetType.Rval, result);
        }
        else
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            _this.text = arg0;
        }
    }
    static void Text_verticalOverflow(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            var result = _this.verticalOverflow;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.VerticalWrapMode arg0 = (UnityEngine.VerticalWrapMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.UI.Text _this = (UnityEngine.UI.Text)vc.csObj;
            _this.verticalOverflow = arg0;
        }
    }
    // methods
    static bool Text_CalculateLayoutInputHorizontal(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.Text)vc.csObj).CalculateLayoutInputHorizontal();
        }
        return true;
    }
    static bool Text_CalculateLayoutInputVertical(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.Text)vc.csObj).CalculateLayoutInputVertical();
        }
        return true;
    }
    static bool Text_FontTextureChanged(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.Text)vc.csObj).FontTextureChanged();
        }
        return true;
    }
    static bool Text_GetGenerationSettings__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.UI.Text)vc.csObj).GetGenerationSettings(arg0));
        }
        return true;
    }
    static bool Text_OnRebuildRequested(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.Text)vc.csObj).OnRebuildRequested();
        }
        return true;
    }
    static bool Text_GetTextAnchorPivot__TextAnchor(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.TextAnchor arg0 = (UnityEngine.TextAnchor)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.UI.Text.GetTextAnchorPivot(arg0));
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.UI.Text);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Text_alignByGeometry,
            Text_alignment,
            Text_cachedTextGenerator,
            Text_cachedTextGeneratorForLayout,
            Text_flexibleHeight,
            Text_flexibleWidth,
            Text_font,
            Text_fontSize,
            Text_fontStyle,
            Text_horizontalOverflow,
            Text_layoutPriority,
            Text_lineSpacing,
            Text_mainTexture,
            Text_minHeight,
            Text_minWidth,
            Text_pixelsPerUnit,
            Text_preferredHeight,
            Text_preferredWidth,
            Text_resizeTextForBestFit,
            Text_resizeTextMaxSize,
            Text_resizeTextMinSize,
            Text_supportRichText,
            Text_text,
            Text_verticalOverflow,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Text_CalculateLayoutInputHorizontal, "CalculateLayoutInputHorizontal"),
            new JSMgr.MethodCallBackInfo(Text_CalculateLayoutInputVertical, "CalculateLayoutInputVertical"),
            new JSMgr.MethodCallBackInfo(Text_FontTextureChanged, "FontTextureChanged"),
            new JSMgr.MethodCallBackInfo(Text_GetGenerationSettings__Vector2, "GetGenerationSettings"),
            new JSMgr.MethodCallBackInfo(Text_OnRebuildRequested, "OnRebuildRequested"),
            new JSMgr.MethodCallBackInfo(Text_GetTextAnchorPivot__TextAnchor, "GetTextAnchorPivot"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}