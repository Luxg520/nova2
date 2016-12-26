﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Component_G
{
    ////////////////////// Component ///////////////////////////////////////
    // constructors
    static bool Component_Component(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Component());
        }
        return true;
    }
    // fields
    // properties
    static void Component_gameObject(JSVCall vc)
    {
        UnityEngine.Component _this = (UnityEngine.Component)vc.csObj;
        var result = _this.gameObject;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Component_tag(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Component _this = (UnityEngine.Component)vc.csObj;
            var result = _this.tag;
            JSApi.setStringS((int)JSApi.SetType.Rval, result);
        }
        else
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.Component _this = (UnityEngine.Component)vc.csObj;
            _this.tag = arg0;
        }
    }
    static void Component_transform(JSVCall vc)
    {
        UnityEngine.Component _this = (UnityEngine.Component)vc.csObj;
        var result = _this.transform;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    // methods
    static bool Component_BroadcastMessage__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            ((UnityEngine.Component)vc.csObj).BroadcastMessage(arg0);
        }
        return true;
    }
    static bool Component_BroadcastMessage__String__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object arg1 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            ((UnityEngine.Component)vc.csObj).BroadcastMessage(arg0, arg1);
        }
        return true;
    }
    static bool Component_BroadcastMessage__String__Object__SendMessageOptions(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object arg1 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            UnityEngine.SendMessageOptions arg2 = (UnityEngine.SendMessageOptions)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Component)vc.csObj).BroadcastMessage(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Component_BroadcastMessage__String__SendMessageOptions(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.SendMessageOptions arg1 = (UnityEngine.SendMessageOptions)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Component)vc.csObj).BroadcastMessage(arg0, arg1);
        }
        return true;
    }
    static bool Component_CompareTag__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Component)vc.csObj).CompareTag(arg0)));
        }
        return true;
    }
    public static MethodID methodID5 = new MethodID("GetComponent", "T", TypeFlag.IsT, null, null);
    static bool Component_GetComponentT1(JSVCall vc, int argc)
    {
        UnityEngineManual.Component_GetComponentT1(vc, argc);
        return true;
    }
    static bool Component_GetComponent__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Component)vc.csObj).GetComponent(arg0));
        }
        return true;
    }
    static bool Component_GetComponent__Type(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            System.Type arg0 = (System.Type)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Component)vc.csObj).GetComponent(arg0));
        }
        return true;
    }
    public static MethodID methodID8 = new MethodID("GetComponentInChildren", "T", TypeFlag.IsT, null, null);
    static bool Component_GetComponentInChildrenT1(JSVCall vc, int argc)
    {
        UnityEngineManual.Component_GetComponentInChildrenT1(vc, argc);
        return true;
    }
    public static MethodID methodID9 = new MethodID("GetComponentInChildren", "T", TypeFlag.IsT, new string[]{"Boolean"}, new TypeFlag[]{TypeFlag.None});
    static bool Component_GetComponentInChildrenT1__Boolean(JSVCall vc, int argc)
    {
        // Get generic method by name and param count.
        MethodInfo method = JSDataExchangeMgr.makeGenericMethod(vc.csObj.GetType(), methodID9, 1);
        if (method == null)
            return true;
         
        int len = argc - 1;
        if (len == 1)
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            object[] arr_t = new object[]{arg0};
            JSMgr.datax.setWhatever((int)JSApi.SetType.Rval, method.Invoke(vc.csObj, arr_t));
        }
        return true;
    }
    static bool Component_GetComponentInChildren__Type(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            System.Type arg0 = (System.Type)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Component)vc.csObj).GetComponentInChildren(arg0));
        }
        return true;
    }
    static bool Component_GetComponentInChildren__Type__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            System.Type arg0 = (System.Type)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            bool arg1 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Component)vc.csObj).GetComponentInChildren(arg0, arg1));
        }
        return true;
    }
    public static MethodID methodID12 = new MethodID("GetComponentInParent", "T", TypeFlag.IsT, null, null);
    static bool Component_GetComponentInParentT1(JSVCall vc, int argc)
    {
        UnityEngineManual.Component_GetComponentInParentT1(vc, argc);
        return true;
    }
    static bool Component_GetComponentInParent__Type(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            System.Type arg0 = (System.Type)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Component)vc.csObj).GetComponentInParent(arg0));
        }
        return true;
    }
    public static MethodID methodID14 = new MethodID("GetComponents", "T[]", TypeFlag.None, null, null);
    static bool Component_GetComponentsT1(JSVCall vc, int argc)
    {
        UnityEngineManual.Component_GetComponentsT1(vc, argc);
        return true;
    }
    static bool Component_GetComponents__Type__ListT1_Component(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            System.Type arg0 = (System.Type)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            System.Collections.Generic.List<UnityEngine.Component> arg1 = (System.Collections.Generic.List<UnityEngine.Component>)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Component)vc.csObj).GetComponents(arg0, arg1);
        }
        return true;
    }
    public static MethodID methodID16 = new MethodID("GetComponents", "Void", TypeFlag.None, new string[]{"List`1"}, new TypeFlag[]{TypeFlag.IsGenericType});
    static bool Component_GetComponentsT1__ListT1_T(JSVCall vc, int argc)
    {
        // Get generic method by name and param count.
        MethodInfo method = JSDataExchangeMgr.makeGenericMethod(vc.csObj.GetType(), methodID16, 1);
        if (method == null)
            return true;
         
        int len = argc - 1;
        if (len == 1)
        {
            object arg0 = (object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            object[] arr_t = new object[]{arg0};
            method.Invoke(vc.csObj, arr_t);
        }
        return true;
    }
    static bool Component_GetComponents__Type(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            System.Type arg0 = (System.Type)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Component[])((UnityEngine.Component)vc.csObj).GetComponents(arg0);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    public static MethodID methodID18 = new MethodID("GetComponentsInChildren", "T[]", TypeFlag.None, null, null);
    static bool Component_GetComponentsInChildrenT1(JSVCall vc, int argc)
    {
        UnityEngineManual.Component_GetComponentsInChildrenT1(vc, argc);
        return true;
    }
    public static MethodID methodID19 = new MethodID("GetComponentsInChildren", "T[]", TypeFlag.None, new string[]{"Boolean"}, new TypeFlag[]{TypeFlag.None});
    static bool Component_GetComponentsInChildrenT1__Boolean(JSVCall vc, int argc)
    {
        UnityEngineManual.Component_GetComponentsInChildrenT1__Boolean(vc, argc);
        return true;
    }
    public static MethodID methodID20 = new MethodID("GetComponentsInChildren", "Void", TypeFlag.None, new string[]{"Boolean", "List`1"}, new TypeFlag[]{TypeFlag.None, TypeFlag.IsGenericType});
    static bool Component_GetComponentsInChildrenT1__Boolean__ListT1_T(JSVCall vc, int argc)
    {
        // Get generic method by name and param count.
        MethodInfo method = JSDataExchangeMgr.makeGenericMethod(vc.csObj.GetType(), methodID20, 1);
        if (method == null)
            return true;
         
        int len = argc - 1;
        if (len == 2)
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            object arg1 = (object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            object[] arr_t = new object[]{arg0, arg1};
            method.Invoke(vc.csObj, arr_t);
        }
        return true;
    }
    public static MethodID methodID21 = new MethodID("GetComponentsInChildren", "Void", TypeFlag.None, new string[]{"List`1"}, new TypeFlag[]{TypeFlag.IsGenericType});
    static bool Component_GetComponentsInChildrenT1__ListT1_T(JSVCall vc, int argc)
    {
        // Get generic method by name and param count.
        MethodInfo method = JSDataExchangeMgr.makeGenericMethod(vc.csObj.GetType(), methodID21, 1);
        if (method == null)
            return true;
         
        int len = argc - 1;
        if (len == 1)
        {
            object arg0 = (object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            object[] arr_t = new object[]{arg0};
            method.Invoke(vc.csObj, arr_t);
        }
        return true;
    }
    static bool Component_GetComponentsInChildren__Type(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            System.Type arg0 = (System.Type)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Component[])((UnityEngine.Component)vc.csObj).GetComponentsInChildren(arg0);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Component_GetComponentsInChildren__Type__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            System.Type arg0 = (System.Type)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            bool arg1 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Component[])((UnityEngine.Component)vc.csObj).GetComponentsInChildren(arg0, arg1);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    public static MethodID methodID24 = new MethodID("GetComponentsInParent", "T[]", TypeFlag.None, null, null);
    static bool Component_GetComponentsInParentT1(JSVCall vc, int argc)
    {
        UnityEngineManual.Component_GetComponentsInParentT1(vc, argc);
        return true;
    }
    public static MethodID methodID25 = new MethodID("GetComponentsInParent", "T[]", TypeFlag.None, new string[]{"Boolean"}, new TypeFlag[]{TypeFlag.None});
    static bool Component_GetComponentsInParentT1__Boolean(JSVCall vc, int argc)
    {
        UnityEngineManual.Component_GetComponentsInParentT1__Boolean(vc, argc);
        return true;
    }
    public static MethodID methodID26 = new MethodID("GetComponentsInParent", "Void", TypeFlag.None, new string[]{"Boolean", "List`1"}, new TypeFlag[]{TypeFlag.None, TypeFlag.IsGenericType});
    static bool Component_GetComponentsInParentT1__Boolean__ListT1_T(JSVCall vc, int argc)
    {
        // Get generic method by name and param count.
        MethodInfo method = JSDataExchangeMgr.makeGenericMethod(vc.csObj.GetType(), methodID26, 1);
        if (method == null)
            return true;
         
        int len = argc - 1;
        if (len == 2)
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            object arg1 = (object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            object[] arr_t = new object[]{arg0, arg1};
            method.Invoke(vc.csObj, arr_t);
        }
        return true;
    }
    static bool Component_GetComponentsInParent__Type(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            System.Type arg0 = (System.Type)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Component[])((UnityEngine.Component)vc.csObj).GetComponentsInParent(arg0);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Component_GetComponentsInParent__Type__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            System.Type arg0 = (System.Type)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            bool arg1 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Component[])((UnityEngine.Component)vc.csObj).GetComponentsInParent(arg0, arg1);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Component_SendMessage__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            ((UnityEngine.Component)vc.csObj).SendMessage(arg0);
        }
        return true;
    }
    static bool Component_SendMessage__String__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object arg1 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            ((UnityEngine.Component)vc.csObj).SendMessage(arg0, arg1);
        }
        return true;
    }
    static bool Component_SendMessage__String__Object__SendMessageOptions(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object arg1 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            UnityEngine.SendMessageOptions arg2 = (UnityEngine.SendMessageOptions)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Component)vc.csObj).SendMessage(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Component_SendMessage__String__SendMessageOptions(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.SendMessageOptions arg1 = (UnityEngine.SendMessageOptions)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Component)vc.csObj).SendMessage(arg0, arg1);
        }
        return true;
    }
    static bool Component_SendMessageUpwards__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            ((UnityEngine.Component)vc.csObj).SendMessageUpwards(arg0);
        }
        return true;
    }
    static bool Component_SendMessageUpwards__String__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object arg1 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            ((UnityEngine.Component)vc.csObj).SendMessageUpwards(arg0, arg1);
        }
        return true;
    }
    static bool Component_SendMessageUpwards__String__Object__SendMessageOptions(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object arg1 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            UnityEngine.SendMessageOptions arg2 = (UnityEngine.SendMessageOptions)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Component)vc.csObj).SendMessageUpwards(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Component_SendMessageUpwards__String__SendMessageOptions(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.SendMessageOptions arg1 = (UnityEngine.SendMessageOptions)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Component)vc.csObj).SendMessageUpwards(arg0, arg1);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Component);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Component_gameObject,
            Component_tag,
            Component_transform,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Component_Component, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Component_BroadcastMessage__String, "BroadcastMessage"),
            new JSMgr.MethodCallBackInfo(Component_BroadcastMessage__String__Object, "BroadcastMessage"),
            new JSMgr.MethodCallBackInfo(Component_BroadcastMessage__String__Object__SendMessageOptions, "BroadcastMessage"),
            new JSMgr.MethodCallBackInfo(Component_BroadcastMessage__String__SendMessageOptions, "BroadcastMessage"),
            new JSMgr.MethodCallBackInfo(Component_CompareTag__String, "CompareTag"),
            new JSMgr.MethodCallBackInfo(Component_GetComponentT1, "GetComponent"),
            new JSMgr.MethodCallBackInfo(Component_GetComponent__String, "GetComponent"),
            new JSMgr.MethodCallBackInfo(Component_GetComponent__Type, "GetComponent"),
            new JSMgr.MethodCallBackInfo(Component_GetComponentInChildrenT1, "GetComponentInChildren"),
            new JSMgr.MethodCallBackInfo(Component_GetComponentInChildrenT1__Boolean, "GetComponentInChildren"),
            new JSMgr.MethodCallBackInfo(Component_GetComponentInChildren__Type, "GetComponentInChildren"),
            new JSMgr.MethodCallBackInfo(Component_GetComponentInChildren__Type__Boolean, "GetComponentInChildren"),
            new JSMgr.MethodCallBackInfo(Component_GetComponentInParentT1, "GetComponentInParent"),
            new JSMgr.MethodCallBackInfo(Component_GetComponentInParent__Type, "GetComponentInParent"),
            new JSMgr.MethodCallBackInfo(Component_GetComponentsT1, "GetComponents"),
            new JSMgr.MethodCallBackInfo(Component_GetComponents__Type__ListT1_Component, "GetComponents"),
            new JSMgr.MethodCallBackInfo(Component_GetComponentsT1__ListT1_T, "GetComponents"),
            new JSMgr.MethodCallBackInfo(Component_GetComponents__Type, "GetComponents"),
            new JSMgr.MethodCallBackInfo(Component_GetComponentsInChildrenT1, "GetComponentsInChildren"),
            new JSMgr.MethodCallBackInfo(Component_GetComponentsInChildrenT1__Boolean, "GetComponentsInChildren"),
            new JSMgr.MethodCallBackInfo(Component_GetComponentsInChildrenT1__Boolean__ListT1_T, "GetComponentsInChildren"),
            new JSMgr.MethodCallBackInfo(Component_GetComponentsInChildrenT1__ListT1_T, "GetComponentsInChildren"),
            new JSMgr.MethodCallBackInfo(Component_GetComponentsInChildren__Type, "GetComponentsInChildren"),
            new JSMgr.MethodCallBackInfo(Component_GetComponentsInChildren__Type__Boolean, "GetComponentsInChildren"),
            new JSMgr.MethodCallBackInfo(Component_GetComponentsInParentT1, "GetComponentsInParent"),
            new JSMgr.MethodCallBackInfo(Component_GetComponentsInParentT1__Boolean, "GetComponentsInParent"),
            new JSMgr.MethodCallBackInfo(Component_GetComponentsInParentT1__Boolean__ListT1_T, "GetComponentsInParent"),
            new JSMgr.MethodCallBackInfo(Component_GetComponentsInParent__Type, "GetComponentsInParent"),
            new JSMgr.MethodCallBackInfo(Component_GetComponentsInParent__Type__Boolean, "GetComponentsInParent"),
            new JSMgr.MethodCallBackInfo(Component_SendMessage__String, "SendMessage"),
            new JSMgr.MethodCallBackInfo(Component_SendMessage__String__Object, "SendMessage"),
            new JSMgr.MethodCallBackInfo(Component_SendMessage__String__Object__SendMessageOptions, "SendMessage"),
            new JSMgr.MethodCallBackInfo(Component_SendMessage__String__SendMessageOptions, "SendMessage"),
            new JSMgr.MethodCallBackInfo(Component_SendMessageUpwards__String, "SendMessageUpwards"),
            new JSMgr.MethodCallBackInfo(Component_SendMessageUpwards__String__Object, "SendMessageUpwards"),
            new JSMgr.MethodCallBackInfo(Component_SendMessageUpwards__String__Object__SendMessageOptions, "SendMessageUpwards"),
            new JSMgr.MethodCallBackInfo(Component_SendMessageUpwards__String__SendMessageOptions, "SendMessageUpwards"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}