
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using jsval = JSApi.jsval;
public class System_Runtime_Serialization_IDeserializationCallback_G
{
    ////////////////////// IDeserializationCallback ///////////////////////////////////////
    // constructors
    // fields
    // properties
    // methods
    static bool IDeserializationCallback_OnDeserialization__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            ((System.Runtime.Serialization.IDeserializationCallback)vc.csObj).OnDeserialization(arg0);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(System.Runtime.Serialization.IDeserializationCallback);
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
            new JSMgr.MethodCallBackInfo(IDeserializationCallback_OnDeserialization__Object, "OnDeserialization"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}