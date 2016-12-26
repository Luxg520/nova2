﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_NavMeshPath_G
{
    ////////////////////// NavMeshPath ///////////////////////////////////////
    // constructors
    static bool NavMeshPath_NavMeshPath(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.NavMeshPath());
        }
        return true;
    }
    // fields
    // properties
    static void NavMeshPath_corners(JSVCall vc)
    {
        UnityEngine.NavMeshPath _this = (UnityEngine.NavMeshPath)vc.csObj;
        var result = _this.corners;
            var arrRet = (UnityEngine.Vector3[])result;
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }
    static void NavMeshPath_status(JSVCall vc)
    {
        UnityEngine.NavMeshPath _this = (UnityEngine.NavMeshPath)vc.csObj;
        var result = _this.status;
        JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    // methods
    static bool NavMeshPath_ClearCorners(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.NavMeshPath)vc.csObj).ClearCorners();
        }
        return true;
    }
    static bool NavMeshPath_GetCornersNonAlloc__Vector3_Array(JSVCall vc, int argc)
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
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.NavMeshPath)vc.csObj).GetCornersNonAlloc(arg0)));
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.NavMeshPath);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            NavMeshPath_corners,
            NavMeshPath_status,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(NavMeshPath_NavMeshPath, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(NavMeshPath_ClearCorners, "ClearCorners"),
            new JSMgr.MethodCallBackInfo(NavMeshPath_GetCornersNonAlloc__Vector3_Array, "GetCornersNonAlloc"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}