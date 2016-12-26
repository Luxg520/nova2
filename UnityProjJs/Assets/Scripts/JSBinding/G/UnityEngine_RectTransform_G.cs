
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_RectTransform_G
{
    ////////////////////// RectTransform ///////////////////////////////////////
    // constructors
    static bool RectTransform_RectTransform(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.RectTransform());
        }
        return true;
    }
    // fields
    // properties
    static void RectTransform_anchoredPosition(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.RectTransform _this = (UnityEngine.RectTransform)vc.csObj;
            var result = _this.anchoredPosition;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RectTransform _this = (UnityEngine.RectTransform)vc.csObj;
            _this.anchoredPosition = arg0;
        }
    }
    static void RectTransform_anchoredPosition3D(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.RectTransform _this = (UnityEngine.RectTransform)vc.csObj;
            var result = _this.anchoredPosition3D;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RectTransform _this = (UnityEngine.RectTransform)vc.csObj;
            _this.anchoredPosition3D = arg0;
        }
    }
    static void RectTransform_anchorMax(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.RectTransform _this = (UnityEngine.RectTransform)vc.csObj;
            var result = _this.anchorMax;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RectTransform _this = (UnityEngine.RectTransform)vc.csObj;
            _this.anchorMax = arg0;
        }
    }
    static void RectTransform_anchorMin(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.RectTransform _this = (UnityEngine.RectTransform)vc.csObj;
            var result = _this.anchorMin;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RectTransform _this = (UnityEngine.RectTransform)vc.csObj;
            _this.anchorMin = arg0;
        }
    }
    static void RectTransform_offsetMax(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.RectTransform _this = (UnityEngine.RectTransform)vc.csObj;
            var result = _this.offsetMax;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RectTransform _this = (UnityEngine.RectTransform)vc.csObj;
            _this.offsetMax = arg0;
        }
    }
    static void RectTransform_offsetMin(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.RectTransform _this = (UnityEngine.RectTransform)vc.csObj;
            var result = _this.offsetMin;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RectTransform _this = (UnityEngine.RectTransform)vc.csObj;
            _this.offsetMin = arg0;
        }
    }
    static void RectTransform_pivot(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.RectTransform _this = (UnityEngine.RectTransform)vc.csObj;
            var result = _this.pivot;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RectTransform _this = (UnityEngine.RectTransform)vc.csObj;
            _this.pivot = arg0;
        }
    }
    static void RectTransform_rect(JSVCall vc)
    {
        UnityEngine.RectTransform _this = (UnityEngine.RectTransform)vc.csObj;
        var result = _this.rect;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void RectTransform_sizeDelta(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.RectTransform _this = (UnityEngine.RectTransform)vc.csObj;
            var result = _this.sizeDelta;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RectTransform _this = (UnityEngine.RectTransform)vc.csObj;
            _this.sizeDelta = arg0;
        }
    }
    // methods
    static bool RectTransform_GetLocalCorners__Vector3_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3[] arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Vector3[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Vector3[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            ((UnityEngine.RectTransform)vc.csObj).GetLocalCorners(arg0);
        }
        return true;
    }
    static bool RectTransform_GetWorldCorners__Vector3_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3[] arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Vector3[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Vector3[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            ((UnityEngine.RectTransform)vc.csObj).GetWorldCorners(arg0);
        }
        return true;
    }
    static bool RectTransform_SetInsetAndSizeFromParentEdge__Edge__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.RectTransform.Edge arg0 = (UnityEngine.RectTransform.Edge)JSApi.getEnum((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.RectTransform)vc.csObj).SetInsetAndSizeFromParentEdge(arg0, arg1, arg2);
        }
        return true;
    }
    static bool RectTransform_SetSizeWithCurrentAnchors__Axis__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.RectTransform.Axis arg0 = (UnityEngine.RectTransform.Axis)JSApi.getEnum((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.RectTransform)vc.csObj).SetSizeWithCurrentAnchors(arg0, arg1);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.RectTransform);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            RectTransform_anchoredPosition,
            RectTransform_anchoredPosition3D,
            RectTransform_anchorMax,
            RectTransform_anchorMin,
            RectTransform_offsetMax,
            RectTransform_offsetMin,
            RectTransform_pivot,
            RectTransform_rect,
            RectTransform_sizeDelta,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(RectTransform_RectTransform, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(RectTransform_GetLocalCorners__Vector3_Array, "GetLocalCorners"),
            new JSMgr.MethodCallBackInfo(RectTransform_GetWorldCorners__Vector3_Array, "GetWorldCorners"),
            new JSMgr.MethodCallBackInfo(RectTransform_SetInsetAndSizeFromParentEdge__Edge__Single__Single, "SetInsetAndSizeFromParentEdge"),
            new JSMgr.MethodCallBackInfo(RectTransform_SetSizeWithCurrentAnchors__Axis__Single, "SetSizeWithCurrentAnchors"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}