﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class System_Collections_Hashtable_G
{
    ////////////////////// Hashtable ///////////////////////////////////////
    // constructors
    static bool Hashtable_Hashtable(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new System.Collections.Hashtable());
        }
        return true;
    }
    static bool Hashtable_Hashtable1(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 1)
        {
            System.Collections.IDictionary arg0 = (System.Collections.IDictionary)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.addJSCSRel(_this, new System.Collections.Hashtable(arg0));
        }
        return true;
    }
    static bool Hashtable_Hashtable2(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 2)
        {
            System.Collections.IDictionary arg0 = (System.Collections.IDictionary)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            System.Collections.IEqualityComparer arg1 = (System.Collections.IEqualityComparer)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.addJSCSRel(_this, new System.Collections.Hashtable(arg0, arg1));
        }
        return true;
    }
    static bool Hashtable_Hashtable3(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 2)
        {
            System.Collections.IDictionary arg0 = (System.Collections.IDictionary)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.addJSCSRel(_this, new System.Collections.Hashtable(arg0, arg1));
        }
        return true;
    }
    static bool Hashtable_Hashtable4(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 3)
        {
            System.Collections.IDictionary arg0 = (System.Collections.IDictionary)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            System.Collections.IEqualityComparer arg2 = (System.Collections.IEqualityComparer)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.addJSCSRel(_this, new System.Collections.Hashtable(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Hashtable_Hashtable5(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 1)
        {
            System.Collections.IEqualityComparer arg0 = (System.Collections.IEqualityComparer)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.addJSCSRel(_this, new System.Collections.Hashtable(arg0));
        }
        return true;
    }
    static bool Hashtable_Hashtable6(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSMgr.addJSCSRel(_this, new System.Collections.Hashtable(arg0));
        }
        return true;
    }
    static bool Hashtable_Hashtable7(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            System.Collections.IEqualityComparer arg1 = (System.Collections.IEqualityComparer)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.addJSCSRel(_this, new System.Collections.Hashtable(arg0, arg1));
        }
        return true;
    }
    static bool Hashtable_Hashtable8(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.addJSCSRel(_this, new System.Collections.Hashtable(arg0, arg1));
        }
        return true;
    }
    static bool Hashtable_Hashtable9(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 3)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            System.Collections.IEqualityComparer arg2 = (System.Collections.IEqualityComparer)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.addJSCSRel(_this, new System.Collections.Hashtable(arg0, arg1, arg2));
        }
        return true;
    }
    // fields
    // properties
    static void Hashtable_Count(JSVCall vc)
    {
        System.Collections.Hashtable _this = (System.Collections.Hashtable)vc.csObj;
        var result = _this.Count;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Hashtable_IsFixedSize(JSVCall vc)
    {
        System.Collections.Hashtable _this = (System.Collections.Hashtable)vc.csObj;
        var result = _this.IsFixedSize;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Hashtable_IsReadOnly(JSVCall vc)
    {
        System.Collections.Hashtable _this = (System.Collections.Hashtable)vc.csObj;
        var result = _this.IsReadOnly;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Hashtable_IsSynchronized(JSVCall vc)
    {
        System.Collections.Hashtable _this = (System.Collections.Hashtable)vc.csObj;
        var result = _this.IsSynchronized;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Hashtable_Item_Object(JSVCall vc)
    {
        object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
        if (vc.bGet)
        {
            System.Collections.Hashtable _this = (System.Collections.Hashtable)vc.csObj;
            var result = _this[arg0];
            JSMgr.datax.setWhatever((int)JSApi.SetType.Rval, result);
        }
        else
        {
            object arg1 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            System.Collections.Hashtable _this = (System.Collections.Hashtable)vc.csObj;
            _this[arg0] = arg1;
        }
    }
    static void Hashtable_Keys(JSVCall vc)
    {
        System.Collections.Hashtable _this = (System.Collections.Hashtable)vc.csObj;
        var result = _this.Keys;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Hashtable_SyncRoot(JSVCall vc)
    {
        System.Collections.Hashtable _this = (System.Collections.Hashtable)vc.csObj;
        var result = _this.SyncRoot;
        JSMgr.datax.setWhatever((int)JSApi.SetType.Rval, result);
    }
    static void Hashtable_Values(JSVCall vc)
    {
        System.Collections.Hashtable _this = (System.Collections.Hashtable)vc.csObj;
        var result = _this.Values;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    // methods
    static bool Hashtable_Add__Object__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            object arg1 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            ((System.Collections.Hashtable)vc.csObj).Add(arg0, arg1);
        }
        return true;
    }
    static bool Hashtable_Clear(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((System.Collections.Hashtable)vc.csObj).Clear();
        }
        return true;
    }
    static bool Hashtable_Clone(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSMgr.datax.setWhatever((int)JSApi.SetType.Rval, ((System.Collections.Hashtable)vc.csObj).Clone());
        }
        return true;
    }
    static bool Hashtable_Contains__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((System.Collections.Hashtable)vc.csObj).Contains(arg0)));
        }
        return true;
    }
    static bool Hashtable_ContainsKey__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((System.Collections.Hashtable)vc.csObj).ContainsKey(arg0)));
        }
        return true;
    }
    static bool Hashtable_ContainsValue__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((System.Collections.Hashtable)vc.csObj).ContainsValue(arg0)));
        }
        return true;
    }
    static bool Hashtable_CopyTo__Array__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            System.Array arg0 = (System.Array)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((System.Collections.Hashtable)vc.csObj).CopyTo(arg0, arg1);
        }
        return true;
    }
    static bool Hashtable_GetEnumerator(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((System.Collections.Hashtable)vc.csObj).GetEnumerator());
        }
        return true;
    }
    static bool Hashtable_GetObjectData__SerializationInfo__StreamingContext(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            System.Runtime.Serialization.SerializationInfo arg0 = (System.Runtime.Serialization.SerializationInfo)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            System.Runtime.Serialization.StreamingContext arg1 = (System.Runtime.Serialization.StreamingContext)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((System.Collections.Hashtable)vc.csObj).GetObjectData(arg0, arg1);
        }
        return true;
    }
    static bool Hashtable_OnDeserialization__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            ((System.Collections.Hashtable)vc.csObj).OnDeserialization(arg0);
        }
        return true;
    }
    static bool Hashtable_Remove__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            ((System.Collections.Hashtable)vc.csObj).Remove(arg0);
        }
        return true;
    }
    static bool Hashtable_Synchronized__Hashtable(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            System.Collections.Hashtable arg0 = (System.Collections.Hashtable)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, System.Collections.Hashtable.Synchronized(arg0));
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(System.Collections.Hashtable);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Hashtable_Count,
            Hashtable_IsFixedSize,
            Hashtable_IsReadOnly,
            Hashtable_IsSynchronized,
            Hashtable_Item_Object,
            Hashtable_Keys,
            Hashtable_SyncRoot,
            Hashtable_Values,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Hashtable_Hashtable, ".ctor"),
            new JSMgr.MethodCallBackInfo(Hashtable_Hashtable1, ".ctor"),
            new JSMgr.MethodCallBackInfo(Hashtable_Hashtable2, ".ctor"),
            new JSMgr.MethodCallBackInfo(Hashtable_Hashtable3, ".ctor"),
            new JSMgr.MethodCallBackInfo(Hashtable_Hashtable4, ".ctor"),
            new JSMgr.MethodCallBackInfo(Hashtable_Hashtable5, ".ctor"),
            new JSMgr.MethodCallBackInfo(Hashtable_Hashtable6, ".ctor"),
            new JSMgr.MethodCallBackInfo(Hashtable_Hashtable7, ".ctor"),
            new JSMgr.MethodCallBackInfo(Hashtable_Hashtable8, ".ctor"),
            new JSMgr.MethodCallBackInfo(Hashtable_Hashtable9, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Hashtable_Add__Object__Object, "Add"),
            new JSMgr.MethodCallBackInfo(Hashtable_Clear, "Clear"),
            new JSMgr.MethodCallBackInfo(Hashtable_Clone, "Clone"),
            new JSMgr.MethodCallBackInfo(Hashtable_Contains__Object, "Contains"),
            new JSMgr.MethodCallBackInfo(Hashtable_ContainsKey__Object, "ContainsKey"),
            new JSMgr.MethodCallBackInfo(Hashtable_ContainsValue__Object, "ContainsValue"),
            new JSMgr.MethodCallBackInfo(Hashtable_CopyTo__Array__Int32, "CopyTo"),
            new JSMgr.MethodCallBackInfo(Hashtable_GetEnumerator, "GetEnumerator"),
            new JSMgr.MethodCallBackInfo(Hashtable_GetObjectData__SerializationInfo__StreamingContext, "GetObjectData"),
            new JSMgr.MethodCallBackInfo(Hashtable_OnDeserialization__Object, "OnDeserialization"),
            new JSMgr.MethodCallBackInfo(Hashtable_Remove__Object, "Remove"),
            new JSMgr.MethodCallBackInfo(Hashtable_Synchronized__Hashtable, "Synchronized"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}