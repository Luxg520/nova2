
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine.UI;
using jsval = JSApi.jsval;
public class UnityEngine_UI_LayoutGroup_G
{
    ////////////////////// LayoutGroup ///////////////////////////////////////
    // constructors
    // fields
    // properties
    static void LayoutGroup_childAlignment(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.LayoutGroup _this = (UnityEngine.UI.LayoutGroup)vc.csObj;
            var result = _this.childAlignment;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.TextAnchor arg0 = (UnityEngine.TextAnchor)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.UI.LayoutGroup _this = (UnityEngine.UI.LayoutGroup)vc.csObj;
            _this.childAlignment = arg0;
        }
    }
    static void LayoutGroup_flexibleHeight(JSVCall vc)
    {
        UnityEngine.UI.LayoutGroup _this = (UnityEngine.UI.LayoutGroup)vc.csObj;
        var result = _this.flexibleHeight;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void LayoutGroup_flexibleWidth(JSVCall vc)
    {
        UnityEngine.UI.LayoutGroup _this = (UnityEngine.UI.LayoutGroup)vc.csObj;
        var result = _this.flexibleWidth;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void LayoutGroup_layoutPriority(JSVCall vc)
    {
        UnityEngine.UI.LayoutGroup _this = (UnityEngine.UI.LayoutGroup)vc.csObj;
        var result = _this.layoutPriority;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void LayoutGroup_minHeight(JSVCall vc)
    {
        UnityEngine.UI.LayoutGroup _this = (UnityEngine.UI.LayoutGroup)vc.csObj;
        var result = _this.minHeight;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void LayoutGroup_minWidth(JSVCall vc)
    {
        UnityEngine.UI.LayoutGroup _this = (UnityEngine.UI.LayoutGroup)vc.csObj;
        var result = _this.minWidth;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void LayoutGroup_padding(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.LayoutGroup _this = (UnityEngine.UI.LayoutGroup)vc.csObj;
            var result = _this.padding;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.RectOffset arg0 = (UnityEngine.RectOffset)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.UI.LayoutGroup _this = (UnityEngine.UI.LayoutGroup)vc.csObj;
            _this.padding = arg0;
        }
    }
    static void LayoutGroup_preferredHeight(JSVCall vc)
    {
        UnityEngine.UI.LayoutGroup _this = (UnityEngine.UI.LayoutGroup)vc.csObj;
        var result = _this.preferredHeight;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void LayoutGroup_preferredWidth(JSVCall vc)
    {
        UnityEngine.UI.LayoutGroup _this = (UnityEngine.UI.LayoutGroup)vc.csObj;
        var result = _this.preferredWidth;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    // methods
    static bool LayoutGroup_CalculateLayoutInputHorizontal(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.LayoutGroup)vc.csObj).CalculateLayoutInputHorizontal();
        }
        return true;
    }
    static bool LayoutGroup_CalculateLayoutInputVertical(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.LayoutGroup)vc.csObj).CalculateLayoutInputVertical();
        }
        return true;
    }
    static bool LayoutGroup_SetLayoutHorizontal(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.LayoutGroup)vc.csObj).SetLayoutHorizontal();
        }
        return true;
    }
    static bool LayoutGroup_SetLayoutVertical(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.LayoutGroup)vc.csObj).SetLayoutVertical();
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.UI.LayoutGroup);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            LayoutGroup_childAlignment,
            LayoutGroup_flexibleHeight,
            LayoutGroup_flexibleWidth,
            LayoutGroup_layoutPriority,
            LayoutGroup_minHeight,
            LayoutGroup_minWidth,
            LayoutGroup_padding,
            LayoutGroup_preferredHeight,
            LayoutGroup_preferredWidth,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(LayoutGroup_CalculateLayoutInputHorizontal, "CalculateLayoutInputHorizontal"),
            new JSMgr.MethodCallBackInfo(LayoutGroup_CalculateLayoutInputVertical, "CalculateLayoutInputVertical"),
            new JSMgr.MethodCallBackInfo(LayoutGroup_SetLayoutHorizontal, "SetLayoutHorizontal"),
            new JSMgr.MethodCallBackInfo(LayoutGroup_SetLayoutVertical, "SetLayoutVertical"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}