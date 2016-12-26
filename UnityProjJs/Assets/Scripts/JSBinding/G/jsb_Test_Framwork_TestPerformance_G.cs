
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsb.Test.Framwork;
using jsval = JSApi.jsval;
public class jsb_Test_Framwork_TestPerformance_G
{
    ////////////////////// TestPerformance ///////////////////////////////////////
    // constructors
    static bool TestPerformance_TestPerformance(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new jsb.Test.Framwork.TestPerformance());
        }
        return true;
    }
    // fields
    static void TestPerformance_StaticObject(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = jsb.Test.Framwork.TestPerformance.StaticObject;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            jsb.Test.Framwork.TestPerformance.RefObject arg0 = (jsb.Test.Framwork.TestPerformance.RefObject)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            jsb.Test.Framwork.TestPerformance.StaticObject = arg0;
        }
    }
    // properties
    // methods
    static bool TestPerformance_test123__Object_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            object[] arg0 = 
                JSDataExchangeMgr.GetJSArg<object[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new object[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (object)JSMgr.datax.getWhatever((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            jsb.Test.Framwork.TestPerformance.test123(arg0);
        }
        return true;
    }
    static bool TestPerformance_testString__String_Array(JSVCall vc, int argc)
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
            jsb.Test.Framwork.TestPerformance.testString(arg0);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(jsb.Test.Framwork.TestPerformance);
        ci.fields = new JSMgr.CSCallbackField[]
        {
            TestPerformance_StaticObject,
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(TestPerformance_TestPerformance, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(TestPerformance_test123__Object_Array, "test123"),
            new JSMgr.MethodCallBackInfo(TestPerformance_testString__String_Array, "testString"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}