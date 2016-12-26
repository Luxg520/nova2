
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine.Events;
using jsval = JSApi.jsval;
public class UnityEngine_Events_UnityEventBase_G
{
    ////////////////////// UnityEventBase ///////////////////////////////////////
    // constructors
    // fields
    // properties
    // methods
    static bool UnityEventBase_GetPersistentEventCount(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.Events.UnityEventBase)vc.csObj).GetPersistentEventCount()));
        }
        return true;
    }
    static bool UnityEventBase_GetPersistentMethodName__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setStringS((int)JSApi.SetType.Rval, ((UnityEngine.Events.UnityEventBase)vc.csObj).GetPersistentMethodName(arg0));
        }
        return true;
    }
    static bool UnityEventBase_GetPersistentTarget__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Events.UnityEventBase)vc.csObj).GetPersistentTarget(arg0));
        }
        return true;
    }
    static bool UnityEventBase_RemoveAllListeners(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Events.UnityEventBase)vc.csObj).RemoveAllListeners();
        }
        return true;
    }
    static bool UnityEventBase_SetPersistentListenerState__Int32__UnityEventCallState(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Events.UnityEventCallState arg1 = (UnityEngine.Events.UnityEventCallState)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Events.UnityEventBase)vc.csObj).SetPersistentListenerState(arg0, arg1);
        }
        return true;
    }
    static bool UnityEventBase_ToString(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSApi.setStringS((int)JSApi.SetType.Rval, ((UnityEngine.Events.UnityEventBase)vc.csObj).ToString());
        }
        return true;
    }
    static bool UnityEventBase_GetValidMethodInfo__Object__String__Type_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            string arg1 = JSApi.getStringS((int)JSApi.GetType.Arg);
            System.Type[] arg2 = 
                JSDataExchangeMgr.GetJSArg<System.Type[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new System.Type[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (System.Type)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Events.UnityEventBase.GetValidMethodInfo(arg0, arg1, arg2));
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Events.UnityEventBase);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(UnityEventBase_GetPersistentEventCount, "GetPersistentEventCount"),
            new JSMgr.MethodCallBackInfo(UnityEventBase_GetPersistentMethodName__Int32, "GetPersistentMethodName"),
            new JSMgr.MethodCallBackInfo(UnityEventBase_GetPersistentTarget__Int32, "GetPersistentTarget"),
            new JSMgr.MethodCallBackInfo(UnityEventBase_RemoveAllListeners, "RemoveAllListeners"),
            new JSMgr.MethodCallBackInfo(UnityEventBase_SetPersistentListenerState__Int32__UnityEventCallState, "SetPersistentListenerState"),
            new JSMgr.MethodCallBackInfo(UnityEventBase_ToString, "ToString"),
            new JSMgr.MethodCallBackInfo(UnityEventBase_GetValidMethodInfo__Object__String__Type_Array, "GetValidMethodInfo"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}