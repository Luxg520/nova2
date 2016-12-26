﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Physics_G
{
    ////////////////////// Physics ///////////////////////////////////////
    // constructors
    static bool Physics_Physics(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Physics());
        }
        return true;
    }
    // fields
    static void Physics_IgnoreRaycastLayer(JSVCall vc)
    {
        var result = UnityEngine.Physics.IgnoreRaycastLayer;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Physics_DefaultRaycastLayers(JSVCall vc)
    {
        var result = UnityEngine.Physics.DefaultRaycastLayers;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Physics_AllLayers(JSVCall vc)
    {
        var result = UnityEngine.Physics.AllLayers;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    // properties
    static void Physics_bounceThreshold(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics.bounceThreshold;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Physics.bounceThreshold = arg0;
        }
    }
    static void Physics_defaultContactOffset(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics.defaultContactOffset;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Physics.defaultContactOffset = arg0;
        }
    }
    static void Physics_defaultSolverIterations(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics.defaultSolverIterations;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Physics.defaultSolverIterations = arg0;
        }
    }
    static void Physics_defaultSolverVelocityIterations(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics.defaultSolverVelocityIterations;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Physics.defaultSolverVelocityIterations = arg0;
        }
    }
    static void Physics_gravity(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics.gravity;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Physics.gravity = arg0;
        }
    }
    static void Physics_queriesHitTriggers(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics.queriesHitTriggers;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Physics.queriesHitTriggers = arg0;
        }
    }
    static void Physics_sleepThreshold(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics.sleepThreshold;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Physics.sleepThreshold = arg0;
        }
    }
    // methods
    static bool Physics_BoxCast__Vector3__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.BoxCast(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Physics_BoxCast__Vector3__Vector3__Vector3__Quaternion(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg3 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.BoxCast(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics_BoxCast__Vector3__Vector3__Vector3__Quaternion__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg3 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.BoxCast(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics_BoxCast__Vector3__Vector3__Vector3__Quaternion__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg3 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg5 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.BoxCast(arg0, arg1, arg2, arg3, arg4, arg5)));
        }
        return true;
    }
    static bool Physics_BoxCast__Vector3__Vector3__Vector3__Quaternion__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 7)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg3 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg5 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg6 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.BoxCast(arg0, arg1, arg2, arg3, arg4, arg5, arg6)));
        }
        return true;
    }
    static bool Physics_BoxCast__Vector3__Vector3__Vector3__RaycastHit(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg3 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg3;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.BoxCast(arg0, arg1, arg2, out arg3)));
            JSApi.setArgIndex(r_arg3);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg3);
        }
        return true;
    }
    static bool Physics_BoxCast__Vector3__Vector3__Vector3__RaycastHit__Quaternion(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg3 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg3;
            UnityEngine.Quaternion arg4 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.BoxCast(arg0, arg1, arg2, out arg3, arg4)));
            JSApi.setArgIndex(r_arg3);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg3);
        }
        return true;
    }
    static bool Physics_BoxCast__Vector3__Vector3__Vector3__RaycastHit__Quaternion__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg3 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg3;
            UnityEngine.Quaternion arg4 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.BoxCast(arg0, arg1, arg2, out arg3, arg4, arg5)));
            JSApi.setArgIndex(r_arg3);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg3);
        }
        return true;
    }
    static bool Physics_BoxCast__Vector3__Vector3__Vector3__RaycastHit__Quaternion__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 7)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg3 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg3;
            UnityEngine.Quaternion arg4 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg6 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.BoxCast(arg0, arg1, arg2, out arg3, arg4, arg5, arg6)));
            JSApi.setArgIndex(r_arg3);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg3);
        }
        return true;
    }
    static bool Physics_BoxCast__Vector3__Vector3__Vector3__RaycastHit__Quaternion__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 8)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg3 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg3;
            UnityEngine.Quaternion arg4 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg6 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg7 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.BoxCast(arg0, arg1, arg2, out arg3, arg4, arg5, arg6, arg7)));
            JSApi.setArgIndex(r_arg3);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg3);
        }
        return true;
    }
    static bool Physics_BoxCastAll__Vector3__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.BoxCastAll(arg0, arg1, arg2);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_BoxCastAll__Vector3__Vector3__Vector3__Quaternion(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg3 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.BoxCastAll(arg0, arg1, arg2, arg3);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_BoxCastAll__Vector3__Vector3__Vector3__Quaternion__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg3 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.BoxCastAll(arg0, arg1, arg2, arg3, arg4);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_BoxCastAll__Vector3__Vector3__Vector3__Quaternion__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg3 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg5 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.BoxCastAll(arg0, arg1, arg2, arg3, arg4, arg5);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_BoxCastAll__Vector3__Vector3__Vector3__Quaternion__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 7)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg3 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg5 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg6 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.BoxCastAll(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_BoxCastNonAlloc__Vector3__Vector3__Vector3__RaycastHit_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg3 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.BoxCastNonAlloc(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics_BoxCastNonAlloc__Vector3__Vector3__Vector3__RaycastHit_Array__Quaternion(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg3 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            UnityEngine.Quaternion arg4 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.BoxCastNonAlloc(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics_BoxCastNonAlloc__Vector3__Vector3__Vector3__RaycastHit_Array__Quaternion__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg3 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            UnityEngine.Quaternion arg4 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.BoxCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5)));
        }
        return true;
    }
    static bool Physics_BoxCastNonAlloc__Vector3__Vector3__Vector3__RaycastHit_Array__Quaternion__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 7)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg3 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            UnityEngine.Quaternion arg4 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg6 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.BoxCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5, arg6)));
        }
        return true;
    }
    static bool Physics_BoxCastNonAlloc__Vector3__Vector3__Vector3__RaycastHit_Array__Quaternion__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 8)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg3 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            UnityEngine.Quaternion arg4 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg6 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg7 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.BoxCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)));
        }
        return true;
    }
    static bool Physics_CapsuleCast__Vector3__Vector3__Single__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg3 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.CapsuleCast(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics_CapsuleCast__Vector3__Vector3__Single__Vector3__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg3 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.CapsuleCast(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics_CapsuleCast__Vector3__Vector3__Single__Vector3__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg3 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg5 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.CapsuleCast(arg0, arg1, arg2, arg3, arg4, arg5)));
        }
        return true;
    }
    static bool Physics_CapsuleCast__Vector3__Vector3__Single__Vector3__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 7)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg3 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg5 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg6 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.CapsuleCast(arg0, arg1, arg2, arg3, arg4, arg5, arg6)));
        }
        return true;
    }
    static bool Physics_CapsuleCast__Vector3__Vector3__Single__Vector3__RaycastHit(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg3 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg4 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg4;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.CapsuleCast(arg0, arg1, arg2, arg3, out arg4)));
            JSApi.setArgIndex(r_arg4);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg4);
        }
        return true;
    }
    static bool Physics_CapsuleCast__Vector3__Vector3__Single__Vector3__RaycastHit__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg3 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg4 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg4;
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.CapsuleCast(arg0, arg1, arg2, arg3, out arg4, arg5)));
            JSApi.setArgIndex(r_arg4);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg4);
        }
        return true;
    }
    static bool Physics_CapsuleCast__Vector3__Vector3__Single__Vector3__RaycastHit__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 7)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg3 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg4 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg4;
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg6 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.CapsuleCast(arg0, arg1, arg2, arg3, out arg4, arg5, arg6)));
            JSApi.setArgIndex(r_arg4);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg4);
        }
        return true;
    }
    static bool Physics_CapsuleCast__Vector3__Vector3__Single__Vector3__RaycastHit__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 8)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg3 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg4 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg4;
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg6 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg7 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.CapsuleCast(arg0, arg1, arg2, arg3, out arg4, arg5, arg6, arg7)));
            JSApi.setArgIndex(r_arg4);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg4);
        }
        return true;
    }
    static bool Physics_CapsuleCastAll__Vector3__Vector3__Single__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg3 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.CapsuleCastAll(arg0, arg1, arg2, arg3);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_CapsuleCastAll__Vector3__Vector3__Single__Vector3__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg3 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.CapsuleCastAll(arg0, arg1, arg2, arg3, arg4);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_CapsuleCastAll__Vector3__Vector3__Single__Vector3__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg3 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg5 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.CapsuleCastAll(arg0, arg1, arg2, arg3, arg4, arg5);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_CapsuleCastAll__Vector3__Vector3__Single__Vector3__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 7)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg3 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg5 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg6 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.CapsuleCastAll(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_CapsuleCastNonAlloc__Vector3__Vector3__Single__Vector3__RaycastHit_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg3 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg4 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.CapsuleCastNonAlloc(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics_CapsuleCastNonAlloc__Vector3__Vector3__Single__Vector3__RaycastHit_Array__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg3 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg4 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.CapsuleCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5)));
        }
        return true;
    }
    static bool Physics_CapsuleCastNonAlloc__Vector3__Vector3__Single__Vector3__RaycastHit_Array__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 7)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg3 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg4 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg6 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.CapsuleCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5, arg6)));
        }
        return true;
    }
    static bool Physics_CapsuleCastNonAlloc__Vector3__Vector3__Single__Vector3__RaycastHit_Array__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 8)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg3 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg4 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg6 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg7 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.CapsuleCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)));
        }
        return true;
    }
    static bool Physics_CheckBox__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.CheckBox(arg0, arg1)));
        }
        return true;
    }
    static bool Physics_CheckBox__Vector3__Vector3__Quaternion(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg2 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.CheckBox(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Physics_CheckBox__Vector3__Vector3__Quaternion__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg2 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.CheckBox(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics_CheckBox__Vector3__Vector3__Quaternion__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg2 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg4 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.CheckBox(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics_CheckCapsule__Vector3__Vector3__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.CheckCapsule(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Physics_CheckCapsule__Vector3__Vector3__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.CheckCapsule(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics_CheckCapsule__Vector3__Vector3__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg4 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.CheckCapsule(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics_CheckSphere__Vector3__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.CheckSphere(arg0, arg1)));
        }
        return true;
    }
    static bool Physics_CheckSphere__Vector3__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.CheckSphere(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Physics_CheckSphere__Vector3__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg3 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.CheckSphere(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics_GetIgnoreLayerCollision__Int32__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.GetIgnoreLayerCollision(arg0, arg1)));
        }
        return true;
    }
    static bool Physics_IgnoreCollision__Collider__Collider(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Collider arg0 = (UnityEngine.Collider)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider arg1 = (UnityEngine.Collider)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Physics.IgnoreCollision(arg0, arg1);
        }
        return true;
    }
    static bool Physics_IgnoreCollision__Collider__Collider__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Collider arg0 = (UnityEngine.Collider)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider arg1 = (UnityEngine.Collider)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            bool arg2 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Physics.IgnoreCollision(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Physics_IgnoreLayerCollision__Int32__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Physics.IgnoreLayerCollision(arg0, arg1);
        }
        return true;
    }
    static bool Physics_IgnoreLayerCollision__Int32__Int32__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            bool arg2 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Physics.IgnoreLayerCollision(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Physics_Linecast__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Linecast(arg0, arg1)));
        }
        return true;
    }
    static bool Physics_Linecast__Vector3__Vector3__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Linecast(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Physics_Linecast__Vector3__Vector3__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg3 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Linecast(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics_Linecast__Vector3__Vector3__RaycastHit(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg2;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Linecast(arg0, arg1, out arg2)));
            JSApi.setArgIndex(r_arg2);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Physics_Linecast__Vector3__Vector3__RaycastHit__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg2;
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Linecast(arg0, arg1, out arg2, arg3)));
            JSApi.setArgIndex(r_arg2);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Physics_Linecast__Vector3__Vector3__RaycastHit__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg2;
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg4 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Linecast(arg0, arg1, out arg2, arg3, arg4)));
            JSApi.setArgIndex(r_arg2);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Physics_OverlapBox__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider[])UnityEngine.Physics.OverlapBox(arg0, arg1);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_OverlapBox__Vector3__Vector3__Quaternion(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg2 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider[])UnityEngine.Physics.OverlapBox(arg0, arg1, arg2);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_OverlapBox__Vector3__Vector3__Quaternion__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg2 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider[])UnityEngine.Physics.OverlapBox(arg0, arg1, arg2, arg3);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_OverlapBox__Vector3__Vector3__Quaternion__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg2 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg4 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider[])UnityEngine.Physics.OverlapBox(arg0, arg1, arg2, arg3, arg4);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_OverlapBoxNonAlloc__Vector3__Vector3__Collider_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.OverlapBoxNonAlloc(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Physics_OverlapBoxNonAlloc__Vector3__Vector3__Collider_Array__Quaternion(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            UnityEngine.Quaternion arg3 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.OverlapBoxNonAlloc(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics_OverlapBoxNonAlloc__Vector3__Vector3__Collider_Array__Quaternion__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            UnityEngine.Quaternion arg3 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.OverlapBoxNonAlloc(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics_OverlapBoxNonAlloc__Vector3__Vector3__Collider_Array__Quaternion__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            UnityEngine.Quaternion arg3 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg5 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.OverlapBoxNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5)));
        }
        return true;
    }
    static bool Physics_OverlapCapsule__Vector3__Vector3__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider[])UnityEngine.Physics.OverlapCapsule(arg0, arg1, arg2);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_OverlapCapsule__Vector3__Vector3__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider[])UnityEngine.Physics.OverlapCapsule(arg0, arg1, arg2, arg3);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_OverlapCapsule__Vector3__Vector3__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg4 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider[])UnityEngine.Physics.OverlapCapsule(arg0, arg1, arg2, arg3, arg4);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_OverlapCapsuleNonAlloc__Vector3__Vector3__Single__Collider_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Collider[] arg3 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.OverlapCapsuleNonAlloc(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics_OverlapCapsuleNonAlloc__Vector3__Vector3__Single__Collider_Array__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Collider[] arg3 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.OverlapCapsuleNonAlloc(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics_OverlapCapsuleNonAlloc__Vector3__Vector3__Single__Collider_Array__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Collider[] arg3 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg5 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.OverlapCapsuleNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5)));
        }
        return true;
    }
    static bool Physics_OverlapSphere__Vector3__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider[])UnityEngine.Physics.OverlapSphere(arg0, arg1);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_OverlapSphere__Vector3__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider[])UnityEngine.Physics.OverlapSphere(arg0, arg1, arg2);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_OverlapSphere__Vector3__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg3 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider[])UnityEngine.Physics.OverlapSphere(arg0, arg1, arg2, arg3);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_OverlapSphereNonAlloc__Vector3__Single__Collider_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Collider[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.OverlapSphereNonAlloc(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Physics_OverlapSphereNonAlloc__Vector3__Single__Collider_Array__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Collider[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.OverlapSphereNonAlloc(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics_OverlapSphereNonAlloc__Vector3__Single__Collider_Array__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Collider[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg4 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.OverlapSphereNonAlloc(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics_Raycast__Ray(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Raycast(arg0)));
        }
        return true;
    }
    static bool Physics_Raycast__Ray__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Raycast(arg0, arg1)));
        }
        return true;
    }
    static bool Physics_Raycast__Ray__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Raycast(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Physics_Raycast__Ray__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg3 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Raycast(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics_Raycast__Ray__RaycastHit(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg1 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg1;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Raycast(arg0, out arg1)));
            JSApi.setArgIndex(r_arg1);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg1);
        }
        return true;
    }
    static bool Physics_Raycast__Ray__RaycastHit__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg1 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg1;
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Raycast(arg0, out arg1, arg2)));
            JSApi.setArgIndex(r_arg1);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg1);
        }
        return true;
    }
    static bool Physics_Raycast__Ray__RaycastHit__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg1 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg1;
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Raycast(arg0, out arg1, arg2, arg3)));
            JSApi.setArgIndex(r_arg1);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg1);
        }
        return true;
    }
    static bool Physics_Raycast__Ray__RaycastHit__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg1 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg1;
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg4 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Raycast(arg0, out arg1, arg2, arg3, arg4)));
            JSApi.setArgIndex(r_arg1);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg1);
        }
        return true;
    }
    static bool Physics_Raycast__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Raycast(arg0, arg1)));
        }
        return true;
    }
    static bool Physics_Raycast__Vector3__Vector3__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Raycast(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Physics_Raycast__Vector3__Vector3__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Raycast(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics_Raycast__Vector3__Vector3__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg4 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Raycast(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics_Raycast__Vector3__Vector3__RaycastHit(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg2;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Raycast(arg0, arg1, out arg2)));
            JSApi.setArgIndex(r_arg2);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Physics_Raycast__Vector3__Vector3__RaycastHit__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg2;
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Raycast(arg0, arg1, out arg2, arg3)));
            JSApi.setArgIndex(r_arg2);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Physics_Raycast__Vector3__Vector3__RaycastHit__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg2;
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Raycast(arg0, arg1, out arg2, arg3, arg4)));
            JSApi.setArgIndex(r_arg2);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Physics_Raycast__Vector3__Vector3__RaycastHit__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg2;
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg5 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.Raycast(arg0, arg1, out arg2, arg3, arg4, arg5)));
            JSApi.setArgIndex(r_arg2);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Physics_RaycastAll__Ray(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.RaycastAll(arg0);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_RaycastAll__Ray__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.RaycastAll(arg0, arg1);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_RaycastAll__Ray__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.RaycastAll(arg0, arg1, arg2);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_RaycastAll__Ray__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg3 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.RaycastAll(arg0, arg1, arg2, arg3);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_RaycastAll__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.RaycastAll(arg0, arg1);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_RaycastAll__Vector3__Vector3__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.RaycastAll(arg0, arg1, arg2);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_RaycastAll__Vector3__Vector3__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.RaycastAll(arg0, arg1, arg2, arg3);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_RaycastAll__Vector3__Vector3__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg4 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.RaycastAll(arg0, arg1, arg2, arg3, arg4);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_RaycastNonAlloc__Ray__RaycastHit_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg1 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.RaycastNonAlloc(arg0, arg1)));
        }
        return true;
    }
    static bool Physics_RaycastNonAlloc__Ray__RaycastHit_Array__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg1 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.RaycastNonAlloc(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Physics_RaycastNonAlloc__Ray__RaycastHit_Array__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg1 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.RaycastNonAlloc(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics_RaycastNonAlloc__Ray__RaycastHit_Array__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg1 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg4 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.RaycastNonAlloc(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics_RaycastNonAlloc__Vector3__Vector3__RaycastHit_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.RaycastNonAlloc(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Physics_RaycastNonAlloc__Vector3__Vector3__RaycastHit_Array__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.RaycastNonAlloc(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics_RaycastNonAlloc__Vector3__Vector3__RaycastHit_Array__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.RaycastNonAlloc(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics_RaycastNonAlloc__Vector3__Vector3__RaycastHit_Array__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg5 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.RaycastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5)));
        }
        return true;
    }
    static bool Physics_SphereCast__Ray__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.SphereCast(arg0, arg1)));
        }
        return true;
    }
    static bool Physics_SphereCast__Ray__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.SphereCast(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Physics_SphereCast__Ray__Single__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.SphereCast(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics_SphereCast__Ray__Single__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg4 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.SphereCast(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics_SphereCast__Ray__Single__RaycastHit(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg2;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.SphereCast(arg0, arg1, out arg2)));
            JSApi.setArgIndex(r_arg2);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Physics_SphereCast__Ray__Single__RaycastHit__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg2;
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.SphereCast(arg0, arg1, out arg2, arg3)));
            JSApi.setArgIndex(r_arg2);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Physics_SphereCast__Ray__Single__RaycastHit__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg2;
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.SphereCast(arg0, arg1, out arg2, arg3, arg4)));
            JSApi.setArgIndex(r_arg2);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Physics_SphereCast__Ray__Single__RaycastHit__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg2;
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg5 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.SphereCast(arg0, arg1, out arg2, arg3, arg4, arg5)));
            JSApi.setArgIndex(r_arg2);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Physics_SphereCast__Vector3__Single__Vector3__RaycastHit(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg3 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg3;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.SphereCast(arg0, arg1, arg2, out arg3)));
            JSApi.setArgIndex(r_arg3);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg3);
        }
        return true;
    }
    static bool Physics_SphereCast__Vector3__Single__Vector3__RaycastHit__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg3 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg3;
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.SphereCast(arg0, arg1, arg2, out arg3, arg4)));
            JSApi.setArgIndex(r_arg3);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg3);
        }
        return true;
    }
    static bool Physics_SphereCast__Vector3__Single__Vector3__RaycastHit__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg3 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg3;
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg5 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.SphereCast(arg0, arg1, arg2, out arg3, arg4, arg5)));
            JSApi.setArgIndex(r_arg3);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg3);
        }
        return true;
    }
    static bool Physics_SphereCast__Vector3__Single__Vector3__RaycastHit__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 7)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg3 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg3;
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg5 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg6 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics.SphereCast(arg0, arg1, arg2, out arg3, arg4, arg5, arg6)));
            JSApi.setArgIndex(r_arg3);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg3);
        }
        return true;
    }
    static bool Physics_SphereCastAll__Ray__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.SphereCastAll(arg0, arg1);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_SphereCastAll__Ray__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.SphereCastAll(arg0, arg1, arg2);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_SphereCastAll__Ray__Single__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.SphereCastAll(arg0, arg1, arg2, arg3);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_SphereCastAll__Ray__Single__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg4 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.SphereCastAll(arg0, arg1, arg2, arg3, arg4);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_SphereCastAll__Vector3__Single__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.SphereCastAll(arg0, arg1, arg2);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_SphereCastAll__Vector3__Single__Vector3__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.SphereCastAll(arg0, arg1, arg2, arg3);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_SphereCastAll__Vector3__Single__Vector3__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.SphereCastAll(arg0, arg1, arg2, arg3, arg4);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_SphereCastAll__Vector3__Single__Vector3__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg5 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])UnityEngine.Physics.SphereCastAll(arg0, arg1, arg2, arg3, arg4, arg5);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics_SphereCastNonAlloc__Ray__Single__RaycastHit_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.SphereCastNonAlloc(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Physics_SphereCastNonAlloc__Ray__Single__RaycastHit_Array__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.SphereCastNonAlloc(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics_SphereCastNonAlloc__Ray__Single__RaycastHit_Array__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.SphereCastNonAlloc(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics_SphereCastNonAlloc__Ray__Single__RaycastHit_Array__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg5 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.SphereCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5)));
        }
        return true;
    }
    static bool Physics_SphereCastNonAlloc__Vector3__Single__Vector3__RaycastHit_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg3 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.SphereCastNonAlloc(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics_SphereCastNonAlloc__Vector3__Single__Vector3__RaycastHit_Array__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg3 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.SphereCastNonAlloc(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics_SphereCastNonAlloc__Vector3__Single__Vector3__RaycastHit_Array__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg3 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg5 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.SphereCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5)));
        }
        return true;
    }
    static bool Physics_SphereCastNonAlloc__Vector3__Single__Vector3__RaycastHit_Array__Single__Int32__QueryTriggerInteraction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 7)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit[] arg3 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg5 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.QueryTriggerInteraction arg6 = (UnityEngine.QueryTriggerInteraction)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics.SphereCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5, arg6)));
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Physics);
        ci.fields = new JSMgr.CSCallbackField[]
        {
            Physics_IgnoreRaycastLayer,
            Physics_DefaultRaycastLayers,
            Physics_AllLayers,
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Physics_bounceThreshold,
            Physics_defaultContactOffset,
            Physics_defaultSolverIterations,
            Physics_defaultSolverVelocityIterations,
            Physics_gravity,
            Physics_queriesHitTriggers,
            Physics_sleepThreshold,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Physics_Physics, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Physics_BoxCast__Vector3__Vector3__Vector3, "BoxCast"),
            new JSMgr.MethodCallBackInfo(Physics_BoxCast__Vector3__Vector3__Vector3__Quaternion, "BoxCast"),
            new JSMgr.MethodCallBackInfo(Physics_BoxCast__Vector3__Vector3__Vector3__Quaternion__Single, "BoxCast"),
            new JSMgr.MethodCallBackInfo(Physics_BoxCast__Vector3__Vector3__Vector3__Quaternion__Single__Int32, "BoxCast"),
            new JSMgr.MethodCallBackInfo(Physics_BoxCast__Vector3__Vector3__Vector3__Quaternion__Single__Int32__QueryTriggerInteraction, "BoxCast"),
            new JSMgr.MethodCallBackInfo(Physics_BoxCast__Vector3__Vector3__Vector3__RaycastHit, "BoxCast"),
            new JSMgr.MethodCallBackInfo(Physics_BoxCast__Vector3__Vector3__Vector3__RaycastHit__Quaternion, "BoxCast"),
            new JSMgr.MethodCallBackInfo(Physics_BoxCast__Vector3__Vector3__Vector3__RaycastHit__Quaternion__Single, "BoxCast"),
            new JSMgr.MethodCallBackInfo(Physics_BoxCast__Vector3__Vector3__Vector3__RaycastHit__Quaternion__Single__Int32, "BoxCast"),
            new JSMgr.MethodCallBackInfo(Physics_BoxCast__Vector3__Vector3__Vector3__RaycastHit__Quaternion__Single__Int32__QueryTriggerInteraction, "BoxCast"),
            new JSMgr.MethodCallBackInfo(Physics_BoxCastAll__Vector3__Vector3__Vector3, "BoxCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_BoxCastAll__Vector3__Vector3__Vector3__Quaternion, "BoxCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_BoxCastAll__Vector3__Vector3__Vector3__Quaternion__Single, "BoxCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_BoxCastAll__Vector3__Vector3__Vector3__Quaternion__Single__Int32, "BoxCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_BoxCastAll__Vector3__Vector3__Vector3__Quaternion__Single__Int32__QueryTriggerInteraction, "BoxCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_BoxCastNonAlloc__Vector3__Vector3__Vector3__RaycastHit_Array, "BoxCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_BoxCastNonAlloc__Vector3__Vector3__Vector3__RaycastHit_Array__Quaternion, "BoxCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_BoxCastNonAlloc__Vector3__Vector3__Vector3__RaycastHit_Array__Quaternion__Single, "BoxCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_BoxCastNonAlloc__Vector3__Vector3__Vector3__RaycastHit_Array__Quaternion__Single__Int32, "BoxCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_BoxCastNonAlloc__Vector3__Vector3__Vector3__RaycastHit_Array__Quaternion__Single__Int32__QueryTriggerInteraction, "BoxCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCast__Vector3__Vector3__Single__Vector3, "CapsuleCast"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCast__Vector3__Vector3__Single__Vector3__Single, "CapsuleCast"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCast__Vector3__Vector3__Single__Vector3__Single__Int32, "CapsuleCast"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCast__Vector3__Vector3__Single__Vector3__Single__Int32__QueryTriggerInteraction, "CapsuleCast"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCast__Vector3__Vector3__Single__Vector3__RaycastHit, "CapsuleCast"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCast__Vector3__Vector3__Single__Vector3__RaycastHit__Single, "CapsuleCast"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCast__Vector3__Vector3__Single__Vector3__RaycastHit__Single__Int32, "CapsuleCast"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCast__Vector3__Vector3__Single__Vector3__RaycastHit__Single__Int32__QueryTriggerInteraction, "CapsuleCast"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCastAll__Vector3__Vector3__Single__Vector3, "CapsuleCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCastAll__Vector3__Vector3__Single__Vector3__Single, "CapsuleCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCastAll__Vector3__Vector3__Single__Vector3__Single__Int32, "CapsuleCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCastAll__Vector3__Vector3__Single__Vector3__Single__Int32__QueryTriggerInteraction, "CapsuleCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCastNonAlloc__Vector3__Vector3__Single__Vector3__RaycastHit_Array, "CapsuleCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCastNonAlloc__Vector3__Vector3__Single__Vector3__RaycastHit_Array__Single, "CapsuleCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCastNonAlloc__Vector3__Vector3__Single__Vector3__RaycastHit_Array__Single__Int32, "CapsuleCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCastNonAlloc__Vector3__Vector3__Single__Vector3__RaycastHit_Array__Single__Int32__QueryTriggerInteraction, "CapsuleCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_CheckBox__Vector3__Vector3, "CheckBox"),
            new JSMgr.MethodCallBackInfo(Physics_CheckBox__Vector3__Vector3__Quaternion, "CheckBox"),
            new JSMgr.MethodCallBackInfo(Physics_CheckBox__Vector3__Vector3__Quaternion__Int32, "CheckBox"),
            new JSMgr.MethodCallBackInfo(Physics_CheckBox__Vector3__Vector3__Quaternion__Int32__QueryTriggerInteraction, "CheckBox"),
            new JSMgr.MethodCallBackInfo(Physics_CheckCapsule__Vector3__Vector3__Single, "CheckCapsule"),
            new JSMgr.MethodCallBackInfo(Physics_CheckCapsule__Vector3__Vector3__Single__Int32, "CheckCapsule"),
            new JSMgr.MethodCallBackInfo(Physics_CheckCapsule__Vector3__Vector3__Single__Int32__QueryTriggerInteraction, "CheckCapsule"),
            new JSMgr.MethodCallBackInfo(Physics_CheckSphere__Vector3__Single, "CheckSphere"),
            new JSMgr.MethodCallBackInfo(Physics_CheckSphere__Vector3__Single__Int32, "CheckSphere"),
            new JSMgr.MethodCallBackInfo(Physics_CheckSphere__Vector3__Single__Int32__QueryTriggerInteraction, "CheckSphere"),
            new JSMgr.MethodCallBackInfo(Physics_GetIgnoreLayerCollision__Int32__Int32, "GetIgnoreLayerCollision"),
            new JSMgr.MethodCallBackInfo(Physics_IgnoreCollision__Collider__Collider, "IgnoreCollision"),
            new JSMgr.MethodCallBackInfo(Physics_IgnoreCollision__Collider__Collider__Boolean, "IgnoreCollision"),
            new JSMgr.MethodCallBackInfo(Physics_IgnoreLayerCollision__Int32__Int32, "IgnoreLayerCollision"),
            new JSMgr.MethodCallBackInfo(Physics_IgnoreLayerCollision__Int32__Int32__Boolean, "IgnoreLayerCollision"),
            new JSMgr.MethodCallBackInfo(Physics_Linecast__Vector3__Vector3, "Linecast"),
            new JSMgr.MethodCallBackInfo(Physics_Linecast__Vector3__Vector3__Int32, "Linecast"),
            new JSMgr.MethodCallBackInfo(Physics_Linecast__Vector3__Vector3__Int32__QueryTriggerInteraction, "Linecast"),
            new JSMgr.MethodCallBackInfo(Physics_Linecast__Vector3__Vector3__RaycastHit, "Linecast"),
            new JSMgr.MethodCallBackInfo(Physics_Linecast__Vector3__Vector3__RaycastHit__Int32, "Linecast"),
            new JSMgr.MethodCallBackInfo(Physics_Linecast__Vector3__Vector3__RaycastHit__Int32__QueryTriggerInteraction, "Linecast"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapBox__Vector3__Vector3, "OverlapBox"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapBox__Vector3__Vector3__Quaternion, "OverlapBox"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapBox__Vector3__Vector3__Quaternion__Int32, "OverlapBox"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapBox__Vector3__Vector3__Quaternion__Int32__QueryTriggerInteraction, "OverlapBox"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapBoxNonAlloc__Vector3__Vector3__Collider_Array, "OverlapBoxNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapBoxNonAlloc__Vector3__Vector3__Collider_Array__Quaternion, "OverlapBoxNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapBoxNonAlloc__Vector3__Vector3__Collider_Array__Quaternion__Int32, "OverlapBoxNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapBoxNonAlloc__Vector3__Vector3__Collider_Array__Quaternion__Int32__QueryTriggerInteraction, "OverlapBoxNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapCapsule__Vector3__Vector3__Single, "OverlapCapsule"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapCapsule__Vector3__Vector3__Single__Int32, "OverlapCapsule"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapCapsule__Vector3__Vector3__Single__Int32__QueryTriggerInteraction, "OverlapCapsule"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapCapsuleNonAlloc__Vector3__Vector3__Single__Collider_Array, "OverlapCapsuleNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapCapsuleNonAlloc__Vector3__Vector3__Single__Collider_Array__Int32, "OverlapCapsuleNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapCapsuleNonAlloc__Vector3__Vector3__Single__Collider_Array__Int32__QueryTriggerInteraction, "OverlapCapsuleNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapSphere__Vector3__Single, "OverlapSphere"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapSphere__Vector3__Single__Int32, "OverlapSphere"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapSphere__Vector3__Single__Int32__QueryTriggerInteraction, "OverlapSphere"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapSphereNonAlloc__Vector3__Single__Collider_Array, "OverlapSphereNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapSphereNonAlloc__Vector3__Single__Collider_Array__Int32, "OverlapSphereNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapSphereNonAlloc__Vector3__Single__Collider_Array__Int32__QueryTriggerInteraction, "OverlapSphereNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Ray, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Ray__Single, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Ray__Single__Int32, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Ray__Single__Int32__QueryTriggerInteraction, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Ray__RaycastHit, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Ray__RaycastHit__Single, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Ray__RaycastHit__Single__Int32, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Ray__RaycastHit__Single__Int32__QueryTriggerInteraction, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Vector3__Vector3, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Vector3__Vector3__Single, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Vector3__Vector3__Single__Int32, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Vector3__Vector3__Single__Int32__QueryTriggerInteraction, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Vector3__Vector3__RaycastHit, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Vector3__Vector3__RaycastHit__Single, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Vector3__Vector3__RaycastHit__Single__Int32, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Vector3__Vector3__RaycastHit__Single__Int32__QueryTriggerInteraction, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastAll__Ray, "RaycastAll"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastAll__Ray__Single, "RaycastAll"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastAll__Ray__Single__Int32, "RaycastAll"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastAll__Ray__Single__Int32__QueryTriggerInteraction, "RaycastAll"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastAll__Vector3__Vector3, "RaycastAll"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastAll__Vector3__Vector3__Single, "RaycastAll"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastAll__Vector3__Vector3__Single__Int32, "RaycastAll"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastAll__Vector3__Vector3__Single__Int32__QueryTriggerInteraction, "RaycastAll"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastNonAlloc__Ray__RaycastHit_Array, "RaycastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastNonAlloc__Ray__RaycastHit_Array__Single, "RaycastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastNonAlloc__Ray__RaycastHit_Array__Single__Int32, "RaycastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastNonAlloc__Ray__RaycastHit_Array__Single__Int32__QueryTriggerInteraction, "RaycastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastNonAlloc__Vector3__Vector3__RaycastHit_Array, "RaycastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastNonAlloc__Vector3__Vector3__RaycastHit_Array__Single, "RaycastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastNonAlloc__Vector3__Vector3__RaycastHit_Array__Single__Int32, "RaycastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastNonAlloc__Vector3__Vector3__RaycastHit_Array__Single__Int32__QueryTriggerInteraction, "RaycastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCast__Ray__Single, "SphereCast"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCast__Ray__Single__Single, "SphereCast"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCast__Ray__Single__Single__Int32, "SphereCast"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCast__Ray__Single__Single__Int32__QueryTriggerInteraction, "SphereCast"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCast__Ray__Single__RaycastHit, "SphereCast"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCast__Ray__Single__RaycastHit__Single, "SphereCast"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCast__Ray__Single__RaycastHit__Single__Int32, "SphereCast"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCast__Ray__Single__RaycastHit__Single__Int32__QueryTriggerInteraction, "SphereCast"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCast__Vector3__Single__Vector3__RaycastHit, "SphereCast"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCast__Vector3__Single__Vector3__RaycastHit__Single, "SphereCast"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCast__Vector3__Single__Vector3__RaycastHit__Single__Int32, "SphereCast"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCast__Vector3__Single__Vector3__RaycastHit__Single__Int32__QueryTriggerInteraction, "SphereCast"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastAll__Ray__Single, "SphereCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastAll__Ray__Single__Single, "SphereCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastAll__Ray__Single__Single__Int32, "SphereCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastAll__Ray__Single__Single__Int32__QueryTriggerInteraction, "SphereCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastAll__Vector3__Single__Vector3, "SphereCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastAll__Vector3__Single__Vector3__Single, "SphereCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastAll__Vector3__Single__Vector3__Single__Int32, "SphereCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastAll__Vector3__Single__Vector3__Single__Int32__QueryTriggerInteraction, "SphereCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastNonAlloc__Ray__Single__RaycastHit_Array, "SphereCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastNonAlloc__Ray__Single__RaycastHit_Array__Single, "SphereCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastNonAlloc__Ray__Single__RaycastHit_Array__Single__Int32, "SphereCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastNonAlloc__Ray__Single__RaycastHit_Array__Single__Int32__QueryTriggerInteraction, "SphereCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastNonAlloc__Vector3__Single__Vector3__RaycastHit_Array, "SphereCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastNonAlloc__Vector3__Single__Vector3__RaycastHit_Array__Single, "SphereCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastNonAlloc__Vector3__Single__Vector3__RaycastHit_Array__Single__Int32, "SphereCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastNonAlloc__Vector3__Single__Vector3__RaycastHit_Array__Single__Int32__QueryTriggerInteraction, "SphereCastNonAlloc"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}