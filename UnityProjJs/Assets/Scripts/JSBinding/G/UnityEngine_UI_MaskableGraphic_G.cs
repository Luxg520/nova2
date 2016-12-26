
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine.UI;
using jsval = JSApi.jsval;
public class UnityEngine_UI_MaskableGraphic_G
{
    ////////////////////// MaskableGraphic ///////////////////////////////////////
    // constructors
    // fields
    // properties
    static void MaskableGraphic_maskable(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.MaskableGraphic _this = (UnityEngine.UI.MaskableGraphic)vc.csObj;
            var result = _this.maskable;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.UI.MaskableGraphic _this = (UnityEngine.UI.MaskableGraphic)vc.csObj;
            _this.maskable = arg0;
        }
    }
    static void MaskableGraphic_onCullStateChanged(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.MaskableGraphic _this = (UnityEngine.UI.MaskableGraphic)vc.csObj;
            var result = _this.onCullStateChanged;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.UI.MaskableGraphic.CullStateChangedEvent arg0 = (UnityEngine.UI.MaskableGraphic.CullStateChangedEvent)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.UI.MaskableGraphic _this = (UnityEngine.UI.MaskableGraphic)vc.csObj;
            _this.onCullStateChanged = arg0;
        }
    }
    // methods
    static bool MaskableGraphic_Cull__Rect__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            bool arg1 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            ((UnityEngine.UI.MaskableGraphic)vc.csObj).Cull(arg0, arg1);
        }
        return true;
    }
    static bool MaskableGraphic_GetModifiedMaterial__Material(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Material arg0 = (UnityEngine.Material)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.UI.MaskableGraphic)vc.csObj).GetModifiedMaterial(arg0));
        }
        return true;
    }
    static bool MaskableGraphic_RecalculateClipping(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.MaskableGraphic)vc.csObj).RecalculateClipping();
        }
        return true;
    }
    static bool MaskableGraphic_RecalculateMasking(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.MaskableGraphic)vc.csObj).RecalculateMasking();
        }
        return true;
    }
    static bool MaskableGraphic_SetClipRect__Rect__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            bool arg1 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            ((UnityEngine.UI.MaskableGraphic)vc.csObj).SetClipRect(arg0, arg1);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.UI.MaskableGraphic);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            MaskableGraphic_maskable,
            MaskableGraphic_onCullStateChanged,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(MaskableGraphic_Cull__Rect__Boolean, "Cull"),
            new JSMgr.MethodCallBackInfo(MaskableGraphic_GetModifiedMaterial__Material, "GetModifiedMaterial"),
            new JSMgr.MethodCallBackInfo(MaskableGraphic_RecalculateClipping, "RecalculateClipping"),
            new JSMgr.MethodCallBackInfo(MaskableGraphic_RecalculateMasking, "RecalculateMasking"),
            new JSMgr.MethodCallBackInfo(MaskableGraphic_SetClipRect__Rect__Boolean, "SetClipRect"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}