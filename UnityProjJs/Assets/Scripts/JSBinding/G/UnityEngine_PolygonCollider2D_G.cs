
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_PolygonCollider2D_G
{
    ////////////////////// PolygonCollider2D ///////////////////////////////////////
    // constructors
    static bool PolygonCollider2D_PolygonCollider2D(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.PolygonCollider2D());
        }
        return true;
    }
    // fields
    // properties
    static void PolygonCollider2D_pathCount(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.PolygonCollider2D _this = (UnityEngine.PolygonCollider2D)vc.csObj;
            var result = _this.pathCount;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.PolygonCollider2D _this = (UnityEngine.PolygonCollider2D)vc.csObj;
            _this.pathCount = arg0;
        }
    }
    static void PolygonCollider2D_points(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.PolygonCollider2D _this = (UnityEngine.PolygonCollider2D)vc.csObj;
            var result = _this.points;
                var arrRet = (UnityEngine.Vector2[])result;
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        else
        {
            UnityEngine.Vector2[] arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Vector2[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Vector2[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            UnityEngine.PolygonCollider2D _this = (UnityEngine.PolygonCollider2D)vc.csObj;
            _this.points = arg0;
        }
    }
    // methods
    static bool PolygonCollider2D_CreatePrimitive__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.PolygonCollider2D)vc.csObj).CreatePrimitive(arg0);
        }
        return true;
    }
    static bool PolygonCollider2D_CreatePrimitive__Int32__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.PolygonCollider2D)vc.csObj).CreatePrimitive(arg0, arg1);
        }
        return true;
    }
    static bool PolygonCollider2D_CreatePrimitive__Int32__Vector2__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.PolygonCollider2D)vc.csObj).CreatePrimitive(arg0, arg1, arg2);
        }
        return true;
    }
    static bool PolygonCollider2D_GetPath__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Vector2[])((UnityEngine.PolygonCollider2D)vc.csObj).GetPath(arg0);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool PolygonCollider2D_GetTotalPointCount(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.PolygonCollider2D)vc.csObj).GetTotalPointCount()));
        }
        return true;
    }
    static bool PolygonCollider2D_SetPath__Int32__Vector2_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Vector2[] arg1 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Vector2[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Vector2[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            ((UnityEngine.PolygonCollider2D)vc.csObj).SetPath(arg0, arg1);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.PolygonCollider2D);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            PolygonCollider2D_pathCount,
            PolygonCollider2D_points,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(PolygonCollider2D_PolygonCollider2D, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(PolygonCollider2D_CreatePrimitive__Int32, "CreatePrimitive"),
            new JSMgr.MethodCallBackInfo(PolygonCollider2D_CreatePrimitive__Int32__Vector2, "CreatePrimitive"),
            new JSMgr.MethodCallBackInfo(PolygonCollider2D_CreatePrimitive__Int32__Vector2__Vector2, "CreatePrimitive"),
            new JSMgr.MethodCallBackInfo(PolygonCollider2D_GetPath__Int32, "GetPath"),
            new JSMgr.MethodCallBackInfo(PolygonCollider2D_GetTotalPointCount, "GetTotalPointCount"),
            new JSMgr.MethodCallBackInfo(PolygonCollider2D_SetPath__Int32__Vector2_Array, "SetPath"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}