
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsb.Test.Framwork;
using jsval = JSApi.jsval;
public class jsb_Test_Framwork_TestRF_G
{
    ////////////////////// TestRF ///////////////////////////////////////
    // constructors
    static bool TestRF_TestRF(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new jsb.Test.Framwork.TestRF());
        }
        return true;
    }
    // fields
    // properties
    // methods
    static bool TestRF_Get_Out__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int r_arg0 = JSApi.incArgIndex();
            int arg0;
            jsb.Test.Framwork.TestRF.Get_Out(out arg0);
            JSApi.setArgIndex(r_arg0);
            JSApi.setInt32((int)JSApi.SetType.ArgRef, arg0);
        }
        return true;
    }
    static bool TestRF_Increase_ByRef__Boolean__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            int r_arg1 = JSApi.getArgIndex();
            int arg1 = (int)JSApi.getInt32((int)JSApi.GetType.ArgRef);
            jsb.Test.Framwork.TestRF.Increase_ByRef(arg0, ref arg1);
            JSApi.setArgIndex(r_arg1);
            JSApi.setInt32((int)JSApi.SetType.ArgRef, arg1);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(jsb.Test.Framwork.TestRF);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(TestRF_TestRF, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(TestRF_Get_Out__Int32, "Get_Out"),
            new JSMgr.MethodCallBackInfo(TestRF_Increase_ByRef__Boolean__Int32, "Increase_ByRef"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}