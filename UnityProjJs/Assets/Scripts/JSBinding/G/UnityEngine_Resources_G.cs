
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Resources_G
{
    ////////////////////// Resources ///////////////////////////////////////
    // constructors
    static bool Resources_Resources(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Resources());
        }
        return true;
    }
    // fields
    // properties
    // methods
    public static MethodID methodID0 = new MethodID("FindObjectsOfTypeAll", "T[]", TypeFlag.None, null, null);
    static bool Resources_FindObjectsOfTypeAllT1(JSVCall vc, int argc)
    {
        // Get generic method by name and param count.
        MethodInfo method = JSDataExchangeMgr.makeGenericMethod(typeof(UnityEngine.Resources), methodID0, 1);
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
    static bool Resources_FindObjectsOfTypeAll__Type(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            System.Type arg0 = (System.Type)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Object[])UnityEngine.Resources.FindObjectsOfTypeAll(arg0);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    public static MethodID methodID2 = new MethodID("GetBuiltinResource", "T", TypeFlag.IsT, new string[]{"String"}, new TypeFlag[]{TypeFlag.None});
    static bool Resources_GetBuiltinResourceT1__String(JSVCall vc, int argc)
    {
        // Get generic method by name and param count.
        MethodInfo method = JSDataExchangeMgr.makeGenericMethod(typeof(UnityEngine.Resources), methodID2, 1);
        if (method == null)
            return true;
         
        int len = argc - 1;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object[] arr_t = new object[]{arg0};
            JSMgr.datax.setWhatever((int)JSApi.SetType.Rval, method.Invoke(null, arr_t));
        }
        return true;
    }
    static bool Resources_GetBuiltinResource__Type__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            System.Type arg0 = (System.Type)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            string arg1 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Resources.GetBuiltinResource(arg0, arg1));
        }
        return true;
    }
    public static MethodID methodID4 = new MethodID("Load", "T", TypeFlag.IsT, new string[]{"String"}, new TypeFlag[]{TypeFlag.None});
    static bool Resources_LoadT1__String(JSVCall vc, int argc)
    {
        // Get generic method by name and param count.
        MethodInfo method = JSDataExchangeMgr.makeGenericMethod(typeof(UnityEngine.Resources), methodID4, 1);
        if (method == null)
            return true;
         
        int len = argc - 1;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object[] arr_t = new object[]{arg0};
            JSMgr.datax.setWhatever((int)JSApi.SetType.Rval, method.Invoke(null, arr_t));
        }
        return true;
    }
    static bool Resources_Load__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Resources.Load(arg0));
        }
        return true;
    }
    static bool Resources_Load__String__Type(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            System.Type arg1 = (System.Type)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Resources.Load(arg0, arg1));
        }
        return true;
    }
    public static MethodID methodID7 = new MethodID("LoadAll", "T[]", TypeFlag.None, new string[]{"String"}, new TypeFlag[]{TypeFlag.None});
    static bool Resources_LoadAllT1__String(JSVCall vc, int argc)
    {
        // Get generic method by name and param count.
        MethodInfo method = JSDataExchangeMgr.makeGenericMethod(typeof(UnityEngine.Resources), methodID7, 1);
        if (method == null)
            return true;
         
        int len = argc - 1;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object[] arr_t = new object[]{arg0};
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
    static bool Resources_LoadAll__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Object[])UnityEngine.Resources.LoadAll(arg0);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Resources_LoadAll__String__Type(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            System.Type arg1 = (System.Type)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Object[])UnityEngine.Resources.LoadAll(arg0, arg1);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Resources_LoadAsync__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Resources.LoadAsync(arg0));
        }
        return true;
    }
    static bool Resources_LoadAsync__String__Type(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            System.Type arg1 = (System.Type)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Resources.LoadAsync(arg0, arg1));
        }
        return true;
    }
    public static MethodID methodID12 = new MethodID("LoadAsync", "ResourceRequest", TypeFlag.None, new string[]{"String"}, new TypeFlag[]{TypeFlag.None});
    static bool Resources_LoadAsyncT1__String(JSVCall vc, int argc)
    {
        // Get generic method by name and param count.
        MethodInfo method = JSDataExchangeMgr.makeGenericMethod(typeof(UnityEngine.Resources), methodID12, 1);
        if (method == null)
            return true;
         
        int len = argc - 1;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object[] arr_t = new object[]{arg0};
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, method.Invoke(null, arr_t));
        }
        return true;
    }
    static bool Resources_UnloadAsset__UEObject(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Object arg0 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Resources.UnloadAsset(arg0);
        }
        return true;
    }
    static bool Resources_UnloadUnusedAssets(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Resources.UnloadUnusedAssets());
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Resources);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Resources_Resources, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Resources_FindObjectsOfTypeAllT1, "FindObjectsOfTypeAll"),
            new JSMgr.MethodCallBackInfo(Resources_FindObjectsOfTypeAll__Type, "FindObjectsOfTypeAll"),
            new JSMgr.MethodCallBackInfo(Resources_GetBuiltinResourceT1__String, "GetBuiltinResource"),
            new JSMgr.MethodCallBackInfo(Resources_GetBuiltinResource__Type__String, "GetBuiltinResource"),
            new JSMgr.MethodCallBackInfo(Resources_LoadT1__String, "Load"),
            new JSMgr.MethodCallBackInfo(Resources_Load__String, "Load"),
            new JSMgr.MethodCallBackInfo(Resources_Load__String__Type, "Load"),
            new JSMgr.MethodCallBackInfo(Resources_LoadAllT1__String, "LoadAll"),
            new JSMgr.MethodCallBackInfo(Resources_LoadAll__String, "LoadAll"),
            new JSMgr.MethodCallBackInfo(Resources_LoadAll__String__Type, "LoadAll"),
            new JSMgr.MethodCallBackInfo(Resources_LoadAsync__String, "LoadAsync"),
            new JSMgr.MethodCallBackInfo(Resources_LoadAsync__String__Type, "LoadAsync"),
            new JSMgr.MethodCallBackInfo(Resources_LoadAsyncT1__String, "LoadAsync"),
            new JSMgr.MethodCallBackInfo(Resources_UnloadAsset__UEObject, "UnloadAsset"),
            new JSMgr.MethodCallBackInfo(Resources_UnloadUnusedAssets, "UnloadUnusedAssets"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}