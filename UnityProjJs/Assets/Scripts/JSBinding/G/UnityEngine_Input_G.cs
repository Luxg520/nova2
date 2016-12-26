﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Input_G
{
    ////////////////////// Input ///////////////////////////////////////
    // constructors
    static bool Input_Input(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Input());
        }
        return true;
    }
    // fields
    // properties
    static void Input_acceleration(JSVCall vc)
    {
        var result = UnityEngine.Input.acceleration;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Input_accelerationEventCount(JSVCall vc)
    {
        var result = UnityEngine.Input.accelerationEventCount;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Input_accelerationEvents(JSVCall vc)
    {
        var result = UnityEngine.Input.accelerationEvents;
            var arrRet = (UnityEngine.AccelerationEvent[])result;
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }
    static void Input_anyKey(JSVCall vc)
    {
        var result = UnityEngine.Input.anyKey;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Input_anyKeyDown(JSVCall vc)
    {
        var result = UnityEngine.Input.anyKeyDown;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Input_backButtonLeavesApp(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Input.backButtonLeavesApp;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Input.backButtonLeavesApp = arg0;
        }
    }
    static void Input_compass(JSVCall vc)
    {
        var result = UnityEngine.Input.compass;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Input_compensateSensors(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Input.compensateSensors;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Input.compensateSensors = arg0;
        }
    }
    static void Input_compositionCursorPos(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Input.compositionCursorPos;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Input.compositionCursorPos = arg0;
        }
    }
    static void Input_compositionString(JSVCall vc)
    {
        var result = UnityEngine.Input.compositionString;
        JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    static void Input_deviceOrientation(JSVCall vc)
    {
        var result = UnityEngine.Input.deviceOrientation;
        JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    static void Input_gyro(JSVCall vc)
    {
        var result = UnityEngine.Input.gyro;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Input_imeCompositionMode(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Input.imeCompositionMode;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.IMECompositionMode arg0 = (UnityEngine.IMECompositionMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Input.imeCompositionMode = arg0;
        }
    }
    static void Input_imeIsSelected(JSVCall vc)
    {
        var result = UnityEngine.Input.imeIsSelected;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Input_inputString(JSVCall vc)
    {
        var result = UnityEngine.Input.inputString;
        JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    static void Input_location(JSVCall vc)
    {
        var result = UnityEngine.Input.location;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Input_mousePosition(JSVCall vc)
    {
        var result = UnityEngine.Input.mousePosition;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Input_mousePresent(JSVCall vc)
    {
        var result = UnityEngine.Input.mousePresent;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Input_mouseScrollDelta(JSVCall vc)
    {
        var result = UnityEngine.Input.mouseScrollDelta;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Input_multiTouchEnabled(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Input.multiTouchEnabled;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Input.multiTouchEnabled = arg0;
        }
    }
    static void Input_simulateMouseWithTouches(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Input.simulateMouseWithTouches;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Input.simulateMouseWithTouches = arg0;
        }
    }
    static void Input_stylusTouchSupported(JSVCall vc)
    {
        var result = UnityEngine.Input.stylusTouchSupported;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Input_touchCount(JSVCall vc)
    {
        var result = UnityEngine.Input.touchCount;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Input_touches(JSVCall vc)
    {
        var result = UnityEngine.Input.touches;
            var arrRet = (UnityEngine.Touch[])result;
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }
    static void Input_touchPressureSupported(JSVCall vc)
    {
        var result = UnityEngine.Input.touchPressureSupported;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Input_touchSupported(JSVCall vc)
    {
        var result = UnityEngine.Input.touchSupported;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    // methods
    static bool Input_GetAccelerationEvent__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Input.GetAccelerationEvent(arg0));
        }
        return true;
    }
    static bool Input_GetAxis__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Input.GetAxis(arg0)));
        }
        return true;
    }
    static bool Input_GetAxisRaw__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Input.GetAxisRaw(arg0)));
        }
        return true;
    }
    static bool Input_GetButton__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Input.GetButton(arg0)));
        }
        return true;
    }
    static bool Input_GetButtonDown__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Input.GetButtonDown(arg0)));
        }
        return true;
    }
    static bool Input_GetButtonUp__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Input.GetButtonUp(arg0)));
        }
        return true;
    }
    static bool Input_GetJoystickNames(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
                var arrRet = (string[])UnityEngine.Input.GetJoystickNames();
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSApi.setStringS((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Input_GetKey__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Input.GetKey(arg0)));
        }
        return true;
    }
    static bool Input_GetKey__KeyCode(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.KeyCode arg0 = (UnityEngine.KeyCode)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Input.GetKey(arg0)));
        }
        return true;
    }
    static bool Input_GetKeyDown__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Input.GetKeyDown(arg0)));
        }
        return true;
    }
    static bool Input_GetKeyDown__KeyCode(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.KeyCode arg0 = (UnityEngine.KeyCode)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Input.GetKeyDown(arg0)));
        }
        return true;
    }
    static bool Input_GetKeyUp__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Input.GetKeyUp(arg0)));
        }
        return true;
    }
    static bool Input_GetKeyUp__KeyCode(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.KeyCode arg0 = (UnityEngine.KeyCode)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Input.GetKeyUp(arg0)));
        }
        return true;
    }
    static bool Input_GetMouseButton__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Input.GetMouseButton(arg0)));
        }
        return true;
    }
    static bool Input_GetMouseButtonDown__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Input.GetMouseButtonDown(arg0)));
        }
        return true;
    }
    static bool Input_GetMouseButtonUp__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Input.GetMouseButtonUp(arg0)));
        }
        return true;
    }
    static bool Input_GetTouch__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Input.GetTouch(arg0));
        }
        return true;
    }
    static bool Input_ResetInputAxes(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            UnityEngine.Input.ResetInputAxes();
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Input);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Input_acceleration,
            Input_accelerationEventCount,
            Input_accelerationEvents,
            Input_anyKey,
            Input_anyKeyDown,
            Input_backButtonLeavesApp,
            Input_compass,
            Input_compensateSensors,
            Input_compositionCursorPos,
            Input_compositionString,
            Input_deviceOrientation,
            Input_gyro,
            Input_imeCompositionMode,
            Input_imeIsSelected,
            Input_inputString,
            Input_location,
            Input_mousePosition,
            Input_mousePresent,
            Input_mouseScrollDelta,
            Input_multiTouchEnabled,
            Input_simulateMouseWithTouches,
            Input_stylusTouchSupported,
            Input_touchCount,
            Input_touches,
            Input_touchPressureSupported,
            Input_touchSupported,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Input_Input, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Input_GetAccelerationEvent__Int32, "GetAccelerationEvent"),
            new JSMgr.MethodCallBackInfo(Input_GetAxis__String, "GetAxis"),
            new JSMgr.MethodCallBackInfo(Input_GetAxisRaw__String, "GetAxisRaw"),
            new JSMgr.MethodCallBackInfo(Input_GetButton__String, "GetButton"),
            new JSMgr.MethodCallBackInfo(Input_GetButtonDown__String, "GetButtonDown"),
            new JSMgr.MethodCallBackInfo(Input_GetButtonUp__String, "GetButtonUp"),
            new JSMgr.MethodCallBackInfo(Input_GetJoystickNames, "GetJoystickNames"),
            new JSMgr.MethodCallBackInfo(Input_GetKey__String, "GetKey"),
            new JSMgr.MethodCallBackInfo(Input_GetKey__KeyCode, "GetKey"),
            new JSMgr.MethodCallBackInfo(Input_GetKeyDown__String, "GetKeyDown"),
            new JSMgr.MethodCallBackInfo(Input_GetKeyDown__KeyCode, "GetKeyDown"),
            new JSMgr.MethodCallBackInfo(Input_GetKeyUp__String, "GetKeyUp"),
            new JSMgr.MethodCallBackInfo(Input_GetKeyUp__KeyCode, "GetKeyUp"),
            new JSMgr.MethodCallBackInfo(Input_GetMouseButton__Int32, "GetMouseButton"),
            new JSMgr.MethodCallBackInfo(Input_GetMouseButtonDown__Int32, "GetMouseButtonDown"),
            new JSMgr.MethodCallBackInfo(Input_GetMouseButtonUp__Int32, "GetMouseButtonUp"),
            new JSMgr.MethodCallBackInfo(Input_GetTouch__Int32, "GetTouch"),
            new JSMgr.MethodCallBackInfo(Input_ResetInputAxes, "ResetInputAxes"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}