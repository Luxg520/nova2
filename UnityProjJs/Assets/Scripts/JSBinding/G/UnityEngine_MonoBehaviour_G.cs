﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_MonoBehaviour_G
{
    ////////////////////// MonoBehaviour ///////////////////////////////////////
    // constructors
    static bool MonoBehaviour_MonoBehaviour(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.MonoBehaviour());
        }
        return true;
    }
    // fields
    // properties
    static void MonoBehaviour_useGUILayout(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.MonoBehaviour _this = (UnityEngine.MonoBehaviour)vc.csObj;
            var result = _this.useGUILayout;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.MonoBehaviour _this = (UnityEngine.MonoBehaviour)vc.csObj;
            _this.useGUILayout = arg0;
        }
    }
    // methods
    static bool MonoBehaviour_CancelInvoke(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.MonoBehaviour)vc.csObj).CancelInvoke();
        }
        return true;
    }
    static bool MonoBehaviour_CancelInvoke__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            ((UnityEngine.MonoBehaviour)vc.csObj).CancelInvoke(arg0);
        }
        return true;
    }
    static bool MonoBehaviour_Invoke__String__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.MonoBehaviour)vc.csObj).Invoke(arg0, arg1);
        }
        return true;
    }
    static bool MonoBehaviour_InvokeRepeating__String__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.MonoBehaviour)vc.csObj).InvokeRepeating(arg0, arg1, arg2);
        }
        return true;
    }
    static bool MonoBehaviour_IsInvoking(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.MonoBehaviour)vc.csObj).IsInvoking()));
        }
        return true;
    }
    static bool MonoBehaviour_IsInvoking__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.MonoBehaviour)vc.csObj).IsInvoking(arg0)));
        }
        return true;
    }
    static bool MonoBehaviour_StartCoroutine__IEnumerator(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            System.Collections.IEnumerator arg0 = (System.Collections.IEnumerator)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.MonoBehaviour)vc.csObj).StartCoroutine(arg0));
        }
        return true;
    }
    static bool MonoBehaviour_StartCoroutine__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.MonoBehaviour)vc.csObj).StartCoroutine(arg0));
        }
        return true;
    }
    static bool MonoBehaviour_StartCoroutine__String__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object arg1 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.MonoBehaviour)vc.csObj).StartCoroutine(arg0, arg1));
        }
        return true;
    }
    static bool MonoBehaviour_StartCoroutine_Auto__IEnumerator(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            System.Collections.IEnumerator arg0 = (System.Collections.IEnumerator)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.MonoBehaviour)vc.csObj).StartCoroutine_Auto(arg0));
        }
        return true;
    }
    static bool MonoBehaviour_StopAllCoroutines(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.MonoBehaviour)vc.csObj).StopAllCoroutines();
        }
        return true;
    }
    static bool MonoBehaviour_StopCoroutine__IEnumerator(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            System.Collections.IEnumerator arg0 = (System.Collections.IEnumerator)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.MonoBehaviour)vc.csObj).StopCoroutine(arg0);
        }
        return true;
    }
    static bool MonoBehaviour_StopCoroutine__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            ((UnityEngine.MonoBehaviour)vc.csObj).StopCoroutine(arg0);
        }
        return true;
    }
    static bool MonoBehaviour_StopCoroutine__Coroutine(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Coroutine arg0 = (UnityEngine.Coroutine)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.MonoBehaviour)vc.csObj).StopCoroutine(arg0);
        }
        return true;
    }
    static bool MonoBehaviour_print__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            UnityEngine.MonoBehaviour.print(arg0);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.MonoBehaviour);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            MonoBehaviour_useGUILayout,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(MonoBehaviour_MonoBehaviour, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(MonoBehaviour_CancelInvoke, "CancelInvoke"),
            new JSMgr.MethodCallBackInfo(MonoBehaviour_CancelInvoke__String, "CancelInvoke"),
            new JSMgr.MethodCallBackInfo(MonoBehaviour_Invoke__String__Single, "Invoke"),
            new JSMgr.MethodCallBackInfo(MonoBehaviour_InvokeRepeating__String__Single__Single, "InvokeRepeating"),
            new JSMgr.MethodCallBackInfo(MonoBehaviour_IsInvoking, "IsInvoking"),
            new JSMgr.MethodCallBackInfo(MonoBehaviour_IsInvoking__String, "IsInvoking"),
            new JSMgr.MethodCallBackInfo(MonoBehaviour_StartCoroutine__IEnumerator, "StartCoroutine"),
            new JSMgr.MethodCallBackInfo(MonoBehaviour_StartCoroutine__String, "StartCoroutine"),
            new JSMgr.MethodCallBackInfo(MonoBehaviour_StartCoroutine__String__Object, "StartCoroutine"),
            new JSMgr.MethodCallBackInfo(MonoBehaviour_StartCoroutine_Auto__IEnumerator, "StartCoroutine_Auto"),
            new JSMgr.MethodCallBackInfo(MonoBehaviour_StopAllCoroutines, "StopAllCoroutines"),
            new JSMgr.MethodCallBackInfo(MonoBehaviour_StopCoroutine__IEnumerator, "StopCoroutine"),
            new JSMgr.MethodCallBackInfo(MonoBehaviour_StopCoroutine__String, "StopCoroutine"),
            new JSMgr.MethodCallBackInfo(MonoBehaviour_StopCoroutine__Coroutine, "StopCoroutine"),
            new JSMgr.MethodCallBackInfo(MonoBehaviour_print__Object, "print"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}