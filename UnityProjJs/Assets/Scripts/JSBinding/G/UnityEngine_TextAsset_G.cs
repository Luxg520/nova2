
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_TextAsset_G
{
    ////////////////////// TextAsset ///////////////////////////////////////
    // constructors
    static bool TextAsset_TextAsset(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.TextAsset());
        }
        return true;
    }
    // fields
    // properties
    static void TextAsset_bytes(JSVCall vc)
    {
        UnityEngine.TextAsset _this = (UnityEngine.TextAsset)vc.csObj;
        var result = _this.bytes;
            var arrRet = (byte[])result;
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSApi.setByte((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }
    static void TextAsset_text(JSVCall vc)
    {
        UnityEngine.TextAsset _this = (UnityEngine.TextAsset)vc.csObj;
        var result = _this.text;
        JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    // methods
    static bool TextAsset_ToString(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSApi.setStringS((int)JSApi.SetType.Rval, ((UnityEngine.TextAsset)vc.csObj).ToString());
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.TextAsset);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            TextAsset_bytes,
            TextAsset_text,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(TextAsset_TextAsset, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(TextAsset_ToString, "ToString"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}