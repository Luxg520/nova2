
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_LineRenderer_G
{
    ////////////////////// LineRenderer ///////////////////////////////////////
    // constructors
    static bool LineRenderer_LineRenderer(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.LineRenderer());
        }
        return true;
    }
    // fields
    // properties
    static void LineRenderer_useWorldSpace(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.LineRenderer _this = (UnityEngine.LineRenderer)vc.csObj;
            var result = _this.useWorldSpace;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.LineRenderer _this = (UnityEngine.LineRenderer)vc.csObj;
            _this.useWorldSpace = arg0;
        }
    }
    // methods
    static bool LineRenderer_SetColors__Color__Color(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Color arg1 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.LineRenderer)vc.csObj).SetColors(arg0, arg1);
        }
        return true;
    }
    static bool LineRenderer_SetPosition__Int32__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.LineRenderer)vc.csObj).SetPosition(arg0, arg1);
        }
        return true;
    }
    static bool LineRenderer_SetPositions__Vector3_Array(JSVCall vc, int argc)
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
            ((UnityEngine.LineRenderer)vc.csObj).SetPositions(arg0);
        }
        return true;
    }
    static bool LineRenderer_SetVertexCount__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.LineRenderer)vc.csObj).SetVertexCount(arg0);
        }
        return true;
    }
    static bool LineRenderer_SetWidth__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.LineRenderer)vc.csObj).SetWidth(arg0, arg1);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.LineRenderer);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            LineRenderer_useWorldSpace,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(LineRenderer_LineRenderer, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(LineRenderer_SetColors__Color__Color, "SetColors"),
            new JSMgr.MethodCallBackInfo(LineRenderer_SetPosition__Int32__Vector3, "SetPosition"),
            new JSMgr.MethodCallBackInfo(LineRenderer_SetPositions__Vector3_Array, "SetPositions"),
            new JSMgr.MethodCallBackInfo(LineRenderer_SetVertexCount__Int32, "SetVertexCount"),
            new JSMgr.MethodCallBackInfo(LineRenderer_SetWidth__Single__Single, "SetWidth"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}