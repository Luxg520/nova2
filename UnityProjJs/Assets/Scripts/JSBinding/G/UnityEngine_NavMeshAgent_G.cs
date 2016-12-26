
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_NavMeshAgent_G
{
    ////////////////////// NavMeshAgent ///////////////////////////////////////
    // constructors
    static bool NavMeshAgent_NavMeshAgent(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.NavMeshAgent());
        }
        return true;
    }
    // fields
    // properties
    static void NavMeshAgent_acceleration(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            var result = _this.acceleration;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            _this.acceleration = arg0;
        }
    }
    static void NavMeshAgent_angularSpeed(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            var result = _this.angularSpeed;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            _this.angularSpeed = arg0;
        }
    }
    static void NavMeshAgent_autoBraking(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            var result = _this.autoBraking;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            _this.autoBraking = arg0;
        }
    }
    static void NavMeshAgent_autoRepath(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            var result = _this.autoRepath;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            _this.autoRepath = arg0;
        }
    }
    static void NavMeshAgent_autoTraverseOffMeshLink(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            var result = _this.autoTraverseOffMeshLink;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            _this.autoTraverseOffMeshLink = arg0;
        }
    }
    static void NavMeshAgent_avoidancePriority(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            var result = _this.avoidancePriority;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            _this.avoidancePriority = arg0;
        }
    }
    static void NavMeshAgent_baseOffset(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            var result = _this.baseOffset;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            _this.baseOffset = arg0;
        }
    }
    static void NavMeshAgent_currentOffMeshLinkData(JSVCall vc)
    {
        UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
        var result = _this.currentOffMeshLinkData;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void NavMeshAgent_desiredVelocity(JSVCall vc)
    {
        UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
        var result = _this.desiredVelocity;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void NavMeshAgent_destination(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            var result = _this.destination;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            _this.destination = arg0;
        }
    }
    static void NavMeshAgent_hasPath(JSVCall vc)
    {
        UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
        var result = _this.hasPath;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void NavMeshAgent_height(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            var result = _this.height;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            _this.height = arg0;
        }
    }
    static void NavMeshAgent_isOnOffMeshLink(JSVCall vc)
    {
        UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
        var result = _this.isOnOffMeshLink;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void NavMeshAgent_isPathStale(JSVCall vc)
    {
        UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
        var result = _this.isPathStale;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void NavMeshAgent_nextOffMeshLinkData(JSVCall vc)
    {
        UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
        var result = _this.nextOffMeshLinkData;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void NavMeshAgent_nextPosition(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            var result = _this.nextPosition;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            _this.nextPosition = arg0;
        }
    }
    static void NavMeshAgent_obstacleAvoidanceType(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            var result = _this.obstacleAvoidanceType;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.ObstacleAvoidanceType arg0 = (UnityEngine.ObstacleAvoidanceType)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            _this.obstacleAvoidanceType = arg0;
        }
    }
    static void NavMeshAgent_path(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            var result = _this.path;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.NavMeshPath arg0 = (UnityEngine.NavMeshPath)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            _this.path = arg0;
        }
    }
    static void NavMeshAgent_pathEndPosition(JSVCall vc)
    {
        UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
        var result = _this.pathEndPosition;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void NavMeshAgent_pathPending(JSVCall vc)
    {
        UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
        var result = _this.pathPending;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void NavMeshAgent_pathStatus(JSVCall vc)
    {
        UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
        var result = _this.pathStatus;
        JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    static void NavMeshAgent_radius(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            var result = _this.radius;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            _this.radius = arg0;
        }
    }
    static void NavMeshAgent_remainingDistance(JSVCall vc)
    {
        UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
        var result = _this.remainingDistance;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void NavMeshAgent_speed(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            var result = _this.speed;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            _this.speed = arg0;
        }
    }
    static void NavMeshAgent_steeringTarget(JSVCall vc)
    {
        UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
        var result = _this.steeringTarget;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void NavMeshAgent_stoppingDistance(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            var result = _this.stoppingDistance;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            _this.stoppingDistance = arg0;
        }
    }
    static void NavMeshAgent_updatePosition(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            var result = _this.updatePosition;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            _this.updatePosition = arg0;
        }
    }
    static void NavMeshAgent_updateRotation(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            var result = _this.updateRotation;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            _this.updateRotation = arg0;
        }
    }
    static void NavMeshAgent_velocity(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            var result = _this.velocity;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            _this.velocity = arg0;
        }
    }
    static void NavMeshAgent_walkableMask(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            var result = _this.walkableMask;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.NavMeshAgent _this = (UnityEngine.NavMeshAgent)vc.csObj;
            _this.walkableMask = arg0;
        }
    }
    // methods
    static bool NavMeshAgent_ActivateCurrentOffMeshLink__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            ((UnityEngine.NavMeshAgent)vc.csObj).ActivateCurrentOffMeshLink(arg0);
        }
        return true;
    }
    static bool NavMeshAgent_CalculatePath__Vector3__NavMeshPath(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.NavMeshPath arg1 = (UnityEngine.NavMeshPath)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.NavMeshAgent)vc.csObj).CalculatePath(arg0, arg1)));
        }
        return true;
    }
    static bool NavMeshAgent_CompleteOffMeshLink(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.NavMeshAgent)vc.csObj).CompleteOffMeshLink();
        }
        return true;
    }
    static bool NavMeshAgent_FindClosestEdge__NavMeshHit(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int r_arg0 = JSApi.incArgIndex();
            UnityEngine.NavMeshHit arg0;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.NavMeshAgent)vc.csObj).FindClosestEdge(out arg0)));
            JSApi.setArgIndex(r_arg0);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg0);
        }
        return true;
    }
    static bool NavMeshAgent_GetLayerCost__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(((UnityEngine.NavMeshAgent)vc.csObj).GetLayerCost(arg0)));
        }
        return true;
    }
    static bool NavMeshAgent_Move__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.NavMeshAgent)vc.csObj).Move(arg0);
        }
        return true;
    }
    static bool NavMeshAgent_Raycast__Vector3__NavMeshHit(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg1 = JSApi.incArgIndex();
            UnityEngine.NavMeshHit arg1;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.NavMeshAgent)vc.csObj).Raycast(arg0, out arg1)));
            JSApi.setArgIndex(r_arg1);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg1);
        }
        return true;
    }
    static bool NavMeshAgent_ResetPath(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.NavMeshAgent)vc.csObj).ResetPath();
        }
        return true;
    }
    static bool NavMeshAgent_Resume(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.NavMeshAgent)vc.csObj).Resume();
        }
        return true;
    }
    static bool NavMeshAgent_SamplePathPosition__Int32__Single__NavMeshHit(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.incArgIndex();
            UnityEngine.NavMeshHit arg2;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.NavMeshAgent)vc.csObj).SamplePathPosition(arg0, arg1, out arg2)));
            JSApi.setArgIndex(r_arg2);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool NavMeshAgent_SetDestination__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.NavMeshAgent)vc.csObj).SetDestination(arg0)));
        }
        return true;
    }
    static bool NavMeshAgent_SetLayerCost__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.NavMeshAgent)vc.csObj).SetLayerCost(arg0, arg1);
        }
        return true;
    }
    static bool NavMeshAgent_SetPath__NavMeshPath(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.NavMeshPath arg0 = (UnityEngine.NavMeshPath)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.NavMeshAgent)vc.csObj).SetPath(arg0)));
        }
        return true;
    }
    static bool NavMeshAgent_Stop(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.NavMeshAgent)vc.csObj).Stop();
        }
        return true;
    }
    static bool NavMeshAgent_Stop__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            ((UnityEngine.NavMeshAgent)vc.csObj).Stop(arg0);
        }
        return true;
    }
    static bool NavMeshAgent_Warp__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.NavMeshAgent)vc.csObj).Warp(arg0)));
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.NavMeshAgent);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            NavMeshAgent_acceleration,
            NavMeshAgent_angularSpeed,
            NavMeshAgent_autoBraking,
            NavMeshAgent_autoRepath,
            NavMeshAgent_autoTraverseOffMeshLink,
            NavMeshAgent_avoidancePriority,
            NavMeshAgent_baseOffset,
            NavMeshAgent_currentOffMeshLinkData,
            NavMeshAgent_desiredVelocity,
            NavMeshAgent_destination,
            NavMeshAgent_hasPath,
            NavMeshAgent_height,
            NavMeshAgent_isOnOffMeshLink,
            NavMeshAgent_isPathStale,
            NavMeshAgent_nextOffMeshLinkData,
            NavMeshAgent_nextPosition,
            NavMeshAgent_obstacleAvoidanceType,
            NavMeshAgent_path,
            NavMeshAgent_pathEndPosition,
            NavMeshAgent_pathPending,
            NavMeshAgent_pathStatus,
            NavMeshAgent_radius,
            NavMeshAgent_remainingDistance,
            NavMeshAgent_speed,
            NavMeshAgent_steeringTarget,
            NavMeshAgent_stoppingDistance,
            NavMeshAgent_updatePosition,
            NavMeshAgent_updateRotation,
            NavMeshAgent_velocity,
            NavMeshAgent_walkableMask,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(NavMeshAgent_NavMeshAgent, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(NavMeshAgent_ActivateCurrentOffMeshLink__Boolean, "ActivateCurrentOffMeshLink"),
            new JSMgr.MethodCallBackInfo(NavMeshAgent_CalculatePath__Vector3__NavMeshPath, "CalculatePath"),
            new JSMgr.MethodCallBackInfo(NavMeshAgent_CompleteOffMeshLink, "CompleteOffMeshLink"),
            new JSMgr.MethodCallBackInfo(NavMeshAgent_FindClosestEdge__NavMeshHit, "FindClosestEdge"),
            new JSMgr.MethodCallBackInfo(NavMeshAgent_GetLayerCost__Int32, "GetLayerCost"),
            new JSMgr.MethodCallBackInfo(NavMeshAgent_Move__Vector3, "Move"),
            new JSMgr.MethodCallBackInfo(NavMeshAgent_Raycast__Vector3__NavMeshHit, "Raycast"),
            new JSMgr.MethodCallBackInfo(NavMeshAgent_ResetPath, "ResetPath"),
            new JSMgr.MethodCallBackInfo(NavMeshAgent_Resume, "Resume"),
            new JSMgr.MethodCallBackInfo(NavMeshAgent_SamplePathPosition__Int32__Single__NavMeshHit, "SamplePathPosition"),
            new JSMgr.MethodCallBackInfo(NavMeshAgent_SetDestination__Vector3, "SetDestination"),
            new JSMgr.MethodCallBackInfo(NavMeshAgent_SetLayerCost__Int32__Single, "SetLayerCost"),
            new JSMgr.MethodCallBackInfo(NavMeshAgent_SetPath__NavMeshPath, "SetPath"),
            new JSMgr.MethodCallBackInfo(NavMeshAgent_Stop, "Stop"),
            new JSMgr.MethodCallBackInfo(NavMeshAgent_Stop__Boolean, "Stop"),
            new JSMgr.MethodCallBackInfo(NavMeshAgent_Warp__Vector3, "Warp"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}