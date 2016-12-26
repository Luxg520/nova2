﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Mathf_G
{
    ////////////////////// Mathf ///////////////////////////////////////
    // constructors
    public static ConstructorID constructorID0 = new ConstructorID(null, null);
     
    static bool Mathf_Mathf(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Mathf());
        }
        return true;
    }
    // fields
    static void Mathf_PI(JSVCall vc)
    {
        var result = UnityEngine.Mathf.PI;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Mathf_Infinity(JSVCall vc)
    {
        var result = UnityEngine.Mathf.Infinity;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Mathf_NegativeInfinity(JSVCall vc)
    {
        var result = UnityEngine.Mathf.NegativeInfinity;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Mathf_Deg2Rad(JSVCall vc)
    {
        var result = UnityEngine.Mathf.Deg2Rad;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Mathf_Rad2Deg(JSVCall vc)
    {
        var result = UnityEngine.Mathf.Rad2Deg;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Mathf_Epsilon(JSVCall vc)
    {
        var result = UnityEngine.Mathf.Epsilon;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    // properties
    // methods
    static bool Mathf_Abs__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Mathf.Abs(arg0)));
        }
        return true;
    }
    static bool Mathf_Abs__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Abs(arg0)));
        }
        return true;
    }
    static bool Mathf_Acos__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Acos(arg0)));
        }
        return true;
    }
    static bool Mathf_Approximately__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Mathf.Approximately(arg0, arg1)));
        }
        return true;
    }
    static bool Mathf_Asin__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Asin(arg0)));
        }
        return true;
    }
    static bool Mathf_Atan__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Atan(arg0)));
        }
        return true;
    }
    static bool Mathf_Atan2__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Atan2(arg0, arg1)));
        }
        return true;
    }
    static bool Mathf_Ceil__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Ceil(arg0)));
        }
        return true;
    }
    static bool Mathf_CeilToInt__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Mathf.CeilToInt(arg0)));
        }
        return true;
    }
    static bool Mathf_Clamp__Int32__Int32__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Mathf.Clamp(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Mathf_Clamp__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Clamp(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Mathf_Clamp01__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Clamp01(arg0)));
        }
        return true;
    }
    static bool Mathf_ClosestPowerOfTwo__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Mathf.ClosestPowerOfTwo(arg0)));
        }
        return true;
    }
    static bool Mathf_Cos__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Cos(arg0)));
        }
        return true;
    }
    static bool Mathf_DeltaAngle__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.DeltaAngle(arg0, arg1)));
        }
        return true;
    }
    static bool Mathf_Exp__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Exp(arg0)));
        }
        return true;
    }
    static bool Mathf_FloatToHalf__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setUInt16((int)JSApi.SetType.Rval, (ushort)(UnityEngine.Mathf.FloatToHalf(arg0)));
        }
        return true;
    }
    static bool Mathf_Floor__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Floor(arg0)));
        }
        return true;
    }
    static bool Mathf_FloorToInt__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Mathf.FloorToInt(arg0)));
        }
        return true;
    }
    static bool Mathf_Gamma__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Gamma(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Mathf_GammaToLinearSpace__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.GammaToLinearSpace(arg0)));
        }
        return true;
    }
    static bool Mathf_HalfToFloat__UInt16(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            ushort arg0 = JSApi.getUInt16((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.HalfToFloat(arg0)));
        }
        return true;
    }
    static bool Mathf_InverseLerp__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.InverseLerp(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Mathf_IsPowerOfTwo__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Mathf.IsPowerOfTwo(arg0)));
        }
        return true;
    }
    static bool Mathf_Lerp__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Lerp(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Mathf_LerpAngle__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.LerpAngle(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Mathf_LerpUnclamped__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.LerpUnclamped(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Mathf_LinearToGammaSpace__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.LinearToGammaSpace(arg0)));
        }
        return true;
    }
    static bool Mathf_Log__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Log(arg0)));
        }
        return true;
    }
    static bool Mathf_Log__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Log(arg0, arg1)));
        }
        return true;
    }
    static bool Mathf_Log10__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Log10(arg0)));
        }
        return true;
    }
    static bool Mathf_Max__Int32__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Mathf.Max(arg0, arg1)));
        }
        return true;
    }
    static bool Mathf_Max__Int32_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int[] arg0 = 
                JSDataExchangeMgr.GetJSArg<int[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new int[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (int)JSApi.getInt32((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Mathf.Max(arg0)));
        }
        return true;
    }
    static bool Mathf_Max__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Max(arg0, arg1)));
        }
        return true;
    }
    static bool Mathf_Max__Single_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
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
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Max(arg0)));
        }
        return true;
    }
    static bool Mathf_Min__Int32__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Mathf.Min(arg0, arg1)));
        }
        return true;
    }
    static bool Mathf_Min__Int32_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int[] arg0 = 
                JSDataExchangeMgr.GetJSArg<int[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new int[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (int)JSApi.getInt32((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Mathf.Min(arg0)));
        }
        return true;
    }
    static bool Mathf_Min__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Min(arg0, arg1)));
        }
        return true;
    }
    static bool Mathf_Min__Single_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
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
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Min(arg0)));
        }
        return true;
    }
    static bool Mathf_MoveTowards__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.MoveTowards(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Mathf_MoveTowardsAngle__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.MoveTowardsAngle(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Mathf_NextPowerOfTwo__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Mathf.NextPowerOfTwo(arg0)));
        }
        return true;
    }
    static bool Mathf_PerlinNoise__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.PerlinNoise(arg0, arg1)));
        }
        return true;
    }
    static bool Mathf_PingPong__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.PingPong(arg0, arg1)));
        }
        return true;
    }
    static bool Mathf_Pow__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Pow(arg0, arg1)));
        }
        return true;
    }
    static bool Mathf_Repeat__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Repeat(arg0, arg1)));
        }
        return true;
    }
    static bool Mathf_Round__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Round(arg0)));
        }
        return true;
    }
    static bool Mathf_RoundToInt__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Mathf.RoundToInt(arg0)));
        }
        return true;
    }
    static bool Mathf_Sign__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Sign(arg0)));
        }
        return true;
    }
    static bool Mathf_Sin__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Sin(arg0)));
        }
        return true;
    }
    static bool Mathf_SmoothDamp__Single__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.getArgIndex();
            float arg2 = (float)JSApi.getSingle((int)JSApi.GetType.ArgRef);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.SmoothDamp(arg0, arg1, ref arg2, arg3)));
            JSApi.setArgIndex(r_arg2);
            JSApi.setSingle((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Mathf_SmoothDamp__Single__Single__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.getArgIndex();
            float arg2 = (float)JSApi.getSingle((int)JSApi.GetType.ArgRef);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.SmoothDamp(arg0, arg1, ref arg2, arg3, arg4)));
            JSApi.setArgIndex(r_arg2);
            JSApi.setSingle((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Mathf_SmoothDamp__Single__Single__Single__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.getArgIndex();
            float arg2 = (float)JSApi.getSingle((int)JSApi.GetType.ArgRef);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.SmoothDamp(arg0, arg1, ref arg2, arg3, arg4, arg5)));
            JSApi.setArgIndex(r_arg2);
            JSApi.setSingle((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Mathf_SmoothDampAngle__Single__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.getArgIndex();
            float arg2 = (float)JSApi.getSingle((int)JSApi.GetType.ArgRef);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.SmoothDampAngle(arg0, arg1, ref arg2, arg3)));
            JSApi.setArgIndex(r_arg2);
            JSApi.setSingle((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Mathf_SmoothDampAngle__Single__Single__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.getArgIndex();
            float arg2 = (float)JSApi.getSingle((int)JSApi.GetType.ArgRef);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.SmoothDampAngle(arg0, arg1, ref arg2, arg3, arg4)));
            JSApi.setArgIndex(r_arg2);
            JSApi.setSingle((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Mathf_SmoothDampAngle__Single__Single__Single__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.getArgIndex();
            float arg2 = (float)JSApi.getSingle((int)JSApi.GetType.ArgRef);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.SmoothDampAngle(arg0, arg1, ref arg2, arg3, arg4, arg5)));
            JSApi.setArgIndex(r_arg2);
            JSApi.setSingle((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Mathf_SmoothStep__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.SmoothStep(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Mathf_Sqrt__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Sqrt(arg0)));
        }
        return true;
    }
    static bool Mathf_Tan__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Mathf.Tan(arg0)));
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Mathf);
        ci.fields = new JSMgr.CSCallbackField[]
        {
            Mathf_PI,
            Mathf_Infinity,
            Mathf_NegativeInfinity,
            Mathf_Deg2Rad,
            Mathf_Rad2Deg,
            Mathf_Epsilon,
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Mathf_Mathf, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Mathf_Abs__Int32, "Abs"),
            new JSMgr.MethodCallBackInfo(Mathf_Abs__Single, "Abs"),
            new JSMgr.MethodCallBackInfo(Mathf_Acos__Single, "Acos"),
            new JSMgr.MethodCallBackInfo(Mathf_Approximately__Single__Single, "Approximately"),
            new JSMgr.MethodCallBackInfo(Mathf_Asin__Single, "Asin"),
            new JSMgr.MethodCallBackInfo(Mathf_Atan__Single, "Atan"),
            new JSMgr.MethodCallBackInfo(Mathf_Atan2__Single__Single, "Atan2"),
            new JSMgr.MethodCallBackInfo(Mathf_Ceil__Single, "Ceil"),
            new JSMgr.MethodCallBackInfo(Mathf_CeilToInt__Single, "CeilToInt"),
            new JSMgr.MethodCallBackInfo(Mathf_Clamp__Int32__Int32__Int32, "Clamp"),
            new JSMgr.MethodCallBackInfo(Mathf_Clamp__Single__Single__Single, "Clamp"),
            new JSMgr.MethodCallBackInfo(Mathf_Clamp01__Single, "Clamp01"),
            new JSMgr.MethodCallBackInfo(Mathf_ClosestPowerOfTwo__Int32, "ClosestPowerOfTwo"),
            new JSMgr.MethodCallBackInfo(Mathf_Cos__Single, "Cos"),
            new JSMgr.MethodCallBackInfo(Mathf_DeltaAngle__Single__Single, "DeltaAngle"),
            new JSMgr.MethodCallBackInfo(Mathf_Exp__Single, "Exp"),
            new JSMgr.MethodCallBackInfo(Mathf_FloatToHalf__Single, "FloatToHalf"),
            new JSMgr.MethodCallBackInfo(Mathf_Floor__Single, "Floor"),
            new JSMgr.MethodCallBackInfo(Mathf_FloorToInt__Single, "FloorToInt"),
            new JSMgr.MethodCallBackInfo(Mathf_Gamma__Single__Single__Single, "Gamma"),
            new JSMgr.MethodCallBackInfo(Mathf_GammaToLinearSpace__Single, "GammaToLinearSpace"),
            new JSMgr.MethodCallBackInfo(Mathf_HalfToFloat__UInt16, "HalfToFloat"),
            new JSMgr.MethodCallBackInfo(Mathf_InverseLerp__Single__Single__Single, "InverseLerp"),
            new JSMgr.MethodCallBackInfo(Mathf_IsPowerOfTwo__Int32, "IsPowerOfTwo"),
            new JSMgr.MethodCallBackInfo(Mathf_Lerp__Single__Single__Single, "Lerp"),
            new JSMgr.MethodCallBackInfo(Mathf_LerpAngle__Single__Single__Single, "LerpAngle"),
            new JSMgr.MethodCallBackInfo(Mathf_LerpUnclamped__Single__Single__Single, "LerpUnclamped"),
            new JSMgr.MethodCallBackInfo(Mathf_LinearToGammaSpace__Single, "LinearToGammaSpace"),
            new JSMgr.MethodCallBackInfo(Mathf_Log__Single, "Log"),
            new JSMgr.MethodCallBackInfo(Mathf_Log__Single__Single, "Log"),
            new JSMgr.MethodCallBackInfo(Mathf_Log10__Single, "Log10"),
            new JSMgr.MethodCallBackInfo(Mathf_Max__Int32__Int32, "Max"),
            new JSMgr.MethodCallBackInfo(Mathf_Max__Int32_Array, "Max"),
            new JSMgr.MethodCallBackInfo(Mathf_Max__Single__Single, "Max"),
            new JSMgr.MethodCallBackInfo(Mathf_Max__Single_Array, "Max"),
            new JSMgr.MethodCallBackInfo(Mathf_Min__Int32__Int32, "Min"),
            new JSMgr.MethodCallBackInfo(Mathf_Min__Int32_Array, "Min"),
            new JSMgr.MethodCallBackInfo(Mathf_Min__Single__Single, "Min"),
            new JSMgr.MethodCallBackInfo(Mathf_Min__Single_Array, "Min"),
            new JSMgr.MethodCallBackInfo(Mathf_MoveTowards__Single__Single__Single, "MoveTowards"),
            new JSMgr.MethodCallBackInfo(Mathf_MoveTowardsAngle__Single__Single__Single, "MoveTowardsAngle"),
            new JSMgr.MethodCallBackInfo(Mathf_NextPowerOfTwo__Int32, "NextPowerOfTwo"),
            new JSMgr.MethodCallBackInfo(Mathf_PerlinNoise__Single__Single, "PerlinNoise"),
            new JSMgr.MethodCallBackInfo(Mathf_PingPong__Single__Single, "PingPong"),
            new JSMgr.MethodCallBackInfo(Mathf_Pow__Single__Single, "Pow"),
            new JSMgr.MethodCallBackInfo(Mathf_Repeat__Single__Single, "Repeat"),
            new JSMgr.MethodCallBackInfo(Mathf_Round__Single, "Round"),
            new JSMgr.MethodCallBackInfo(Mathf_RoundToInt__Single, "RoundToInt"),
            new JSMgr.MethodCallBackInfo(Mathf_Sign__Single, "Sign"),
            new JSMgr.MethodCallBackInfo(Mathf_Sin__Single, "Sin"),
            new JSMgr.MethodCallBackInfo(Mathf_SmoothDamp__Single__Single__Single__Single, "SmoothDamp"),
            new JSMgr.MethodCallBackInfo(Mathf_SmoothDamp__Single__Single__Single__Single__Single, "SmoothDamp"),
            new JSMgr.MethodCallBackInfo(Mathf_SmoothDamp__Single__Single__Single__Single__Single__Single, "SmoothDamp"),
            new JSMgr.MethodCallBackInfo(Mathf_SmoothDampAngle__Single__Single__Single__Single, "SmoothDampAngle"),
            new JSMgr.MethodCallBackInfo(Mathf_SmoothDampAngle__Single__Single__Single__Single__Single, "SmoothDampAngle"),
            new JSMgr.MethodCallBackInfo(Mathf_SmoothDampAngle__Single__Single__Single__Single__Single__Single, "SmoothDampAngle"),
            new JSMgr.MethodCallBackInfo(Mathf_SmoothStep__Single__Single__Single, "SmoothStep"),
            new JSMgr.MethodCallBackInfo(Mathf_Sqrt__Single, "Sqrt"),
            new JSMgr.MethodCallBackInfo(Mathf_Tan__Single, "Tan"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}