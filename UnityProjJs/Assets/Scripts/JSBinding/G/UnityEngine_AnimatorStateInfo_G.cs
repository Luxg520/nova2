
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_AnimatorStateInfo_G
{
    ////////////////////// AnimatorStateInfo ///////////////////////////////////////
    // constructors
    public static ConstructorID constructorID0 = new ConstructorID(null, null);
     
    static bool AnimatorStateInfo_AnimatorStateInfo(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.AnimatorStateInfo());
        }
        return true;
    }
    // fields
    // properties
    static void AnimatorStateInfo_fullPathHash(JSVCall vc)
    {
        UnityEngine.AnimatorStateInfo _this = (UnityEngine.AnimatorStateInfo)vc.csObj;
        var result = _this.fullPathHash;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void AnimatorStateInfo_length(JSVCall vc)
    {
        UnityEngine.AnimatorStateInfo _this = (UnityEngine.AnimatorStateInfo)vc.csObj;
        var result = _this.length;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void AnimatorStateInfo_loop(JSVCall vc)
    {
        UnityEngine.AnimatorStateInfo _this = (UnityEngine.AnimatorStateInfo)vc.csObj;
        var result = _this.loop;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void AnimatorStateInfo_normalizedTime(JSVCall vc)
    {
        UnityEngine.AnimatorStateInfo _this = (UnityEngine.AnimatorStateInfo)vc.csObj;
        var result = _this.normalizedTime;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void AnimatorStateInfo_shortNameHash(JSVCall vc)
    {
        UnityEngine.AnimatorStateInfo _this = (UnityEngine.AnimatorStateInfo)vc.csObj;
        var result = _this.shortNameHash;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void AnimatorStateInfo_speed(JSVCall vc)
    {
        UnityEngine.AnimatorStateInfo _this = (UnityEngine.AnimatorStateInfo)vc.csObj;
        var result = _this.speed;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void AnimatorStateInfo_speedMultiplier(JSVCall vc)
    {
        UnityEngine.AnimatorStateInfo _this = (UnityEngine.AnimatorStateInfo)vc.csObj;
        var result = _this.speedMultiplier;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void AnimatorStateInfo_tagHash(JSVCall vc)
    {
        UnityEngine.AnimatorStateInfo _this = (UnityEngine.AnimatorStateInfo)vc.csObj;
        var result = _this.tagHash;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    // methods
    static bool AnimatorStateInfo_IsName__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.AnimatorStateInfo argThis = (UnityEngine.AnimatorStateInfo)vc.csObj;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(argThis.IsName(arg0)));
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool AnimatorStateInfo_IsTag__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.AnimatorStateInfo argThis = (UnityEngine.AnimatorStateInfo)vc.csObj;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(argThis.IsTag(arg0)));
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.AnimatorStateInfo);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            AnimatorStateInfo_fullPathHash,
            AnimatorStateInfo_length,
            AnimatorStateInfo_loop,
            AnimatorStateInfo_normalizedTime,
            AnimatorStateInfo_shortNameHash,
            AnimatorStateInfo_speed,
            AnimatorStateInfo_speedMultiplier,
            AnimatorStateInfo_tagHash,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(AnimatorStateInfo_AnimatorStateInfo, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(AnimatorStateInfo_IsName__String, "IsName"),
            new JSMgr.MethodCallBackInfo(AnimatorStateInfo_IsTag__String, "IsTag"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}