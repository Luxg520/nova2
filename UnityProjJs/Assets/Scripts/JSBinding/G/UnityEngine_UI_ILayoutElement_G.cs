
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine.UI;
using jsval = JSApi.jsval;
public class UnityEngine_UI_ILayoutElement_G
{
    ////////////////////// ILayoutElement ///////////////////////////////////////
    // constructors
    // fields
    // properties
    static void ILayoutElement_flexibleHeight(JSVCall vc)
    {
        UnityEngine.UI.ILayoutElement _this = (UnityEngine.UI.ILayoutElement)vc.csObj;
        var result = _this.flexibleHeight;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void ILayoutElement_flexibleWidth(JSVCall vc)
    {
        UnityEngine.UI.ILayoutElement _this = (UnityEngine.UI.ILayoutElement)vc.csObj;
        var result = _this.flexibleWidth;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void ILayoutElement_layoutPriority(JSVCall vc)
    {
        UnityEngine.UI.ILayoutElement _this = (UnityEngine.UI.ILayoutElement)vc.csObj;
        var result = _this.layoutPriority;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void ILayoutElement_minHeight(JSVCall vc)
    {
        UnityEngine.UI.ILayoutElement _this = (UnityEngine.UI.ILayoutElement)vc.csObj;
        var result = _this.minHeight;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void ILayoutElement_minWidth(JSVCall vc)
    {
        UnityEngine.UI.ILayoutElement _this = (UnityEngine.UI.ILayoutElement)vc.csObj;
        var result = _this.minWidth;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void ILayoutElement_preferredHeight(JSVCall vc)
    {
        UnityEngine.UI.ILayoutElement _this = (UnityEngine.UI.ILayoutElement)vc.csObj;
        var result = _this.preferredHeight;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void ILayoutElement_preferredWidth(JSVCall vc)
    {
        UnityEngine.UI.ILayoutElement _this = (UnityEngine.UI.ILayoutElement)vc.csObj;
        var result = _this.preferredWidth;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    // methods
    static bool ILayoutElement_CalculateLayoutInputHorizontal(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.ILayoutElement)vc.csObj).CalculateLayoutInputHorizontal();
        }
        return true;
    }
    static bool ILayoutElement_CalculateLayoutInputVertical(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.ILayoutElement)vc.csObj).CalculateLayoutInputVertical();
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.UI.ILayoutElement);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            ILayoutElement_flexibleHeight,
            ILayoutElement_flexibleWidth,
            ILayoutElement_layoutPriority,
            ILayoutElement_minHeight,
            ILayoutElement_minWidth,
            ILayoutElement_preferredHeight,
            ILayoutElement_preferredWidth,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(ILayoutElement_CalculateLayoutInputHorizontal, "CalculateLayoutInputHorizontal"),
            new JSMgr.MethodCallBackInfo(ILayoutElement_CalculateLayoutInputVertical, "CalculateLayoutInputVertical"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}