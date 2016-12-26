
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsb.Test.Framwork;
using jsval = JSApi.jsval;
public class jsb_Test_Framwork_TestMisc_G
{
    ////////////////////// TestMisc ///////////////////////////////////////
    // constructors
    static bool TestMisc_TestMisc(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new jsb.Test.Framwork.TestMisc());
        }
        return true;
    }
    // fields
    // properties
    // methods
    static bool TestMisc_TestParams__String_Array(JSVCall vc, int argc)
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
            ((jsb.Test.Framwork.TestMisc)vc.csObj).TestParams(arg0);
        }
        return true;
    }
    public static System.Action<System.Int64> TestMisc_GetL_GetDelegate_member1_arg0(CSRepresentedObject objFunction)
    {
        if (objFunction == null || objFunction.jsObjID == 0)
            return null;
         
        System.Action<System.Int64> action = JSMgr.getJSFunCSDelegateRel<System.Action<System.Int64>>(objFunction.jsObjID);
        if (action != null)
            return action;
         
        action = (obj) => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID, obj);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
        return action;

    }
    static bool TestMisc_GetL__ActionT1_Int64(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            System.Action<System.Int64> arg0 = 
                JSDataExchangeMgr.GetJSArg<System.Action<System.Int64>>(() => 
                {
                    if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                    {
                        return TestMisc_GetL_GetDelegate_member1_arg0(JSApi.getFunctionS((int)JSApi.GetType.Arg));
                    }
                    else
                    {
                        return (System.Action<System.Int64>)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                    }
                }
                );
            ;
            jsb.Test.Framwork.TestMisc.GetL(arg0);
        }
        return true;
    }
    public static System.Action<System.UInt64> TestMisc_GetUL_GetDelegate_member2_arg0(CSRepresentedObject objFunction)
    {
        if (objFunction == null || objFunction.jsObjID == 0)
            return null;
         
        System.Action<System.UInt64> action = JSMgr.getJSFunCSDelegateRel<System.Action<System.UInt64>>(objFunction.jsObjID);
        if (action != null)
            return action;
         
        action = (obj) => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID, obj);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
        return action;

    }
    static bool TestMisc_GetUL__ActionT1_UInt64(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            System.Action<System.UInt64> arg0 = 
                JSDataExchangeMgr.GetJSArg<System.Action<System.UInt64>>(() => 
                {
                    if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                    {
                        return TestMisc_GetUL_GetDelegate_member2_arg0(JSApi.getFunctionS((int)JSApi.GetType.Arg));
                    }
                    else
                    {
                        return (System.Action<System.UInt64>)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                    }
                }
                );
            ;
            jsb.Test.Framwork.TestMisc.GetUL(arg0);
        }
        return true;
    }
    static bool TestMisc_SetL__Int64(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            long arg0 = JSApi.getInt64((int)JSApi.GetType.Arg);
            jsb.Test.Framwork.TestMisc.SetL(arg0);
        }
        return true;
    }
    static bool TestMisc_SetUL__UInt64(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            ulong arg0 = JSApi.getUInt64((int)JSApi.GetType.Arg);
            jsb.Test.Framwork.TestMisc.SetUL(arg0);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(jsb.Test.Framwork.TestMisc);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(TestMisc_TestMisc, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(TestMisc_TestParams__String_Array, "TestParams"),
            new JSMgr.MethodCallBackInfo(TestMisc_GetL__ActionT1_Int64, "GetL"),
            new JSMgr.MethodCallBackInfo(TestMisc_GetUL__ActionT1_UInt64, "GetUL"),
            new JSMgr.MethodCallBackInfo(TestMisc_SetL__Int64, "SetL"),
            new JSMgr.MethodCallBackInfo(TestMisc_SetUL__UInt64, "SetUL"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}