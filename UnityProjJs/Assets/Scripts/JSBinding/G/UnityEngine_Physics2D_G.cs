﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Physics2D_G
{
    ////////////////////// Physics2D ///////////////////////////////////////
    // constructors
    static bool Physics2D_Physics2D(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Physics2D());
        }
        return true;
    }
    // fields
    static void Physics2D_IgnoreRaycastLayer(JSVCall vc)
    {
        var result = UnityEngine.Physics2D.IgnoreRaycastLayer;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Physics2D_DefaultRaycastLayers(JSVCall vc)
    {
        var result = UnityEngine.Physics2D.DefaultRaycastLayers;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Physics2D_AllLayers(JSVCall vc)
    {
        var result = UnityEngine.Physics2D.AllLayers;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    // properties
    static void Physics2D_alwaysShowColliders(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.alwaysShowColliders;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.alwaysShowColliders = arg0;
        }
    }
    static void Physics2D_angularSleepTolerance(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.angularSleepTolerance;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.angularSleepTolerance = arg0;
        }
    }
    static void Physics2D_baumgarteScale(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.baumgarteScale;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.baumgarteScale = arg0;
        }
    }
    static void Physics2D_baumgarteTOIScale(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.baumgarteTOIScale;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.baumgarteTOIScale = arg0;
        }
    }
    static void Physics2D_changeStopsCallbacks(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.changeStopsCallbacks;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.changeStopsCallbacks = arg0;
        }
    }
    static void Physics2D_colliderAsleepColor(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.colliderAsleepColor;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.colliderAsleepColor = arg0;
        }
    }
    static void Physics2D_colliderAwakeColor(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.colliderAwakeColor;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.colliderAwakeColor = arg0;
        }
    }
    static void Physics2D_colliderContactColor(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.colliderContactColor;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.colliderContactColor = arg0;
        }
    }
    static void Physics2D_contactArrowScale(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.contactArrowScale;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.contactArrowScale = arg0;
        }
    }
    static void Physics2D_gravity(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.gravity;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.gravity = arg0;
        }
    }
    static void Physics2D_linearSleepTolerance(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.linearSleepTolerance;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.linearSleepTolerance = arg0;
        }
    }
    static void Physics2D_maxAngularCorrection(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.maxAngularCorrection;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.maxAngularCorrection = arg0;
        }
    }
    static void Physics2D_maxLinearCorrection(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.maxLinearCorrection;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.maxLinearCorrection = arg0;
        }
    }
    static void Physics2D_maxRotationSpeed(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.maxRotationSpeed;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.maxRotationSpeed = arg0;
        }
    }
    static void Physics2D_maxTranslationSpeed(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.maxTranslationSpeed;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.maxTranslationSpeed = arg0;
        }
    }
    static void Physics2D_minPenetrationForPenalty(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.minPenetrationForPenalty;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.minPenetrationForPenalty = arg0;
        }
    }
    static void Physics2D_positionIterations(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.positionIterations;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.positionIterations = arg0;
        }
    }
    static void Physics2D_queriesHitTriggers(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.queriesHitTriggers;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.queriesHitTriggers = arg0;
        }
    }
    static void Physics2D_queriesStartInColliders(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.queriesStartInColliders;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.queriesStartInColliders = arg0;
        }
    }
    static void Physics2D_showColliderContacts(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.showColliderContacts;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.showColliderContacts = arg0;
        }
    }
    static void Physics2D_showColliderSleep(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.showColliderSleep;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.showColliderSleep = arg0;
        }
    }
    static void Physics2D_timeToSleep(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.timeToSleep;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.timeToSleep = arg0;
        }
    }
    static void Physics2D_velocityIterations(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.velocityIterations;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.velocityIterations = arg0;
        }
    }
    static void Physics2D_velocityThreshold(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics2D.velocityThreshold;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.velocityThreshold = arg0;
        }
    }
    // methods
    static bool Physics2D_BoxCast__Vector2__Vector2__Single__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.BoxCast(arg0, arg1, arg2, arg3));
        }
        return true;
    }
    static bool Physics2D_BoxCast__Vector2__Vector2__Single__Vector2__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.BoxCast(arg0, arg1, arg2, arg3, arg4));
        }
        return true;
    }
    static bool Physics2D_BoxCast__Vector2__Vector2__Single__Vector2__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg5 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.BoxCast(arg0, arg1, arg2, arg3, arg4, arg5));
        }
        return true;
    }
    static bool Physics2D_BoxCast__Vector2__Vector2__Single__Vector2__Single__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 7)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg5 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg6 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.BoxCast(arg0, arg1, arg2, arg3, arg4, arg5, arg6));
        }
        return true;
    }
    static bool Physics2D_BoxCast__Vector2__Vector2__Single__Vector2__Single__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 8)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg5 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg6 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg7 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.BoxCast(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
        }
        return true;
    }
    static bool Physics2D_BoxCastAll__Vector2__Vector2__Single__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.BoxCastAll(arg0, arg1, arg2, arg3);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_BoxCastAll__Vector2__Vector2__Single__Vector2__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.BoxCastAll(arg0, arg1, arg2, arg3, arg4);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_BoxCastAll__Vector2__Vector2__Single__Vector2__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg5 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.BoxCastAll(arg0, arg1, arg2, arg3, arg4, arg5);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_BoxCastAll__Vector2__Vector2__Single__Vector2__Single__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 7)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg5 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg6 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.BoxCastAll(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_BoxCastAll__Vector2__Vector2__Single__Vector2__Single__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 8)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg5 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg6 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg7 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.BoxCastAll(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_BoxCastNonAlloc__Vector2__Vector2__Single__Vector2__RaycastHit2D_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg4 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.BoxCastNonAlloc(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics2D_BoxCastNonAlloc__Vector2__Vector2__Single__Vector2__RaycastHit2D_Array__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg4 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.BoxCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5)));
        }
        return true;
    }
    static bool Physics2D_BoxCastNonAlloc__Vector2__Vector2__Single__Vector2__RaycastHit2D_Array__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 7)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg4 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg6 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.BoxCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5, arg6)));
        }
        return true;
    }
    static bool Physics2D_BoxCastNonAlloc__Vector2__Vector2__Single__Vector2__RaycastHit2D_Array__Single__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 8)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg4 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg6 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg7 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.BoxCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)));
        }
        return true;
    }
    static bool Physics2D_BoxCastNonAlloc__Vector2__Vector2__Single__Vector2__RaycastHit2D_Array__Single__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 9)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg3 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg4 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg6 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg7 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg8 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.BoxCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)));
        }
        return true;
    }
    static bool Physics2D_CircleCast__Vector2__Single__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.CircleCast(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Physics2D_CircleCast__Vector2__Single__Vector2__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.CircleCast(arg0, arg1, arg2, arg3));
        }
        return true;
    }
    static bool Physics2D_CircleCast__Vector2__Single__Vector2__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.CircleCast(arg0, arg1, arg2, arg3, arg4));
        }
        return true;
    }
    static bool Physics2D_CircleCast__Vector2__Single__Vector2__Single__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.CircleCast(arg0, arg1, arg2, arg3, arg4, arg5));
        }
        return true;
    }
    static bool Physics2D_CircleCast__Vector2__Single__Vector2__Single__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 7)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg6 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.CircleCast(arg0, arg1, arg2, arg3, arg4, arg5, arg6));
        }
        return true;
    }
    static bool Physics2D_CircleCastAll__Vector2__Single__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.CircleCastAll(arg0, arg1, arg2);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_CircleCastAll__Vector2__Single__Vector2__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.CircleCastAll(arg0, arg1, arg2, arg3);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_CircleCastAll__Vector2__Single__Vector2__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.CircleCastAll(arg0, arg1, arg2, arg3, arg4);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_CircleCastAll__Vector2__Single__Vector2__Single__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.CircleCastAll(arg0, arg1, arg2, arg3, arg4, arg5);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_CircleCastAll__Vector2__Single__Vector2__Single__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 7)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg6 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.CircleCastAll(arg0, arg1, arg2, arg3, arg4, arg5, arg6);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_CircleCastNonAlloc__Vector2__Single__Vector2__RaycastHit2D_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg3 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.CircleCastNonAlloc(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics2D_CircleCastNonAlloc__Vector2__Single__Vector2__RaycastHit2D_Array__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg3 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.CircleCastNonAlloc(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics2D_CircleCastNonAlloc__Vector2__Single__Vector2__RaycastHit2D_Array__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg3 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg5 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.CircleCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5)));
        }
        return true;
    }
    static bool Physics2D_CircleCastNonAlloc__Vector2__Single__Vector2__RaycastHit2D_Array__Single__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 7)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg3 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg5 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg6 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.CircleCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5, arg6)));
        }
        return true;
    }
    static bool Physics2D_CircleCastNonAlloc__Vector2__Single__Vector2__RaycastHit2D_Array__Single__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 8)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg3 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg5 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg6 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg7 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.CircleCastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)));
        }
        return true;
    }
    static bool Physics2D_GetIgnoreCollision__Collider2D__Collider2D(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Collider2D arg0 = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D arg1 = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics2D.GetIgnoreCollision(arg0, arg1)));
        }
        return true;
    }
    static bool Physics2D_GetIgnoreLayerCollision__Int32__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics2D.GetIgnoreLayerCollision(arg0, arg1)));
        }
        return true;
    }
    static bool Physics2D_GetLayerCollisionMask__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.GetLayerCollisionMask(arg0)));
        }
        return true;
    }
    static bool Physics2D_GetRayIntersection__Ray(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.GetRayIntersection(arg0));
        }
        return true;
    }
    static bool Physics2D_GetRayIntersection__Ray__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.GetRayIntersection(arg0, arg1));
        }
        return true;
    }
    static bool Physics2D_GetRayIntersection__Ray__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.GetRayIntersection(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Physics2D_GetRayIntersectionAll__Ray(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.GetRayIntersectionAll(arg0);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_GetRayIntersectionAll__Ray__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.GetRayIntersectionAll(arg0, arg1);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_GetRayIntersectionAll__Ray__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.GetRayIntersectionAll(arg0, arg1, arg2);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_GetRayIntersectionNonAlloc__Ray__RaycastHit2D_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg1 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.GetRayIntersectionNonAlloc(arg0, arg1)));
        }
        return true;
    }
    static bool Physics2D_GetRayIntersectionNonAlloc__Ray__RaycastHit2D_Array__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg1 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.GetRayIntersectionNonAlloc(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Physics2D_GetRayIntersectionNonAlloc__Ray__RaycastHit2D_Array__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg1 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.GetRayIntersectionNonAlloc(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics2D_IgnoreCollision__Collider2D__Collider2D(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Collider2D arg0 = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D arg1 = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.IgnoreCollision(arg0, arg1);
        }
        return true;
    }
    static bool Physics2D_IgnoreCollision__Collider2D__Collider2D__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Collider2D arg0 = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D arg1 = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            bool arg2 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.IgnoreCollision(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Physics2D_IgnoreLayerCollision__Int32__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.IgnoreLayerCollision(arg0, arg1);
        }
        return true;
    }
    static bool Physics2D_IgnoreLayerCollision__Int32__Int32__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            bool arg2 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.IgnoreLayerCollision(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Physics2D_IsTouching__Collider2D__Collider2D(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Collider2D arg0 = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D arg1 = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics2D.IsTouching(arg0, arg1)));
        }
        return true;
    }
    static bool Physics2D_IsTouchingLayers__Collider2D(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Collider2D arg0 = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics2D.IsTouchingLayers(arg0)));
        }
        return true;
    }
    static bool Physics2D_IsTouchingLayers__Collider2D__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Collider2D arg0 = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Physics2D.IsTouchingLayers(arg0, arg1)));
        }
        return true;
    }
    static bool Physics2D_Linecast__Vector2__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.Linecast(arg0, arg1));
        }
        return true;
    }
    static bool Physics2D_Linecast__Vector2__Vector2__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.Linecast(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Physics2D_Linecast__Vector2__Vector2__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.Linecast(arg0, arg1, arg2, arg3));
        }
        return true;
    }
    static bool Physics2D_Linecast__Vector2__Vector2__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.Linecast(arg0, arg1, arg2, arg3, arg4));
        }
        return true;
    }
    static bool Physics2D_LinecastAll__Vector2__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.LinecastAll(arg0, arg1);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_LinecastAll__Vector2__Vector2__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.LinecastAll(arg0, arg1, arg2);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_LinecastAll__Vector2__Vector2__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.LinecastAll(arg0, arg1, arg2, arg3);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_LinecastAll__Vector2__Vector2__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.LinecastAll(arg0, arg1, arg2, arg3, arg4);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_LinecastNonAlloc__Vector2__Vector2__RaycastHit2D_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.LinecastNonAlloc(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Physics2D_LinecastNonAlloc__Vector2__Vector2__RaycastHit2D_Array__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.LinecastNonAlloc(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics2D_LinecastNonAlloc__Vector2__Vector2__RaycastHit2D_Array__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.LinecastNonAlloc(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics2D_LinecastNonAlloc__Vector2__Vector2__RaycastHit2D_Array__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.LinecastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5)));
        }
        return true;
    }
    static bool Physics2D_OverlapArea__Vector2__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.OverlapArea(arg0, arg1));
        }
        return true;
    }
    static bool Physics2D_OverlapArea__Vector2__Vector2__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.OverlapArea(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Physics2D_OverlapArea__Vector2__Vector2__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.OverlapArea(arg0, arg1, arg2, arg3));
        }
        return true;
    }
    static bool Physics2D_OverlapArea__Vector2__Vector2__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.OverlapArea(arg0, arg1, arg2, arg3, arg4));
        }
        return true;
    }
    static bool Physics2D_OverlapAreaAll__Vector2__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider2D[])UnityEngine.Physics2D.OverlapAreaAll(arg0, arg1);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_OverlapAreaAll__Vector2__Vector2__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider2D[])UnityEngine.Physics2D.OverlapAreaAll(arg0, arg1, arg2);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_OverlapAreaAll__Vector2__Vector2__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider2D[])UnityEngine.Physics2D.OverlapAreaAll(arg0, arg1, arg2, arg3);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_OverlapAreaAll__Vector2__Vector2__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider2D[])UnityEngine.Physics2D.OverlapAreaAll(arg0, arg1, arg2, arg3, arg4);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_OverlapAreaNonAlloc__Vector2__Vector2__Collider2D_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.OverlapAreaNonAlloc(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Physics2D_OverlapAreaNonAlloc__Vector2__Vector2__Collider2D_Array__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.OverlapAreaNonAlloc(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics2D_OverlapAreaNonAlloc__Vector2__Vector2__Collider2D_Array__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.OverlapAreaNonAlloc(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics2D_OverlapAreaNonAlloc__Vector2__Vector2__Collider2D_Array__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.OverlapAreaNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5)));
        }
        return true;
    }
    static bool Physics2D_OverlapBox__Vector2__Vector2__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.OverlapBox(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Physics2D_OverlapBox__Vector2__Vector2__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.OverlapBox(arg0, arg1, arg2, arg3));
        }
        return true;
    }
    static bool Physics2D_OverlapBox__Vector2__Vector2__Single__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.OverlapBox(arg0, arg1, arg2, arg3, arg4));
        }
        return true;
    }
    static bool Physics2D_OverlapBox__Vector2__Vector2__Single__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.OverlapBox(arg0, arg1, arg2, arg3, arg4, arg5));
        }
        return true;
    }
    static bool Physics2D_OverlapBoxAll__Vector2__Vector2__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider2D[])UnityEngine.Physics2D.OverlapBoxAll(arg0, arg1, arg2);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_OverlapBoxAll__Vector2__Vector2__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider2D[])UnityEngine.Physics2D.OverlapBoxAll(arg0, arg1, arg2, arg3);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_OverlapBoxAll__Vector2__Vector2__Single__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider2D[])UnityEngine.Physics2D.OverlapBoxAll(arg0, arg1, arg2, arg3, arg4);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_OverlapBoxAll__Vector2__Vector2__Single__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider2D[])UnityEngine.Physics2D.OverlapBoxAll(arg0, arg1, arg2, arg3, arg4, arg5);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_OverlapBoxNonAlloc__Vector2__Vector2__Single__Collider2D_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D[] arg3 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.OverlapBoxNonAlloc(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics2D_OverlapBoxNonAlloc__Vector2__Vector2__Single__Collider2D_Array__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D[] arg3 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.OverlapBoxNonAlloc(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics2D_OverlapBoxNonAlloc__Vector2__Vector2__Single__Collider2D_Array__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D[] arg3 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.OverlapBoxNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5)));
        }
        return true;
    }
    static bool Physics2D_OverlapBoxNonAlloc__Vector2__Vector2__Single__Collider2D_Array__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 7)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D[] arg3 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg6 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.OverlapBoxNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5, arg6)));
        }
        return true;
    }
    static bool Physics2D_OverlapCircle__Vector2__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.OverlapCircle(arg0, arg1));
        }
        return true;
    }
    static bool Physics2D_OverlapCircle__Vector2__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.OverlapCircle(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Physics2D_OverlapCircle__Vector2__Single__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.OverlapCircle(arg0, arg1, arg2, arg3));
        }
        return true;
    }
    static bool Physics2D_OverlapCircle__Vector2__Single__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.OverlapCircle(arg0, arg1, arg2, arg3, arg4));
        }
        return true;
    }
    static bool Physics2D_OverlapCircleAll__Vector2__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider2D[])UnityEngine.Physics2D.OverlapCircleAll(arg0, arg1);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_OverlapCircleAll__Vector2__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider2D[])UnityEngine.Physics2D.OverlapCircleAll(arg0, arg1, arg2);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_OverlapCircleAll__Vector2__Single__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider2D[])UnityEngine.Physics2D.OverlapCircleAll(arg0, arg1, arg2, arg3);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_OverlapCircleAll__Vector2__Single__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider2D[])UnityEngine.Physics2D.OverlapCircleAll(arg0, arg1, arg2, arg3, arg4);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_OverlapCircleNonAlloc__Vector2__Single__Collider2D_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.OverlapCircleNonAlloc(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Physics2D_OverlapCircleNonAlloc__Vector2__Single__Collider2D_Array__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.OverlapCircleNonAlloc(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics2D_OverlapCircleNonAlloc__Vector2__Single__Collider2D_Array__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.OverlapCircleNonAlloc(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics2D_OverlapCircleNonAlloc__Vector2__Single__Collider2D_Array__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.OverlapCircleNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5)));
        }
        return true;
    }
    static bool Physics2D_OverlapPoint__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.OverlapPoint(arg0));
        }
        return true;
    }
    static bool Physics2D_OverlapPoint__Vector2__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.OverlapPoint(arg0, arg1));
        }
        return true;
    }
    static bool Physics2D_OverlapPoint__Vector2__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.OverlapPoint(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Physics2D_OverlapPoint__Vector2__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.OverlapPoint(arg0, arg1, arg2, arg3));
        }
        return true;
    }
    static bool Physics2D_OverlapPointAll__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider2D[])UnityEngine.Physics2D.OverlapPointAll(arg0);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_OverlapPointAll__Vector2__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider2D[])UnityEngine.Physics2D.OverlapPointAll(arg0, arg1);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_OverlapPointAll__Vector2__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider2D[])UnityEngine.Physics2D.OverlapPointAll(arg0, arg1, arg2);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_OverlapPointAll__Vector2__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Collider2D[])UnityEngine.Physics2D.OverlapPointAll(arg0, arg1, arg2, arg3);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_OverlapPointNonAlloc__Vector2__Collider2D_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D[] arg1 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.OverlapPointNonAlloc(arg0, arg1)));
        }
        return true;
    }
    static bool Physics2D_OverlapPointNonAlloc__Vector2__Collider2D_Array__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D[] arg1 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.OverlapPointNonAlloc(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Physics2D_OverlapPointNonAlloc__Vector2__Collider2D_Array__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D[] arg1 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.OverlapPointNonAlloc(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics2D_OverlapPointNonAlloc__Vector2__Collider2D_Array__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Collider2D[] arg1 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Collider2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Collider2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.OverlapPointNonAlloc(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics2D_Raycast__Vector2__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.Raycast(arg0, arg1));
        }
        return true;
    }
    static bool Physics2D_Raycast__Vector2__Vector2__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.Raycast(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Physics2D_Raycast__Vector2__Vector2__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.Raycast(arg0, arg1, arg2, arg3));
        }
        return true;
    }
    static bool Physics2D_Raycast__Vector2__Vector2__Single__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.Raycast(arg0, arg1, arg2, arg3, arg4));
        }
        return true;
    }
    static bool Physics2D_Raycast__Vector2__Vector2__Single__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Physics2D.Raycast(arg0, arg1, arg2, arg3, arg4, arg5));
        }
        return true;
    }
    static bool Physics2D_RaycastAll__Vector2__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.RaycastAll(arg0, arg1);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_RaycastAll__Vector2__Vector2__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.RaycastAll(arg0, arg1, arg2);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_RaycastAll__Vector2__Vector2__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.RaycastAll(arg0, arg1, arg2, arg3);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_RaycastAll__Vector2__Vector2__Single__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.RaycastAll(arg0, arg1, arg2, arg3, arg4);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_RaycastAll__Vector2__Vector2__Single__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg3 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit2D[])UnityEngine.Physics2D.RaycastAll(arg0, arg1, arg2, arg3, arg4, arg5);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Physics2D_RaycastNonAlloc__Vector2__Vector2__RaycastHit2D_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.RaycastNonAlloc(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Physics2D_RaycastNonAlloc__Vector2__Vector2__RaycastHit2D_Array__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.RaycastNonAlloc(arg0, arg1, arg2, arg3)));
        }
        return true;
    }
    static bool Physics2D_RaycastNonAlloc__Vector2__Vector2__RaycastHit2D_Array__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.RaycastNonAlloc(arg0, arg1, arg2, arg3, arg4)));
        }
        return true;
    }
    static bool Physics2D_RaycastNonAlloc__Vector2__Vector2__RaycastHit2D_Array__Single__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.RaycastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5)));
        }
        return true;
    }
    static bool Physics2D_RaycastNonAlloc__Vector2__Vector2__RaycastHit2D_Array__Single__Int32__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 7)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RaycastHit2D[] arg2 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RaycastHit2D[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RaycastHit2D[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RaycastHit2D)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg4 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg6 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Physics2D.RaycastNonAlloc(arg0, arg1, arg2, arg3, arg4, arg5, arg6)));
        }
        return true;
    }
    static bool Physics2D_SetLayerCollisionMask__Int32__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Physics2D.SetLayerCollisionMask(arg0, arg1);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Physics2D);
        ci.fields = new JSMgr.CSCallbackField[]
        {
            Physics2D_IgnoreRaycastLayer,
            Physics2D_DefaultRaycastLayers,
            Physics2D_AllLayers,
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Physics2D_alwaysShowColliders,
            Physics2D_angularSleepTolerance,
            Physics2D_baumgarteScale,
            Physics2D_baumgarteTOIScale,
            Physics2D_changeStopsCallbacks,
            Physics2D_colliderAsleepColor,
            Physics2D_colliderAwakeColor,
            Physics2D_colliderContactColor,
            Physics2D_contactArrowScale,
            Physics2D_gravity,
            Physics2D_linearSleepTolerance,
            Physics2D_maxAngularCorrection,
            Physics2D_maxLinearCorrection,
            Physics2D_maxRotationSpeed,
            Physics2D_maxTranslationSpeed,
            Physics2D_minPenetrationForPenalty,
            Physics2D_positionIterations,
            Physics2D_queriesHitTriggers,
            Physics2D_queriesStartInColliders,
            Physics2D_showColliderContacts,
            Physics2D_showColliderSleep,
            Physics2D_timeToSleep,
            Physics2D_velocityIterations,
            Physics2D_velocityThreshold,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Physics2D_Physics2D, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Physics2D_BoxCast__Vector2__Vector2__Single__Vector2, "BoxCast"),
            new JSMgr.MethodCallBackInfo(Physics2D_BoxCast__Vector2__Vector2__Single__Vector2__Single, "BoxCast"),
            new JSMgr.MethodCallBackInfo(Physics2D_BoxCast__Vector2__Vector2__Single__Vector2__Single__Int32, "BoxCast"),
            new JSMgr.MethodCallBackInfo(Physics2D_BoxCast__Vector2__Vector2__Single__Vector2__Single__Int32__Single, "BoxCast"),
            new JSMgr.MethodCallBackInfo(Physics2D_BoxCast__Vector2__Vector2__Single__Vector2__Single__Int32__Single__Single, "BoxCast"),
            new JSMgr.MethodCallBackInfo(Physics2D_BoxCastAll__Vector2__Vector2__Single__Vector2, "BoxCastAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_BoxCastAll__Vector2__Vector2__Single__Vector2__Single, "BoxCastAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_BoxCastAll__Vector2__Vector2__Single__Vector2__Single__Int32, "BoxCastAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_BoxCastAll__Vector2__Vector2__Single__Vector2__Single__Int32__Single, "BoxCastAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_BoxCastAll__Vector2__Vector2__Single__Vector2__Single__Int32__Single__Single, "BoxCastAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_BoxCastNonAlloc__Vector2__Vector2__Single__Vector2__RaycastHit2D_Array, "BoxCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_BoxCastNonAlloc__Vector2__Vector2__Single__Vector2__RaycastHit2D_Array__Single, "BoxCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_BoxCastNonAlloc__Vector2__Vector2__Single__Vector2__RaycastHit2D_Array__Single__Int32, "BoxCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_BoxCastNonAlloc__Vector2__Vector2__Single__Vector2__RaycastHit2D_Array__Single__Int32__Single, "BoxCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_BoxCastNonAlloc__Vector2__Vector2__Single__Vector2__RaycastHit2D_Array__Single__Int32__Single__Single, "BoxCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_CircleCast__Vector2__Single__Vector2, "CircleCast"),
            new JSMgr.MethodCallBackInfo(Physics2D_CircleCast__Vector2__Single__Vector2__Single, "CircleCast"),
            new JSMgr.MethodCallBackInfo(Physics2D_CircleCast__Vector2__Single__Vector2__Single__Int32, "CircleCast"),
            new JSMgr.MethodCallBackInfo(Physics2D_CircleCast__Vector2__Single__Vector2__Single__Int32__Single, "CircleCast"),
            new JSMgr.MethodCallBackInfo(Physics2D_CircleCast__Vector2__Single__Vector2__Single__Int32__Single__Single, "CircleCast"),
            new JSMgr.MethodCallBackInfo(Physics2D_CircleCastAll__Vector2__Single__Vector2, "CircleCastAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_CircleCastAll__Vector2__Single__Vector2__Single, "CircleCastAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_CircleCastAll__Vector2__Single__Vector2__Single__Int32, "CircleCastAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_CircleCastAll__Vector2__Single__Vector2__Single__Int32__Single, "CircleCastAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_CircleCastAll__Vector2__Single__Vector2__Single__Int32__Single__Single, "CircleCastAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_CircleCastNonAlloc__Vector2__Single__Vector2__RaycastHit2D_Array, "CircleCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_CircleCastNonAlloc__Vector2__Single__Vector2__RaycastHit2D_Array__Single, "CircleCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_CircleCastNonAlloc__Vector2__Single__Vector2__RaycastHit2D_Array__Single__Int32, "CircleCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_CircleCastNonAlloc__Vector2__Single__Vector2__RaycastHit2D_Array__Single__Int32__Single, "CircleCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_CircleCastNonAlloc__Vector2__Single__Vector2__RaycastHit2D_Array__Single__Int32__Single__Single, "CircleCastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_GetIgnoreCollision__Collider2D__Collider2D, "GetIgnoreCollision"),
            new JSMgr.MethodCallBackInfo(Physics2D_GetIgnoreLayerCollision__Int32__Int32, "GetIgnoreLayerCollision"),
            new JSMgr.MethodCallBackInfo(Physics2D_GetLayerCollisionMask__Int32, "GetLayerCollisionMask"),
            new JSMgr.MethodCallBackInfo(Physics2D_GetRayIntersection__Ray, "GetRayIntersection"),
            new JSMgr.MethodCallBackInfo(Physics2D_GetRayIntersection__Ray__Single, "GetRayIntersection"),
            new JSMgr.MethodCallBackInfo(Physics2D_GetRayIntersection__Ray__Single__Int32, "GetRayIntersection"),
            new JSMgr.MethodCallBackInfo(Physics2D_GetRayIntersectionAll__Ray, "GetRayIntersectionAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_GetRayIntersectionAll__Ray__Single, "GetRayIntersectionAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_GetRayIntersectionAll__Ray__Single__Int32, "GetRayIntersectionAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_GetRayIntersectionNonAlloc__Ray__RaycastHit2D_Array, "GetRayIntersectionNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_GetRayIntersectionNonAlloc__Ray__RaycastHit2D_Array__Single, "GetRayIntersectionNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_GetRayIntersectionNonAlloc__Ray__RaycastHit2D_Array__Single__Int32, "GetRayIntersectionNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_IgnoreCollision__Collider2D__Collider2D, "IgnoreCollision"),
            new JSMgr.MethodCallBackInfo(Physics2D_IgnoreCollision__Collider2D__Collider2D__Boolean, "IgnoreCollision"),
            new JSMgr.MethodCallBackInfo(Physics2D_IgnoreLayerCollision__Int32__Int32, "IgnoreLayerCollision"),
            new JSMgr.MethodCallBackInfo(Physics2D_IgnoreLayerCollision__Int32__Int32__Boolean, "IgnoreLayerCollision"),
            new JSMgr.MethodCallBackInfo(Physics2D_IsTouching__Collider2D__Collider2D, "IsTouching"),
            new JSMgr.MethodCallBackInfo(Physics2D_IsTouchingLayers__Collider2D, "IsTouchingLayers"),
            new JSMgr.MethodCallBackInfo(Physics2D_IsTouchingLayers__Collider2D__Int32, "IsTouchingLayers"),
            new JSMgr.MethodCallBackInfo(Physics2D_Linecast__Vector2__Vector2, "Linecast"),
            new JSMgr.MethodCallBackInfo(Physics2D_Linecast__Vector2__Vector2__Int32, "Linecast"),
            new JSMgr.MethodCallBackInfo(Physics2D_Linecast__Vector2__Vector2__Int32__Single, "Linecast"),
            new JSMgr.MethodCallBackInfo(Physics2D_Linecast__Vector2__Vector2__Int32__Single__Single, "Linecast"),
            new JSMgr.MethodCallBackInfo(Physics2D_LinecastAll__Vector2__Vector2, "LinecastAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_LinecastAll__Vector2__Vector2__Int32, "LinecastAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_LinecastAll__Vector2__Vector2__Int32__Single, "LinecastAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_LinecastAll__Vector2__Vector2__Int32__Single__Single, "LinecastAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_LinecastNonAlloc__Vector2__Vector2__RaycastHit2D_Array, "LinecastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_LinecastNonAlloc__Vector2__Vector2__RaycastHit2D_Array__Int32, "LinecastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_LinecastNonAlloc__Vector2__Vector2__RaycastHit2D_Array__Int32__Single, "LinecastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_LinecastNonAlloc__Vector2__Vector2__RaycastHit2D_Array__Int32__Single__Single, "LinecastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapArea__Vector2__Vector2, "OverlapArea"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapArea__Vector2__Vector2__Int32, "OverlapArea"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapArea__Vector2__Vector2__Int32__Single, "OverlapArea"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapArea__Vector2__Vector2__Int32__Single__Single, "OverlapArea"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapAreaAll__Vector2__Vector2, "OverlapAreaAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapAreaAll__Vector2__Vector2__Int32, "OverlapAreaAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapAreaAll__Vector2__Vector2__Int32__Single, "OverlapAreaAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapAreaAll__Vector2__Vector2__Int32__Single__Single, "OverlapAreaAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapAreaNonAlloc__Vector2__Vector2__Collider2D_Array, "OverlapAreaNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapAreaNonAlloc__Vector2__Vector2__Collider2D_Array__Int32, "OverlapAreaNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapAreaNonAlloc__Vector2__Vector2__Collider2D_Array__Int32__Single, "OverlapAreaNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapAreaNonAlloc__Vector2__Vector2__Collider2D_Array__Int32__Single__Single, "OverlapAreaNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapBox__Vector2__Vector2__Single, "OverlapBox"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapBox__Vector2__Vector2__Single__Int32, "OverlapBox"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapBox__Vector2__Vector2__Single__Int32__Single, "OverlapBox"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapBox__Vector2__Vector2__Single__Int32__Single__Single, "OverlapBox"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapBoxAll__Vector2__Vector2__Single, "OverlapBoxAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapBoxAll__Vector2__Vector2__Single__Int32, "OverlapBoxAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapBoxAll__Vector2__Vector2__Single__Int32__Single, "OverlapBoxAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapBoxAll__Vector2__Vector2__Single__Int32__Single__Single, "OverlapBoxAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapBoxNonAlloc__Vector2__Vector2__Single__Collider2D_Array, "OverlapBoxNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapBoxNonAlloc__Vector2__Vector2__Single__Collider2D_Array__Int32, "OverlapBoxNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapBoxNonAlloc__Vector2__Vector2__Single__Collider2D_Array__Int32__Single, "OverlapBoxNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapBoxNonAlloc__Vector2__Vector2__Single__Collider2D_Array__Int32__Single__Single, "OverlapBoxNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapCircle__Vector2__Single, "OverlapCircle"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapCircle__Vector2__Single__Int32, "OverlapCircle"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapCircle__Vector2__Single__Int32__Single, "OverlapCircle"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapCircle__Vector2__Single__Int32__Single__Single, "OverlapCircle"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapCircleAll__Vector2__Single, "OverlapCircleAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapCircleAll__Vector2__Single__Int32, "OverlapCircleAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapCircleAll__Vector2__Single__Int32__Single, "OverlapCircleAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapCircleAll__Vector2__Single__Int32__Single__Single, "OverlapCircleAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapCircleNonAlloc__Vector2__Single__Collider2D_Array, "OverlapCircleNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapCircleNonAlloc__Vector2__Single__Collider2D_Array__Int32, "OverlapCircleNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapCircleNonAlloc__Vector2__Single__Collider2D_Array__Int32__Single, "OverlapCircleNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapCircleNonAlloc__Vector2__Single__Collider2D_Array__Int32__Single__Single, "OverlapCircleNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapPoint__Vector2, "OverlapPoint"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapPoint__Vector2__Int32, "OverlapPoint"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapPoint__Vector2__Int32__Single, "OverlapPoint"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapPoint__Vector2__Int32__Single__Single, "OverlapPoint"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapPointAll__Vector2, "OverlapPointAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapPointAll__Vector2__Int32, "OverlapPointAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapPointAll__Vector2__Int32__Single, "OverlapPointAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapPointAll__Vector2__Int32__Single__Single, "OverlapPointAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapPointNonAlloc__Vector2__Collider2D_Array, "OverlapPointNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapPointNonAlloc__Vector2__Collider2D_Array__Int32, "OverlapPointNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapPointNonAlloc__Vector2__Collider2D_Array__Int32__Single, "OverlapPointNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_OverlapPointNonAlloc__Vector2__Collider2D_Array__Int32__Single__Single, "OverlapPointNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_Raycast__Vector2__Vector2, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics2D_Raycast__Vector2__Vector2__Single, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics2D_Raycast__Vector2__Vector2__Single__Int32, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics2D_Raycast__Vector2__Vector2__Single__Int32__Single, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics2D_Raycast__Vector2__Vector2__Single__Int32__Single__Single, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics2D_RaycastAll__Vector2__Vector2, "RaycastAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_RaycastAll__Vector2__Vector2__Single, "RaycastAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_RaycastAll__Vector2__Vector2__Single__Int32, "RaycastAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_RaycastAll__Vector2__Vector2__Single__Int32__Single, "RaycastAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_RaycastAll__Vector2__Vector2__Single__Int32__Single__Single, "RaycastAll"),
            new JSMgr.MethodCallBackInfo(Physics2D_RaycastNonAlloc__Vector2__Vector2__RaycastHit2D_Array, "RaycastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_RaycastNonAlloc__Vector2__Vector2__RaycastHit2D_Array__Single, "RaycastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_RaycastNonAlloc__Vector2__Vector2__RaycastHit2D_Array__Single__Int32, "RaycastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_RaycastNonAlloc__Vector2__Vector2__RaycastHit2D_Array__Single__Int32__Single, "RaycastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_RaycastNonAlloc__Vector2__Vector2__RaycastHit2D_Array__Single__Int32__Single__Single, "RaycastNonAlloc"),
            new JSMgr.MethodCallBackInfo(Physics2D_SetLayerCollisionMask__Int32__Int32, "SetLayerCollisionMask"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}