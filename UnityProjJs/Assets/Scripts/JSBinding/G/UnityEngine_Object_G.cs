
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Object_G
{
    ////////////////////// Object ///////////////////////////////////////
    // constructors
    static bool Object_Object(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Object());
        }
        return true;
    }
    // fields
    // properties
    static void Object_hideFlags(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Object _this = (UnityEngine.Object)vc.csObj;
            var result = _this.hideFlags;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.HideFlags arg0 = (UnityEngine.HideFlags)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Object _this = (UnityEngine.Object)vc.csObj;
            _this.hideFlags = arg0;
        }
    }
    static void Object_name(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Object _this = (UnityEngine.Object)vc.csObj;
            var result = _this.name;
            JSApi.setStringS((int)JSApi.SetType.Rval, result);
        }
        else
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.Object _this = (UnityEngine.Object)vc.csObj;
            _this.name = arg0;
        }
    }
    // methods
    static bool Object_Equals__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Object)vc.csObj).Equals(arg0)));
        }
        return true;
    }
    static bool Object_GetHashCode(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.Object)vc.csObj).GetHashCode()));
        }
        return true;
    }
    static bool Object_GetInstanceID(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.Object)vc.csObj).GetInstanceID()));
        }
        return true;
    }
    static bool Object_ToString(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSApi.setStringS((int)JSApi.SetType.Rval, ((UnityEngine.Object)vc.csObj).ToString());
        }
        return true;
    }
    static bool Object_Destroy__UEObject(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Object arg0 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Object.Destroy(arg0);
        }
        return true;
    }
    static bool Object_Destroy__UEObject__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Object arg0 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Object.Destroy(arg0, arg1);
        }
        return true;
    }
    static bool Object_DestroyImmediate__UEObject(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Object arg0 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Object.DestroyImmediate(arg0);
        }
        return true;
    }
    static bool Object_DestroyImmediate__UEObject__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Object arg0 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            bool arg1 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Object.DestroyImmediate(arg0, arg1);
        }
        return true;
    }
    static bool Object_DestroyObject__UEObject(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Object arg0 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Object.DestroyObject(arg0);
        }
        return true;
    }
    static bool Object_DestroyObject__UEObject__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Object arg0 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Object.DestroyObject(arg0, arg1);
        }
        return true;
    }
    static bool Object_DontDestroyOnLoad__UEObject(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Object arg0 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Object.DontDestroyOnLoad(arg0);
        }
        return true;
    }
    public static MethodID methodID11 = new MethodID("FindObjectOfType", "T", TypeFlag.IsT, null, null);
    static bool Object_FindObjectOfTypeT1(JSVCall vc, int argc)
    {
        // Get generic method by name and param count.
        MethodInfo method = JSDataExchangeMgr.makeGenericMethod(typeof(UnityEngine.Object), methodID11, 1);
        if (method == null)
            return true;
         
        int len = argc - 1;
        if (len == 0)
        {
            object[] arr_t = null;
            JSMgr.datax.setWhatever((int)JSApi.SetType.Rval, method.Invoke(null, arr_t));
        }
        return true;
    }
    static bool Object_FindObjectOfType__Type(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            System.Type arg0 = (System.Type)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Object.FindObjectOfType(arg0));
        }
        return true;
    }
    public static MethodID methodID13 = new MethodID("FindObjectsOfType", "T[]", TypeFlag.None, null, null);
    static bool Object_FindObjectsOfTypeT1(JSVCall vc, int argc)
    {
        // Get generic method by name and param count.
        MethodInfo method = JSDataExchangeMgr.makeGenericMethod(typeof(UnityEngine.Object), methodID13, 1);
        if (method == null)
            return true;
         
        int len = argc - 1;
        if (len == 0)
        {
            object[] arr_t = null;
                var arrRet = (Array)method.Invoke(null, arr_t);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setWhatever((int)JSApi.SetType.SaveAndTempTrace, arrRet.GetValue(i));
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Object_FindObjectsOfType__Type(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            System.Type arg0 = (System.Type)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Object[])UnityEngine.Object.FindObjectsOfType(arg0);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Object_Instantiate__UEObject(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Object arg0 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Object.Instantiate(arg0));
        }
        return true;
    }
    static bool Object_Instantiate__UEObject__Vector3__Quaternion(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Object arg0 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg2 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Object.Instantiate(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Object_op_Equality__UEObject__UEObject(JSVCall vc, int argc)
    {
        UnityEngine.Object arg0 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Object arg1 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(arg0 == arg1));
        return true;
    }
    static bool Object_op_Implicit__UEObject_to_Boolean(JSVCall vc, int argc)
    {
        UnityEngine.Object arg0 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)((bool)arg0));
        return true;
    }
    static bool Object_op_Inequality__UEObject__UEObject(JSVCall vc, int argc)
    {
        UnityEngine.Object arg0 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Object arg1 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(arg0 != arg1));
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Object);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Object_hideFlags,
            Object_name,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Object_Object, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Object_Equals__Object, "Equals"),
            new JSMgr.MethodCallBackInfo(Object_GetHashCode, "GetHashCode"),
            new JSMgr.MethodCallBackInfo(Object_GetInstanceID, "GetInstanceID"),
            new JSMgr.MethodCallBackInfo(Object_ToString, "ToString"),
            new JSMgr.MethodCallBackInfo(Object_Destroy__UEObject, "Destroy"),
            new JSMgr.MethodCallBackInfo(Object_Destroy__UEObject__Single, "Destroy"),
            new JSMgr.MethodCallBackInfo(Object_DestroyImmediate__UEObject, "DestroyImmediate"),
            new JSMgr.MethodCallBackInfo(Object_DestroyImmediate__UEObject__Boolean, "DestroyImmediate"),
            new JSMgr.MethodCallBackInfo(Object_DestroyObject__UEObject, "DestroyObject"),
            new JSMgr.MethodCallBackInfo(Object_DestroyObject__UEObject__Single, "DestroyObject"),
            new JSMgr.MethodCallBackInfo(Object_DontDestroyOnLoad__UEObject, "DontDestroyOnLoad"),
            new JSMgr.MethodCallBackInfo(Object_FindObjectOfTypeT1, "FindObjectOfType"),
            new JSMgr.MethodCallBackInfo(Object_FindObjectOfType__Type, "FindObjectOfType"),
            new JSMgr.MethodCallBackInfo(Object_FindObjectsOfTypeT1, "FindObjectsOfType"),
            new JSMgr.MethodCallBackInfo(Object_FindObjectsOfType__Type, "FindObjectsOfType"),
            new JSMgr.MethodCallBackInfo(Object_Instantiate__UEObject, "Instantiate"),
            new JSMgr.MethodCallBackInfo(Object_Instantiate__UEObject__Vector3__Quaternion, "Instantiate"),
            new JSMgr.MethodCallBackInfo(Object_op_Equality__UEObject__UEObject, "op_Equality"),
            new JSMgr.MethodCallBackInfo(Object_op_Implicit__UEObject_to_Boolean, "op_Implicit"),
            new JSMgr.MethodCallBackInfo(Object_op_Inequality__UEObject__UEObject, "op_Inequality"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}