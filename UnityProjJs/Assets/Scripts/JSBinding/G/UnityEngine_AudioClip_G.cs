
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_AudioClip_G
{
    ////////////////////// AudioClip ///////////////////////////////////////
    // constructors
    static bool AudioClip_AudioClip(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.AudioClip());
        }
        return true;
    }
    // fields
    // properties
    static void AudioClip_channels(JSVCall vc)
    {
        UnityEngine.AudioClip _this = (UnityEngine.AudioClip)vc.csObj;
        var result = _this.channels;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void AudioClip_frequency(JSVCall vc)
    {
        UnityEngine.AudioClip _this = (UnityEngine.AudioClip)vc.csObj;
        var result = _this.frequency;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void AudioClip_isReadyToPlay(JSVCall vc)
    {
        UnityEngine.AudioClip _this = (UnityEngine.AudioClip)vc.csObj;
        var result = _this.isReadyToPlay;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void AudioClip_length(JSVCall vc)
    {
        UnityEngine.AudioClip _this = (UnityEngine.AudioClip)vc.csObj;
        var result = _this.length;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void AudioClip_samples(JSVCall vc)
    {
        UnityEngine.AudioClip _this = (UnityEngine.AudioClip)vc.csObj;
        var result = _this.samples;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    // methods
    static bool AudioClip_GetData__Single_Array__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            float[] arg0 = 
                JSDataExchangeMgr.GetJSArg<float[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new float[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (float)JSApi.getSingle((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.AudioClip)vc.csObj).GetData(arg0, arg1);
        }
        return true;
    }
    static bool AudioClip_SetData__Single_Array__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            float[] arg0 = 
                JSDataExchangeMgr.GetJSArg<float[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new float[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (float)JSApi.getSingle((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.AudioClip)vc.csObj).SetData(arg0, arg1);
        }
        return true;
    }
    static bool AudioClip_Create__String__Int32__Int32__Int32__Boolean__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            bool arg4 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            bool arg5 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.AudioClip.Create(arg0, arg1, arg2, arg3, arg4, arg5));
        }
        return true;
    }
    public static UnityEngine.AudioClip.PCMReaderCallback AudioClip_Create_GetDelegate_member3_arg6(CSRepresentedObject objFunction)
    {
        if (objFunction == null || objFunction.jsObjID == 0)
            return null;
         
        UnityEngine.AudioClip.PCMReaderCallback action = JSMgr.getJSFunCSDelegateRel<UnityEngine.AudioClip.PCMReaderCallback>(objFunction.jsObjID);
        if (action != null)
            return action;
         
        action = (data) => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID, data);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
        return action;

    }
    static bool AudioClip_Create__String__Int32__Int32__Int32__Boolean__Boolean__PCMReaderCallback(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 7)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            bool arg4 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            bool arg5 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.AudioClip.PCMReaderCallback arg6 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.AudioClip.PCMReaderCallback>(() => 
                {
                    if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                    {
                        return AudioClip_Create_GetDelegate_member3_arg6(JSApi.getFunctionS((int)JSApi.GetType.Arg));
                    }
                    else
                    {
                        return (UnityEngine.AudioClip.PCMReaderCallback)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                    }
                }
                );
            ;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.AudioClip.Create(arg0, arg1, arg2, arg3, arg4, arg5, arg6));
        }
        return true;
    }
    public static UnityEngine.AudioClip.PCMReaderCallback AudioClip_Create_GetDelegate_member4_arg6(CSRepresentedObject objFunction)
    {
        if (objFunction == null || objFunction.jsObjID == 0)
            return null;
         
        UnityEngine.AudioClip.PCMReaderCallback action = JSMgr.getJSFunCSDelegateRel<UnityEngine.AudioClip.PCMReaderCallback>(objFunction.jsObjID);
        if (action != null)
            return action;
         
        action = (data) => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID, data);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
        return action;

    }
    public static UnityEngine.AudioClip.PCMSetPositionCallback AudioClip_Create_GetDelegate_member4_arg7(CSRepresentedObject objFunction)
    {
        if (objFunction == null || objFunction.jsObjID == 0)
            return null;
         
        UnityEngine.AudioClip.PCMSetPositionCallback action = JSMgr.getJSFunCSDelegateRel<UnityEngine.AudioClip.PCMSetPositionCallback>(objFunction.jsObjID);
        if (action != null)
            return action;
         
        action = (position) => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID, position);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
        return action;

    }
    static bool AudioClip_Create__String__Int32__Int32__Int32__Boolean__Boolean__PCMReaderCallback__PCMSetPositionCallback(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 8)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            bool arg4 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            bool arg5 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.AudioClip.PCMReaderCallback arg6 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.AudioClip.PCMReaderCallback>(() => 
                {
                    if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                    {
                        return AudioClip_Create_GetDelegate_member4_arg6(JSApi.getFunctionS((int)JSApi.GetType.Arg));
                    }
                    else
                    {
                        return (UnityEngine.AudioClip.PCMReaderCallback)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                    }
                }
                );
            ;
            UnityEngine.AudioClip.PCMSetPositionCallback arg7 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.AudioClip.PCMSetPositionCallback>(() => 
                {
                    if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                    {
                        return AudioClip_Create_GetDelegate_member4_arg7(JSApi.getFunctionS((int)JSApi.GetType.Arg));
                    }
                    else
                    {
                        return (UnityEngine.AudioClip.PCMSetPositionCallback)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                    }
                }
                );
            ;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.AudioClip.Create(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.AudioClip);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            AudioClip_channels,
            AudioClip_frequency,
            AudioClip_isReadyToPlay,
            AudioClip_length,
            AudioClip_samples,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(AudioClip_AudioClip, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(AudioClip_GetData__Single_Array__Int32, "GetData"),
            new JSMgr.MethodCallBackInfo(AudioClip_SetData__Single_Array__Int32, "SetData"),
            new JSMgr.MethodCallBackInfo(AudioClip_Create__String__Int32__Int32__Int32__Boolean__Boolean, "Create"),
            new JSMgr.MethodCallBackInfo(AudioClip_Create__String__Int32__Int32__Int32__Boolean__Boolean__PCMReaderCallback, "Create"),
            new JSMgr.MethodCallBackInfo(AudioClip_Create__String__Int32__Int32__Int32__Boolean__Boolean__PCMReaderCallback__PCMSetPositionCallback, "Create"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}