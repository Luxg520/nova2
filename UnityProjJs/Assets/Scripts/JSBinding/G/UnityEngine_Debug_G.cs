
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Debug_G
{
    ////////////////////// Debug ///////////////////////////////////////
    // constructors
    static bool Debug_Debug(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Debug());
        }
        return true;
    }
    // fields
    // properties
    static void Debug_developerConsoleVisible(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Debug.developerConsoleVisible;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Debug.developerConsoleVisible = arg0;
        }
    }
    static void Debug_isDebugBuild(JSVCall vc)
    {
        var result = UnityEngine.Debug.isDebugBuild;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Debug_logger(JSVCall vc)
    {
        var result = UnityEngine.Debug.logger;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    // methods
    static bool Debug_Assert__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Debug.Assert(arg0);
        }
        return true;
    }
    static bool Debug_Assert__Boolean__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            object arg1 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            UnityEngine.Debug.Assert(arg0, arg1);
        }
        return true;
    }
    static bool Debug_Assert__Boolean__Object__UEObject(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            object arg1 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            UnityEngine.Object arg2 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Debug.Assert(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Debug_Assert__Boolean__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            string arg1 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.Debug.Assert(arg0, arg1);
        }
        return true;
    }
    static bool Debug_Assert__Boolean__String__UEObject(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            string arg1 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.Object arg2 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Debug.Assert(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Debug_Assert__Boolean__UEObject(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Object arg1 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Debug.Assert(arg0, arg1);
        }
        return true;
    }
    static bool Debug_AssertFormat__Boolean__String__Object_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            string arg1 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object[] arg2 = 
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
            UnityEngine.Debug.AssertFormat(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Debug_AssertFormat__Boolean__UEObject__String__Object_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Object arg1 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            string arg2 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object[] arg3 = 
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
            UnityEngine.Debug.AssertFormat(arg0, arg1, arg2, arg3);
        }
        return true;
    }
    static bool Debug_Break(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            UnityEngine.Debug.Break();
        }
        return true;
    }
    static bool Debug_ClearDeveloperConsole(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            UnityEngine.Debug.ClearDeveloperConsole();
        }
        return true;
    }
    static bool Debug_DebugBreak(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            UnityEngine.Debug.DebugBreak();
        }
        return true;
    }
    static bool Debug_DrawLine__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Debug.DrawLine(arg0, arg1);
        }
        return true;
    }
    static bool Debug_DrawLine__Vector3__Vector3__Color(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Color arg2 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Debug.DrawLine(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Debug_DrawLine__Vector3__Vector3__Color__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Color arg2 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Debug.DrawLine(arg0, arg1, arg2, arg3);
        }
        return true;
    }
    static bool Debug_DrawLine__Vector3__Vector3__Color__Single__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Color arg2 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            bool arg4 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Debug.DrawLine(arg0, arg1, arg2, arg3, arg4);
        }
        return true;
    }
    static bool Debug_DrawRay__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Debug.DrawRay(arg0, arg1);
        }
        return true;
    }
    static bool Debug_DrawRay__Vector3__Vector3__Color(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Color arg2 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Debug.DrawRay(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Debug_DrawRay__Vector3__Vector3__Color__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Color arg2 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Debug.DrawRay(arg0, arg1, arg2, arg3);
        }
        return true;
    }
    static bool Debug_DrawRay__Vector3__Vector3__Color__Single__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Color arg2 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            bool arg4 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Debug.DrawRay(arg0, arg1, arg2, arg3, arg4);
        }
        return true;
    }
    static bool Debug_Log__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            UnityEngine.Debug.Log(arg0);
        }
        return true;
    }
    static bool Debug_Log__Object__UEObject(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            UnityEngine.Object arg1 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Debug.Log(arg0, arg1);
        }
        return true;
    }
    static bool Debug_LogAssertion__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            UnityEngine.Debug.LogAssertion(arg0);
        }
        return true;
    }
    static bool Debug_LogAssertion__Object__UEObject(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            UnityEngine.Object arg1 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Debug.LogAssertion(arg0, arg1);
        }
        return true;
    }
    static bool Debug_LogAssertionFormat__String__Object_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object[] arg1 = 
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
            UnityEngine.Debug.LogAssertionFormat(arg0, arg1);
        }
        return true;
    }
    static bool Debug_LogAssertionFormat__UEObject__String__Object_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Object arg0 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            string arg1 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object[] arg2 = 
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
            UnityEngine.Debug.LogAssertionFormat(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Debug_LogError__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            UnityEngine.Debug.LogError(arg0);
        }
        return true;
    }
    static bool Debug_LogError__Object__UEObject(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            UnityEngine.Object arg1 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Debug.LogError(arg0, arg1);
        }
        return true;
    }
    static bool Debug_LogErrorFormat__String__Object_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object[] arg1 = 
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
            UnityEngine.Debug.LogErrorFormat(arg0, arg1);
        }
        return true;
    }
    static bool Debug_LogErrorFormat__UEObject__String__Object_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Object arg0 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            string arg1 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object[] arg2 = 
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
            UnityEngine.Debug.LogErrorFormat(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Debug_LogException__Exception(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            System.Exception arg0 = (System.Exception)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Debug.LogException(arg0);
        }
        return true;
    }
    static bool Debug_LogException__Exception__UEObject(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            System.Exception arg0 = (System.Exception)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Object arg1 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Debug.LogException(arg0, arg1);
        }
        return true;
    }
    static bool Debug_LogFormat__String__Object_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object[] arg1 = 
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
            UnityEngine.Debug.LogFormat(arg0, arg1);
        }
        return true;
    }
    static bool Debug_LogFormat__UEObject__String__Object_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Object arg0 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            string arg1 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object[] arg2 = 
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
            UnityEngine.Debug.LogFormat(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Debug_LogWarning__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            UnityEngine.Debug.LogWarning(arg0);
        }
        return true;
    }
    static bool Debug_LogWarning__Object__UEObject(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            UnityEngine.Object arg1 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Debug.LogWarning(arg0, arg1);
        }
        return true;
    }
    static bool Debug_LogWarningFormat__String__Object_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object[] arg1 = 
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
            UnityEngine.Debug.LogWarningFormat(arg0, arg1);
        }
        return true;
    }
    static bool Debug_LogWarningFormat__UEObject__String__Object_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Object arg0 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            string arg1 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object[] arg2 = 
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
            UnityEngine.Debug.LogWarningFormat(arg0, arg1, arg2);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Debug);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Debug_developerConsoleVisible,
            Debug_isDebugBuild,
            Debug_logger,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Debug_Debug, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Debug_Assert__Boolean, "Assert"),
            new JSMgr.MethodCallBackInfo(Debug_Assert__Boolean__Object, "Assert"),
            new JSMgr.MethodCallBackInfo(Debug_Assert__Boolean__Object__UEObject, "Assert"),
            new JSMgr.MethodCallBackInfo(Debug_Assert__Boolean__String, "Assert"),
            new JSMgr.MethodCallBackInfo(Debug_Assert__Boolean__String__UEObject, "Assert"),
            new JSMgr.MethodCallBackInfo(Debug_Assert__Boolean__UEObject, "Assert"),
            new JSMgr.MethodCallBackInfo(Debug_AssertFormat__Boolean__String__Object_Array, "AssertFormat"),
            new JSMgr.MethodCallBackInfo(Debug_AssertFormat__Boolean__UEObject__String__Object_Array, "AssertFormat"),
            new JSMgr.MethodCallBackInfo(Debug_Break, "Break"),
            new JSMgr.MethodCallBackInfo(Debug_ClearDeveloperConsole, "ClearDeveloperConsole"),
            new JSMgr.MethodCallBackInfo(Debug_DebugBreak, "DebugBreak"),
            new JSMgr.MethodCallBackInfo(Debug_DrawLine__Vector3__Vector3, "DrawLine"),
            new JSMgr.MethodCallBackInfo(Debug_DrawLine__Vector3__Vector3__Color, "DrawLine"),
            new JSMgr.MethodCallBackInfo(Debug_DrawLine__Vector3__Vector3__Color__Single, "DrawLine"),
            new JSMgr.MethodCallBackInfo(Debug_DrawLine__Vector3__Vector3__Color__Single__Boolean, "DrawLine"),
            new JSMgr.MethodCallBackInfo(Debug_DrawRay__Vector3__Vector3, "DrawRay"),
            new JSMgr.MethodCallBackInfo(Debug_DrawRay__Vector3__Vector3__Color, "DrawRay"),
            new JSMgr.MethodCallBackInfo(Debug_DrawRay__Vector3__Vector3__Color__Single, "DrawRay"),
            new JSMgr.MethodCallBackInfo(Debug_DrawRay__Vector3__Vector3__Color__Single__Boolean, "DrawRay"),
            new JSMgr.MethodCallBackInfo(Debug_Log__Object, "Log"),
            new JSMgr.MethodCallBackInfo(Debug_Log__Object__UEObject, "Log"),
            new JSMgr.MethodCallBackInfo(Debug_LogAssertion__Object, "LogAssertion"),
            new JSMgr.MethodCallBackInfo(Debug_LogAssertion__Object__UEObject, "LogAssertion"),
            new JSMgr.MethodCallBackInfo(Debug_LogAssertionFormat__String__Object_Array, "LogAssertionFormat"),
            new JSMgr.MethodCallBackInfo(Debug_LogAssertionFormat__UEObject__String__Object_Array, "LogAssertionFormat"),
            new JSMgr.MethodCallBackInfo(Debug_LogError__Object, "LogError"),
            new JSMgr.MethodCallBackInfo(Debug_LogError__Object__UEObject, "LogError"),
            new JSMgr.MethodCallBackInfo(Debug_LogErrorFormat__String__Object_Array, "LogErrorFormat"),
            new JSMgr.MethodCallBackInfo(Debug_LogErrorFormat__UEObject__String__Object_Array, "LogErrorFormat"),
            new JSMgr.MethodCallBackInfo(Debug_LogException__Exception, "LogException"),
            new JSMgr.MethodCallBackInfo(Debug_LogException__Exception__UEObject, "LogException"),
            new JSMgr.MethodCallBackInfo(Debug_LogFormat__String__Object_Array, "LogFormat"),
            new JSMgr.MethodCallBackInfo(Debug_LogFormat__UEObject__String__Object_Array, "LogFormat"),
            new JSMgr.MethodCallBackInfo(Debug_LogWarning__Object, "LogWarning"),
            new JSMgr.MethodCallBackInfo(Debug_LogWarning__Object__UEObject, "LogWarning"),
            new JSMgr.MethodCallBackInfo(Debug_LogWarningFormat__String__Object_Array, "LogWarningFormat"),
            new JSMgr.MethodCallBackInfo(Debug_LogWarningFormat__UEObject__String__Object_Array, "LogWarningFormat"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}