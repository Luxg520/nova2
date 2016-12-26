﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Color_G
{
    ////////////////////// Color ///////////////////////////////////////
    // constructors
    public static ConstructorID constructorID0 = new ConstructorID(null, null);
     
    static bool Color_Color(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Color());
        }
        return true;
    }
    static bool Color_Color1(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.addJSCSRel(_this, new UnityEngine.Color(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Color_Color2(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 4)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.addJSCSRel(_this, new UnityEngine.Color(arg0, arg1, arg2, arg3));
        }
        return true;
    }
    // fields
    static void Color_r(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
            var result = _this.r;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
            _this.r = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void Color_g(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
            var result = _this.g;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
            _this.g = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void Color_b(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
            var result = _this.b;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
            _this.b = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void Color_a(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
            var result = _this.a;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
            _this.a = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    // properties
    static void Color_gamma(JSVCall vc)
    {
        UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
        var result = _this.gamma;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Color_grayscale(JSVCall vc)
    {
        UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
        var result = _this.grayscale;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Color_Item_Int32(JSVCall vc)
    {
        int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
        if (vc.bGet)
        {
            UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
            var result = _this[arg0];
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
            _this[arg0] = arg1;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void Color_linear(JSVCall vc)
    {
        UnityEngine.Color _this = (UnityEngine.Color)vc.csObj;
        var result = _this.linear;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Color_black(JSVCall vc)
    {
        var result = UnityEngine.Color.black;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Color_blue(JSVCall vc)
    {
        var result = UnityEngine.Color.blue;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Color_clear(JSVCall vc)
    {
        var result = UnityEngine.Color.clear;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Color_cyan(JSVCall vc)
    {
        var result = UnityEngine.Color.cyan;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Color_gray(JSVCall vc)
    {
        var result = UnityEngine.Color.gray;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Color_green(JSVCall vc)
    {
        var result = UnityEngine.Color.green;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Color_grey(JSVCall vc)
    {
        var result = UnityEngine.Color.grey;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Color_magenta(JSVCall vc)
    {
        var result = UnityEngine.Color.magenta;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Color_red(JSVCall vc)
    {
        var result = UnityEngine.Color.red;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Color_white(JSVCall vc)
    {
        var result = UnityEngine.Color.white;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Color_yellow(JSVCall vc)
    {
        var result = UnityEngine.Color.yellow;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    // methods
    static bool Color_Equals__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            UnityEngine.Color argThis = (UnityEngine.Color)vc.csObj;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(argThis.Equals(arg0)));
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Color_GetHashCode(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            UnityEngine.Color argThis = (UnityEngine.Color)vc.csObj;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(argThis.GetHashCode()));
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Color_ToString(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            UnityEngine.Color argThis = (UnityEngine.Color)vc.csObj;
            JSApi.setStringS((int)JSApi.SetType.Rval, argThis.ToString());
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Color_ToString__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.Color argThis = (UnityEngine.Color)vc.csObj;
            JSApi.setStringS((int)JSApi.SetType.Rval, argThis.ToString(arg0));
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Color_Lerp__Color__Color__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Color arg1 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Color.Lerp(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Color_op_Addition__Color__Color(JSVCall vc, int argc)
    {
        UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Color arg1 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 + arg1);
        return true;
    }
    static bool Color_op_Division__Color__Single(JSVCall vc, int argc)
    {
        UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 / arg1);
        return true;
    }
    static bool Color_op_Equality__Color__Color(JSVCall vc, int argc)
    {
        UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Color arg1 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(arg0 == arg1));
        return true;
    }
    static bool Color_op_Implicit__Vector4_to_Color(JSVCall vc, int argc)
    {
        UnityEngine.Vector4 arg0 = (UnityEngine.Vector4)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, (UnityEngine.Color)arg0);
        return true;
    }
    static bool Color_op_Implicit__Color_to_Vector4(JSVCall vc, int argc)
    {
        UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, (UnityEngine.Vector4)arg0);
        return true;
    }
    static bool Color_op_Inequality__Color__Color(JSVCall vc, int argc)
    {
        UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Color arg1 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(arg0 != arg1));
        return true;
    }
    static bool Color_op_Multiply__Single__Color(JSVCall vc, int argc)
    {
        float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.Color arg1 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 * arg1);
        return true;
    }
    static bool Color_op_Multiply__Color__Single(JSVCall vc, int argc)
    {
        UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 * arg1);
        return true;
    }
    static bool Color_op_Multiply__Color__Color(JSVCall vc, int argc)
    {
        UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Color arg1 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 * arg1);
        return true;
    }
    static bool Color_op_Subtraction__Color__Color(JSVCall vc, int argc)
    {
        UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Color arg1 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 - arg1);
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Color);
        ci.fields = new JSMgr.CSCallbackField[]
        {
            Color_r,
            Color_g,
            Color_b,
            Color_a,
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Color_gamma,
            Color_grayscale,
            Color_Item_Int32,
            Color_linear,
            Color_black,
            Color_blue,
            Color_clear,
            Color_cyan,
            Color_gray,
            Color_green,
            Color_grey,
            Color_magenta,
            Color_red,
            Color_white,
            Color_yellow,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Color_Color, ".ctor"),
            new JSMgr.MethodCallBackInfo(Color_Color1, ".ctor"),
            new JSMgr.MethodCallBackInfo(Color_Color2, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Color_Equals__Object, "Equals"),
            new JSMgr.MethodCallBackInfo(Color_GetHashCode, "GetHashCode"),
            new JSMgr.MethodCallBackInfo(Color_ToString, "ToString"),
            new JSMgr.MethodCallBackInfo(Color_ToString__String, "ToString"),
            new JSMgr.MethodCallBackInfo(Color_Lerp__Color__Color__Single, "Lerp"),
            new JSMgr.MethodCallBackInfo(Color_op_Addition__Color__Color, "op_Addition"),
            new JSMgr.MethodCallBackInfo(Color_op_Division__Color__Single, "op_Division"),
            new JSMgr.MethodCallBackInfo(Color_op_Equality__Color__Color, "op_Equality"),
            new JSMgr.MethodCallBackInfo(Color_op_Implicit__Vector4_to_Color, "op_Implicit"),
            new JSMgr.MethodCallBackInfo(Color_op_Implicit__Color_to_Vector4, "op_Implicit"),
            new JSMgr.MethodCallBackInfo(Color_op_Inequality__Color__Color, "op_Inequality"),
            new JSMgr.MethodCallBackInfo(Color_op_Multiply__Single__Color, "op_Multiply"),
            new JSMgr.MethodCallBackInfo(Color_op_Multiply__Color__Single, "op_Multiply"),
            new JSMgr.MethodCallBackInfo(Color_op_Multiply__Color__Color, "op_Multiply"),
            new JSMgr.MethodCallBackInfo(Color_op_Subtraction__Color__Color, "op_Subtraction"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}