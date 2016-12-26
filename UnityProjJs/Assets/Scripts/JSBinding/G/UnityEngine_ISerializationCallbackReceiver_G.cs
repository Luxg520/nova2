
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_ISerializationCallbackReceiver_G
{
    ////////////////////// ISerializationCallbackReceiver ///////////////////////////////////////
    // constructors
    // fields
    // properties
    // methods
    static bool ISerializationCallbackReceiver_OnAfterDeserialize(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.ISerializationCallbackReceiver)vc.csObj).OnAfterDeserialize();
        }
        return true;
    }
    static bool ISerializationCallbackReceiver_OnBeforeSerialize(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.ISerializationCallbackReceiver)vc.csObj).OnBeforeSerialize();
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.ISerializationCallbackReceiver);
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
            new JSMgr.MethodCallBackInfo(ISerializationCallbackReceiver_OnAfterDeserialize, "OnAfterDeserialize"),
            new JSMgr.MethodCallBackInfo(ISerializationCallbackReceiver_OnBeforeSerialize, "OnBeforeSerialize"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}