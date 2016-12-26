
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine.Events;
using jsval = JSApi.jsval;
public class UnityEngine_Events_UnityEvent_G
{
    ////////////////////// UnityEvent ///////////////////////////////////////
    // constructors
    static bool UnityEvent_UnityEvent(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Events.UnityEvent());
        }
        return true;
    }
    // fields
    // properties
    // methods
    public static UnityEngine.Events.UnityAction UnityEvent_AddListener_GetDelegate_member0_arg0(CSRepresentedObject objFunction)
    {
        if (objFunction == null || objFunction.jsObjID == 0)
            return null;
         
        UnityEngine.Events.UnityAction action = JSMgr.getJSFunCSDelegateRel<UnityEngine.Events.UnityAction>(objFunction.jsObjID);
        if (action != null)
            return action;
         
        action = () => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
        return action;

    }
    static bool UnityEvent_AddListener__UnityAction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Events.UnityAction arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Events.UnityAction>(() => 
                {
                    if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                    {
                        return UnityEvent_AddListener_GetDelegate_member0_arg0(JSApi.getFunctionS((int)JSApi.GetType.Arg));
                    }
                    else
                    {
                        return (UnityEngine.Events.UnityAction)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                    }
                }
                );
            ;
            ((UnityEngine.Events.UnityEvent)vc.csObj).AddListener(arg0);
        }
        return true;
    }
    static bool UnityEvent_Invoke(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Events.UnityEvent)vc.csObj).Invoke();
        }
        return true;
    }
    public static UnityEngine.Events.UnityAction UnityEvent_RemoveListener_GetDelegate_member2_arg0(CSRepresentedObject objFunction)
    {
        if (objFunction == null || objFunction.jsObjID == 0)
            return null;
         
        UnityEngine.Events.UnityAction action = JSMgr.getJSFunCSDelegateRel<UnityEngine.Events.UnityAction>(objFunction.jsObjID);
        if (action != null)
            return action;
         
        action = () => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
        return action;

    }
    static bool UnityEvent_RemoveListener__UnityAction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Events.UnityAction arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Events.UnityAction>(() => 
                {
                    if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                    {
                        return UnityEvent_RemoveListener_GetDelegate_member2_arg0(JSApi.getFunctionS((int)JSApi.GetType.Arg));
                    }
                    else
                    {
                        return (UnityEngine.Events.UnityAction)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                    }
                }
                );
            ;
            ((UnityEngine.Events.UnityEvent)vc.csObj).RemoveListener(arg0);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Events.UnityEvent);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(UnityEvent_UnityEvent, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(UnityEvent_AddListener__UnityAction, "AddListener"),
            new JSMgr.MethodCallBackInfo(UnityEvent_Invoke, "Invoke"),
            new JSMgr.MethodCallBackInfo(UnityEvent_RemoveListener__UnityAction, "RemoveListener"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}