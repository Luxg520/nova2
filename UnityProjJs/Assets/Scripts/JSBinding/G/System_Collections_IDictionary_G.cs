﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class System_Collections_IDictionary_G
{
    ////////////////////// IDictionary ///////////////////////////////////////
    // constructors
    // fields
    // properties
    static void IDictionary_IsFixedSize(JSVCall vc)
    {
        System.Collections.IDictionary _this = (System.Collections.IDictionary)vc.csObj;
        var result = _this.IsFixedSize;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void IDictionary_IsReadOnly(JSVCall vc)
    {
        System.Collections.IDictionary _this = (System.Collections.IDictionary)vc.csObj;
        var result = _this.IsReadOnly;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void IDictionary_Item_Object(JSVCall vc)
    {
        object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
        if (vc.bGet)
        {
            System.Collections.IDictionary _this = (System.Collections.IDictionary)vc.csObj;
            var result = _this[arg0];
            JSMgr.datax.setWhatever((int)JSApi.SetType.Rval, result);
        }
        else
        {
            object arg1 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            System.Collections.IDictionary _this = (System.Collections.IDictionary)vc.csObj;
            _this[arg0] = arg1;
        }
    }
    static void IDictionary_Keys(JSVCall vc)
    {
        System.Collections.IDictionary _this = (System.Collections.IDictionary)vc.csObj;
        var result = _this.Keys;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void IDictionary_Values(JSVCall vc)
    {
        System.Collections.IDictionary _this = (System.Collections.IDictionary)vc.csObj;
        var result = _this.Values;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    // methods
    static bool IDictionary_Add__Object__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            object arg1 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            ((System.Collections.IDictionary)vc.csObj).Add(arg0, arg1);
        }
        return true;
    }
    static bool IDictionary_Clear(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((System.Collections.IDictionary)vc.csObj).Clear();
        }
        return true;
    }
    static bool IDictionary_Contains__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((System.Collections.IDictionary)vc.csObj).Contains(arg0)));
        }
        return true;
    }
    static bool IDictionary_GetEnumerator(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((System.Collections.IDictionary)vc.csObj).GetEnumerator());
        }
        return true;
    }
    static bool IDictionary_Remove__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            ((System.Collections.IDictionary)vc.csObj).Remove(arg0);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(System.Collections.IDictionary);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            IDictionary_IsFixedSize,
            IDictionary_IsReadOnly,
            IDictionary_Item_Object,
            IDictionary_Keys,
            IDictionary_Values,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(IDictionary_Add__Object__Object, "Add"),
            new JSMgr.MethodCallBackInfo(IDictionary_Clear, "Clear"),
            new JSMgr.MethodCallBackInfo(IDictionary_Contains__Object, "Contains"),
            new JSMgr.MethodCallBackInfo(IDictionary_GetEnumerator, "GetEnumerator"),
            new JSMgr.MethodCallBackInfo(IDictionary_Remove__Object, "Remove"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}