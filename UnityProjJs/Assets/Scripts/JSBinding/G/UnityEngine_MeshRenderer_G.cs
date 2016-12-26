﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_MeshRenderer_G
{
    ////////////////////// MeshRenderer ///////////////////////////////////////
    // constructors
    static bool MeshRenderer_MeshRenderer(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.MeshRenderer());
        }
        return true;
    }
    // fields
    // properties
    static void MeshRenderer_additionalVertexStreams(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.MeshRenderer _this = (UnityEngine.MeshRenderer)vc.csObj;
            var result = _this.additionalVertexStreams;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Mesh arg0 = (UnityEngine.Mesh)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.MeshRenderer _this = (UnityEngine.MeshRenderer)vc.csObj;
            _this.additionalVertexStreams = arg0;
        }
    }
    // methods
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.MeshRenderer);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            MeshRenderer_additionalVertexStreams,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(MeshRenderer_MeshRenderer, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}