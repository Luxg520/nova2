
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
    static void MaskableGraphic_material(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.MaskableGraphic _this = (UnityEngine.UI.MaskableGraphic)vc.csObj;
            var result = _this.material;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Material arg0 = (UnityEngine.Material)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.UI.MaskableGraphic _this = (UnityEngine.UI.MaskableGraphic)vc.csObj;
            _this.material = arg0;
        }
    }
    // methods
    static bool MaskableGraphic_ParentMaskStateChanged(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.MaskableGraphic)vc.csObj).ParentMaskStateChanged();
        }
        return true;
    }
    static bool MaskableGraphic_SetMaterialDirty(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.MaskableGraphic)vc.csObj).SetMaterialDirty();
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
            MaskableGraphic_material,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(MaskableGraphic_ParentMaskStateChanged, "ParentMaskStateChanged"),
            new JSMgr.MethodCallBackInfo(MaskableGraphic_SetMaterialDirty, "SetMaterialDirty"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}