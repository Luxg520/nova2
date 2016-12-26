
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine.UI;
using jsval = JSApi.jsval;
public class UnityEngine_UI_Button_G
{
    ////////////////////// Button ///////////////////////////////////////
    // constructors
    // fields
    // properties
    static void Button_onClick(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Button _this = (UnityEngine.UI.Button)vc.csObj;
            var result = _this.onClick;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.UI.Button.ButtonClickedEvent arg0 = (UnityEngine.UI.Button.ButtonClickedEvent)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.UI.Button _this = (UnityEngine.UI.Button)vc.csObj;
            _this.onClick = arg0;
        }
    }
    // methods
    static bool Button_OnPointerClick__PointerEventData(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.UI.Button)vc.csObj).OnPointerClick(arg0);
        }
        return true;
    }
    static bool Button_OnSubmit__BaseEventData(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.UI.Button)vc.csObj).OnSubmit(arg0);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.UI.Button);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Button_onClick,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Button_OnPointerClick__PointerEventData, "OnPointerClick"),
            new JSMgr.MethodCallBackInfo(Button_OnSubmit__BaseEventData, "OnSubmit"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}