
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsb.Test.Framwork;
using jsval = JSApi.jsval;
public class jsb_Test_Framwork_TestGeneric7__7_G
{
    ////////////////////// TestGeneric`3 ///////////////////////////////////////
    // constructors
    public static ConstructorID constructorID0 = new ConstructorID(new string[]{"T"}, new TypeFlag[]{TypeFlag.IsT});
     
    static bool TestGenericA3_TestGenericA3(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        ConstructorInfo constructor = JSDataExchangeMgr.makeGenericConstructor(typeof(jsb.Test.Framwork.TestGeneric<,,>), constructorID0);
        if (constructor == null)
            return true;
         
        int len = argc - 3;
        if (len == 1)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            JSMgr.addJSCSRel(_this, constructor.Invoke(null, new object[]{arg0}));
        }
        return true;
    }
    // fields
    // properties
    // methods
    public static jsb.Test.Framwork.TestGeneric<T,J,K>.CompareFunc TestGenericA3_Compare_GetDelegate_member0_arg0<T, J, K>(CSRepresentedObject objFunction)
    {
        if (objFunction == null || objFunction.jsObjID == 0)
            return null;
         
        jsb.Test.Framwork.TestGeneric<T,J,K>.CompareFunc action = JSMgr.getJSFunCSDelegateRel<jsb.Test.Framwork.TestGeneric<T,J,K>.CompareFunc>(objFunction.jsObjID);
        if (action != null)
            return action;
         
        action = (t) => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID, t);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
        return action;

    }
    public static MethodID methodID0 = new MethodID("Compare", "Void", TypeFlag.None, new string[]{"CompareFunc"}, new TypeFlag[]{TypeFlag.IsGenericType});
    static bool TestGenericA3_Compare__CompareFunc_T_J_K(JSVCall vc, int argc)
    {
        // Get generic method by name and param count.
        MethodInfo method = GenericTypeCache.getMethod(vc.csObj.GetType(), methodID0);
        if (method == null)
            return true;
         
        int len = argc;
        if (len == 1)
        {
            object arg0 = JSDataExchangeMgr.GetJSArg<object>(() =>
            {
                if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                {
                    var getDelegateFun0 = typeof(jsb_Test_Framwork_TestGeneric7__7_G).GetMethod("TestGenericA3_Compare_GetDelegate_member0_arg0").MakeGenericMethod
                        (method.GetParameters()[0].ParameterType.GetGenericArguments());
                    return getDelegateFun0.Invoke(null, new object[]{JSApi.getFunctionS((int)JSApi.GetType.Arg)});
                }
                else
                {
                    return JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                }
            }
            );
            object[] arr_t = new object[]{arg0};
            method.Invoke(vc.csObj, arr_t);
        }
        return true;
    }
    public static MethodID methodID1 = new MethodID("Hello", "Void", TypeFlag.None, null, null);
    static bool TestGenericA3_HelloT2(JSVCall vc, int argc)
    {
        // Get generic method by name and param count.
        MethodInfo method = JSDataExchangeMgr.makeGenericMethod(vc.csObj.GetType(), methodID1, 2);
        if (method == null)
            return true;
         
        int len = argc - 2;
        if (len == 0)
        {
            object[] arr_t = null;
            method.Invoke(vc.csObj, arr_t);
        }
        return true;
    }
    public static MethodID methodID2 = new MethodID("PrintName", "Void", TypeFlag.None, null, null);
    static bool TestGenericA3_PrintName(JSVCall vc, int argc)
    {
        // Get generic method by name and param count.
        MethodInfo method = GenericTypeCache.getMethod(vc.csObj.GetType(), methodID2);
        if (method == null)
            return true;
         
        int len = argc;
        if (len == 0)
        {
            object[] arr_t = null;
            method.Invoke(vc.csObj, arr_t);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(jsb.Test.Framwork.TestGeneric<,,>);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(TestGenericA3_TestGenericA3, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(TestGenericA3_Compare__CompareFunc_T_J_K, "Compare"),
            new JSMgr.MethodCallBackInfo(TestGenericA3_HelloT2, "Hello"),
            new JSMgr.MethodCallBackInfo(TestGenericA3_PrintName, "PrintName"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}