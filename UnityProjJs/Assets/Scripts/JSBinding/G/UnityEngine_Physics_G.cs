
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
    static void Physics_kIgnoreRaycastLayer(JSVCall vc)
    {
        var result = UnityEngine.Physics.kIgnoreRaycastLayer;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Physics_kDefaultRaycastLayers(JSVCall vc)
    {
        var result = UnityEngine.Physics.kDefaultRaycastLayers;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Physics_kAllLayers(JSVCall vc)
    {
        var result = UnityEngine.Physics.kAllLayers;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
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
    static void Physics_maxAngularVelocity(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics.maxAngularVelocity;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Physics.maxAngularVelocity = arg0;
        }
    }
    static void Physics_minPenetrationForPenalty(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics.minPenetrationForPenalty;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Physics.minPenetrationForPenalty = arg0;
        }
    }
    static void Physics_sleepAngularVelocity(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics.sleepAngularVelocity;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Physics.sleepAngularVelocity = arg0;
        }
    }
    static void Physics_sleepVelocity(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics.sleepVelocity;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Physics.sleepVelocity = arg0;
        }
    }
    static void Physics_solverIterationCount(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Physics.solverIterationCount;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Physics.solverIterationCount = arg0;
        }
    }
    // methods
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
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Physics);
        ci.fields = new JSMgr.CSCallbackField[]
        {
            Physics_kIgnoreRaycastLayer,
            Physics_kDefaultRaycastLayers,
            Physics_kAllLayers,
            Physics_IgnoreRaycastLayer,
            Physics_DefaultRaycastLayers,
            Physics_AllLayers,
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Physics_bounceThreshold,
            Physics_gravity,
            Physics_maxAngularVelocity,
            Physics_minPenetrationForPenalty,
            Physics_sleepAngularVelocity,
            Physics_sleepVelocity,
            Physics_solverIterationCount,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Physics_Physics, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCast__Vector3__Vector3__Single__Vector3, "CapsuleCast"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCast__Vector3__Vector3__Single__Vector3__Single, "CapsuleCast"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCast__Vector3__Vector3__Single__Vector3__Single__Int32, "CapsuleCast"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCast__Vector3__Vector3__Single__Vector3__RaycastHit, "CapsuleCast"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCast__Vector3__Vector3__Single__Vector3__RaycastHit__Single, "CapsuleCast"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCast__Vector3__Vector3__Single__Vector3__RaycastHit__Single__Int32, "CapsuleCast"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCastAll__Vector3__Vector3__Single__Vector3, "CapsuleCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCastAll__Vector3__Vector3__Single__Vector3__Single, "CapsuleCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_CapsuleCastAll__Vector3__Vector3__Single__Vector3__Single__Int32, "CapsuleCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_CheckCapsule__Vector3__Vector3__Single, "CheckCapsule"),
            new JSMgr.MethodCallBackInfo(Physics_CheckCapsule__Vector3__Vector3__Single__Int32, "CheckCapsule"),
            new JSMgr.MethodCallBackInfo(Physics_CheckSphere__Vector3__Single, "CheckSphere"),
            new JSMgr.MethodCallBackInfo(Physics_CheckSphere__Vector3__Single__Int32, "CheckSphere"),
            new JSMgr.MethodCallBackInfo(Physics_GetIgnoreLayerCollision__Int32__Int32, "GetIgnoreLayerCollision"),
            new JSMgr.MethodCallBackInfo(Physics_IgnoreCollision__Collider__Collider, "IgnoreCollision"),
            new JSMgr.MethodCallBackInfo(Physics_IgnoreCollision__Collider__Collider__Boolean, "IgnoreCollision"),
            new JSMgr.MethodCallBackInfo(Physics_IgnoreLayerCollision__Int32__Int32, "IgnoreLayerCollision"),
            new JSMgr.MethodCallBackInfo(Physics_IgnoreLayerCollision__Int32__Int32__Boolean, "IgnoreLayerCollision"),
            new JSMgr.MethodCallBackInfo(Physics_Linecast__Vector3__Vector3, "Linecast"),
            new JSMgr.MethodCallBackInfo(Physics_Linecast__Vector3__Vector3__Int32, "Linecast"),
            new JSMgr.MethodCallBackInfo(Physics_Linecast__Vector3__Vector3__RaycastHit, "Linecast"),
            new JSMgr.MethodCallBackInfo(Physics_Linecast__Vector3__Vector3__RaycastHit__Int32, "Linecast"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapSphere__Vector3__Single, "OverlapSphere"),
            new JSMgr.MethodCallBackInfo(Physics_OverlapSphere__Vector3__Single__Int32, "OverlapSphere"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Ray, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Ray__Single, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Ray__Single__Int32, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Ray__RaycastHit, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Ray__RaycastHit__Single, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Ray__RaycastHit__Single__Int32, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Vector3__Vector3, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Vector3__Vector3__Single, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Vector3__Vector3__Single__Int32, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Vector3__Vector3__RaycastHit, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Vector3__Vector3__RaycastHit__Single, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_Raycast__Vector3__Vector3__RaycastHit__Single__Int32, "Raycast"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastAll__Ray, "RaycastAll"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastAll__Ray__Single, "RaycastAll"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastAll__Ray__Single__Int32, "RaycastAll"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastAll__Vector3__Vector3, "RaycastAll"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastAll__Vector3__Vector3__Single, "RaycastAll"),
            new JSMgr.MethodCallBackInfo(Physics_RaycastAll__Vector3__Vector3__Single__Int32, "RaycastAll"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCast__Ray__Single, "SphereCast"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCast__Ray__Single__Single, "SphereCast"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCast__Ray__Single__Single__Int32, "SphereCast"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCast__Ray__Single__RaycastHit, "SphereCast"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCast__Ray__Single__RaycastHit__Single, "SphereCast"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCast__Ray__Single__RaycastHit__Single__Int32, "SphereCast"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCast__Vector3__Single__Vector3__RaycastHit, "SphereCast"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCast__Vector3__Single__Vector3__RaycastHit__Single, "SphereCast"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCast__Vector3__Single__Vector3__RaycastHit__Single__Int32, "SphereCast"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastAll__Ray__Single, "SphereCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastAll__Ray__Single__Single, "SphereCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastAll__Ray__Single__Single__Int32, "SphereCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastAll__Vector3__Single__Vector3, "SphereCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastAll__Vector3__Single__Vector3__Single, "SphereCastAll"),
            new JSMgr.MethodCallBackInfo(Physics_SphereCastAll__Vector3__Single__Vector3__Single__Int32, "SphereCastAll"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}