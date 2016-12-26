
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_LayerMask_G
{
    ////////////////////// LayerMask ///////////////////////////////////////
    // constructors
    public static ConstructorID constructorID0 = new ConstructorID(null, null);
     
    static bool LayerMask_LayerMask(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.LayerMask());
        }
        return true;
    }
    // fields
    // properties
    static void LayerMask_value(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.LayerMask _this = (UnityEngine.LayerMask)vc.csObj;
            var result = _this.value;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.LayerMask _this = (UnityEngine.LayerMask)vc.csObj;
            _this.value = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    // methods
    static bool LayerMask_GetMask__String_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string[] arg0 = 
                JSDataExchangeMgr.GetJSArg<string[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new string[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (string)JSApi.getStringS((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.LayerMask.GetMask(arg0)));
        }
        return true;
    }
    static bool LayerMask_LayerToName__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setStringS((int)JSApi.SetType.Rval, UnityEngine.LayerMask.LayerToName(arg0));
        }
        return true;
    }
    static bool LayerMask_NameToLayer__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.LayerMask.NameToLayer(arg0)));
        }
        return true;
    }
    static bool LayerMask_op_Implicit__LayerMask_to_Int32(JSVCall vc, int argc)
    {
        UnityEngine.LayerMask arg0 = (UnityEngine.LayerMask)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)((int)arg0));
        return true;
    }
    static bool LayerMask_op_Implicit__Int32_to_LayerMask(JSVCall vc, int argc)
    {
        int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, (UnityEngine.LayerMask)arg0);
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.LayerMask);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            LayerMask_value,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(LayerMask_LayerMask, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(LayerMask_GetMask__String_Array, "GetMask"),
            new JSMgr.MethodCallBackInfo(LayerMask_LayerToName__Int32, "LayerToName"),
            new JSMgr.MethodCallBackInfo(LayerMask_NameToLayer__String, "NameToLayer"),
            new JSMgr.MethodCallBackInfo(LayerMask_op_Implicit__LayerMask_to_Int32, "op_Implicit"),
            new JSMgr.MethodCallBackInfo(LayerMask_op_Implicit__Int32_to_LayerMask, "op_Implicit"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}