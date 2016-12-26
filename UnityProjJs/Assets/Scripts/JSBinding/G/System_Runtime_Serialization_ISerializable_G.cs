﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using jsval = JSApi.jsval;
public class System_Runtime_Serialization_ISerializable_G
{
    ////////////////////// ISerializable ///////////////////////////////////////
    // constructors
    // fields
    // properties
    // methods
    static bool ISerializable_GetObjectData__SerializationInfo__StreamingContext(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            System.Runtime.Serialization.SerializationInfo arg0 = (System.Runtime.Serialization.SerializationInfo)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            System.Runtime.Serialization.StreamingContext arg1 = (System.Runtime.Serialization.StreamingContext)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((System.Runtime.Serialization.ISerializable)vc.csObj).GetObjectData(arg0, arg1);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(System.Runtime.Serialization.ISerializable);
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
            new JSMgr.MethodCallBackInfo(ISerializable_GetObjectData__SerializationInfo__StreamingContext, "GetObjectData"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}