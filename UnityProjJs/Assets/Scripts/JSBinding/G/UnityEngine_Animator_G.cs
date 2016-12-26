﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Animator_G
{
    ////////////////////// Animator ///////////////////////////////////////
    // constructors
    static bool Animator_Animator(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Animator());
        }
        return true;
    }
    // fields
    // properties
    static void Animator_applyRootMotion(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            var result = _this.applyRootMotion;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            _this.applyRootMotion = arg0;
        }
    }
    static void Animator_avatar(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            var result = _this.avatar;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Avatar arg0 = (UnityEngine.Avatar)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            _this.avatar = arg0;
        }
    }
    static void Animator_bodyPosition(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            var result = _this.bodyPosition;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            _this.bodyPosition = arg0;
        }
    }
    static void Animator_bodyRotation(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            var result = _this.bodyRotation;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Quaternion arg0 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            _this.bodyRotation = arg0;
        }
    }
    static void Animator_cullingMode(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            var result = _this.cullingMode;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.AnimatorCullingMode arg0 = (UnityEngine.AnimatorCullingMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            _this.cullingMode = arg0;
        }
    }
    static void Animator_deltaPosition(JSVCall vc)
    {
        UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
        var result = _this.deltaPosition;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Animator_deltaRotation(JSVCall vc)
    {
        UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
        var result = _this.deltaRotation;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Animator_feetPivotActive(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            var result = _this.feetPivotActive;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            _this.feetPivotActive = arg0;
        }
    }
    static void Animator_fireEvents(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            var result = _this.fireEvents;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            _this.fireEvents = arg0;
        }
    }
    static void Animator_gravityWeight(JSVCall vc)
    {
        UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
        var result = _this.gravityWeight;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Animator_hasRootMotion(JSVCall vc)
    {
        UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
        var result = _this.hasRootMotion;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Animator_hasTransformHierarchy(JSVCall vc)
    {
        UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
        var result = _this.hasTransformHierarchy;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Animator_humanScale(JSVCall vc)
    {
        UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
        var result = _this.humanScale;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Animator_isHuman(JSVCall vc)
    {
        UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
        var result = _this.isHuman;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Animator_isMatchingTarget(JSVCall vc)
    {
        UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
        var result = _this.isMatchingTarget;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Animator_isOptimizable(JSVCall vc)
    {
        UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
        var result = _this.isOptimizable;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Animator_layerCount(JSVCall vc)
    {
        UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
        var result = _this.layerCount;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Animator_layersAffectMassCenter(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            var result = _this.layersAffectMassCenter;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            _this.layersAffectMassCenter = arg0;
        }
    }
    static void Animator_leftFeetBottomHeight(JSVCall vc)
    {
        UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
        var result = _this.leftFeetBottomHeight;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Animator_logWarnings(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            var result = _this.logWarnings;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            _this.logWarnings = arg0;
        }
    }
    static void Animator_pivotPosition(JSVCall vc)
    {
        UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
        var result = _this.pivotPosition;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Animator_pivotWeight(JSVCall vc)
    {
        UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
        var result = _this.pivotWeight;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Animator_playbackTime(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            var result = _this.playbackTime;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            _this.playbackTime = arg0;
        }
    }
    static void Animator_recorderStartTime(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            var result = _this.recorderStartTime;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            _this.recorderStartTime = arg0;
        }
    }
    static void Animator_recorderStopTime(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            var result = _this.recorderStopTime;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            _this.recorderStopTime = arg0;
        }
    }
    static void Animator_rightFeetBottomHeight(JSVCall vc)
    {
        UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
        var result = _this.rightFeetBottomHeight;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Animator_rootPosition(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            var result = _this.rootPosition;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            _this.rootPosition = arg0;
        }
    }
    static void Animator_rootRotation(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            var result = _this.rootRotation;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Quaternion arg0 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            _this.rootRotation = arg0;
        }
    }
    static void Animator_runtimeAnimatorController(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            var result = _this.runtimeAnimatorController;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.RuntimeAnimatorController arg0 = (UnityEngine.RuntimeAnimatorController)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            _this.runtimeAnimatorController = arg0;
        }
    }
    static void Animator_speed(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            var result = _this.speed;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            _this.speed = arg0;
        }
    }
    static void Animator_stabilizeFeet(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            var result = _this.stabilizeFeet;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            _this.stabilizeFeet = arg0;
        }
    }
    static void Animator_targetPosition(JSVCall vc)
    {
        UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
        var result = _this.targetPosition;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Animator_targetRotation(JSVCall vc)
    {
        UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
        var result = _this.targetRotation;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Animator_updateMode(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            var result = _this.updateMode;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.AnimatorUpdateMode arg0 = (UnityEngine.AnimatorUpdateMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Animator _this = (UnityEngine.Animator)vc.csObj;
            _this.updateMode = arg0;
        }
    }
    // methods
    static bool Animator_CrossFade__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).CrossFade(arg0, arg1);
        }
        return true;
    }
    static bool Animator_CrossFade__Int32__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).CrossFade(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Animator_CrossFade__Int32__Single__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).CrossFade(arg0, arg1, arg2, arg3);
        }
        return true;
    }
    static bool Animator_CrossFade__String__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).CrossFade(arg0, arg1);
        }
        return true;
    }
    static bool Animator_CrossFade__String__Single__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).CrossFade(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Animator_CrossFade__String__Single__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            int arg2 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).CrossFade(arg0, arg1, arg2, arg3);
        }
        return true;
    }
    static bool Animator_GetAnimatorTransitionInfo__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Animator)vc.csObj).GetAnimatorTransitionInfo(arg0));
        }
        return true;
    }
    static bool Animator_GetBoneTransform__HumanBodyBones(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.HumanBodyBones arg0 = (UnityEngine.HumanBodyBones)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Animator)vc.csObj).GetBoneTransform(arg0));
        }
        return true;
    }
    static bool Animator_GetBool__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Animator)vc.csObj).GetBool(arg0)));
        }
        return true;
    }
    static bool Animator_GetBool__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Animator)vc.csObj).GetBool(arg0)));
        }
        return true;
    }
    static bool Animator_GetCurrentAnimationClipState__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.AnimationInfo[])((UnityEngine.Animator)vc.csObj).GetCurrentAnimationClipState(arg0);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Animator_GetCurrentAnimatorStateInfo__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Animator)vc.csObj).GetCurrentAnimatorStateInfo(arg0));
        }
        return true;
    }
    static bool Animator_GetFloat__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(((UnityEngine.Animator)vc.csObj).GetFloat(arg0)));
        }
        return true;
    }
    static bool Animator_GetFloat__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(((UnityEngine.Animator)vc.csObj).GetFloat(arg0)));
        }
        return true;
    }
    static bool Animator_GetIKPosition__AvatarIKGoal(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.AvatarIKGoal arg0 = (UnityEngine.AvatarIKGoal)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Animator)vc.csObj).GetIKPosition(arg0));
        }
        return true;
    }
    static bool Animator_GetIKPositionWeight__AvatarIKGoal(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.AvatarIKGoal arg0 = (UnityEngine.AvatarIKGoal)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(((UnityEngine.Animator)vc.csObj).GetIKPositionWeight(arg0)));
        }
        return true;
    }
    static bool Animator_GetIKRotation__AvatarIKGoal(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.AvatarIKGoal arg0 = (UnityEngine.AvatarIKGoal)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Animator)vc.csObj).GetIKRotation(arg0));
        }
        return true;
    }
    static bool Animator_GetIKRotationWeight__AvatarIKGoal(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.AvatarIKGoal arg0 = (UnityEngine.AvatarIKGoal)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(((UnityEngine.Animator)vc.csObj).GetIKRotationWeight(arg0)));
        }
        return true;
    }
    static bool Animator_GetInteger__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.Animator)vc.csObj).GetInteger(arg0)));
        }
        return true;
    }
    static bool Animator_GetInteger__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.Animator)vc.csObj).GetInteger(arg0)));
        }
        return true;
    }
    static bool Animator_GetLayerName__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setStringS((int)JSApi.SetType.Rval, ((UnityEngine.Animator)vc.csObj).GetLayerName(arg0));
        }
        return true;
    }
    static bool Animator_GetLayerWeight__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(((UnityEngine.Animator)vc.csObj).GetLayerWeight(arg0)));
        }
        return true;
    }
    static bool Animator_GetNextAnimationClipState__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.AnimationInfo[])((UnityEngine.Animator)vc.csObj).GetNextAnimationClipState(arg0);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Animator_GetNextAnimatorStateInfo__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Animator)vc.csObj).GetNextAnimatorStateInfo(arg0));
        }
        return true;
    }
    static bool Animator_InterruptMatchTarget(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Animator)vc.csObj).InterruptMatchTarget();
        }
        return true;
    }
    static bool Animator_InterruptMatchTarget__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).InterruptMatchTarget(arg0);
        }
        return true;
    }
    static bool Animator_IsInTransition__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Animator)vc.csObj).IsInTransition(arg0)));
        }
        return true;
    }
    static bool Animator_IsParameterControlledByCurve__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Animator)vc.csObj).IsParameterControlledByCurve(arg0)));
        }
        return true;
    }
    static bool Animator_IsParameterControlledByCurve__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Animator)vc.csObj).IsParameterControlledByCurve(arg0)));
        }
        return true;
    }
    static bool Animator_MatchTarget__Vector3__Quaternion__AvatarTarget__MatchTargetWeightMask__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg1 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.AvatarTarget arg2 = (UnityEngine.AvatarTarget)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.MatchTargetWeightMask arg3 = (UnityEngine.MatchTargetWeightMask)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).MatchTarget(arg0, arg1, arg2, arg3, arg4);
        }
        return true;
    }
    static bool Animator_MatchTarget__Vector3__Quaternion__AvatarTarget__MatchTargetWeightMask__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg1 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.AvatarTarget arg2 = (UnityEngine.AvatarTarget)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.MatchTargetWeightMask arg3 = (UnityEngine.MatchTargetWeightMask)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).MatchTarget(arg0, arg1, arg2, arg3, arg4, arg5);
        }
        return true;
    }
    static bool Animator_Play__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).Play(arg0);
        }
        return true;
    }
    static bool Animator_Play__Int32__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).Play(arg0, arg1);
        }
        return true;
    }
    static bool Animator_Play__Int32__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).Play(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Animator_Play__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).Play(arg0);
        }
        return true;
    }
    static bool Animator_Play__String__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).Play(arg0, arg1);
        }
        return true;
    }
    static bool Animator_Play__String__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).Play(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Animator_Rebind(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Animator)vc.csObj).Rebind();
        }
        return true;
    }
    static bool Animator_ResetTrigger__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).ResetTrigger(arg0);
        }
        return true;
    }
    static bool Animator_ResetTrigger__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).ResetTrigger(arg0);
        }
        return true;
    }
    static bool Animator_SetBool__Int32__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            bool arg1 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetBool(arg0, arg1);
        }
        return true;
    }
    static bool Animator_SetBool__String__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            bool arg1 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetBool(arg0, arg1);
        }
        return true;
    }
    static bool Animator_SetFloat__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetFloat(arg0, arg1);
        }
        return true;
    }
    static bool Animator_SetFloat__Int32__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetFloat(arg0, arg1, arg2, arg3);
        }
        return true;
    }
    static bool Animator_SetFloat__String__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetFloat(arg0, arg1);
        }
        return true;
    }
    static bool Animator_SetFloat__String__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetFloat(arg0, arg1, arg2, arg3);
        }
        return true;
    }
    static bool Animator_SetIKPosition__AvatarIKGoal__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.AvatarIKGoal arg0 = (UnityEngine.AvatarIKGoal)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetIKPosition(arg0, arg1);
        }
        return true;
    }
    static bool Animator_SetIKPositionWeight__AvatarIKGoal__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.AvatarIKGoal arg0 = (UnityEngine.AvatarIKGoal)JSApi.getEnum((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetIKPositionWeight(arg0, arg1);
        }
        return true;
    }
    static bool Animator_SetIKRotation__AvatarIKGoal__Quaternion(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.AvatarIKGoal arg0 = (UnityEngine.AvatarIKGoal)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg1 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetIKRotation(arg0, arg1);
        }
        return true;
    }
    static bool Animator_SetIKRotationWeight__AvatarIKGoal__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.AvatarIKGoal arg0 = (UnityEngine.AvatarIKGoal)JSApi.getEnum((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetIKRotationWeight(arg0, arg1);
        }
        return true;
    }
    static bool Animator_SetInteger__Int32__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetInteger(arg0, arg1);
        }
        return true;
    }
    static bool Animator_SetInteger__String__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetInteger(arg0, arg1);
        }
        return true;
    }
    static bool Animator_SetLayerWeight__Int32__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetLayerWeight(arg0, arg1);
        }
        return true;
    }
    static bool Animator_SetLookAtPosition__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetLookAtPosition(arg0);
        }
        return true;
    }
    static bool Animator_SetLookAtWeight__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetLookAtWeight(arg0);
        }
        return true;
    }
    static bool Animator_SetLookAtWeight__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetLookAtWeight(arg0, arg1);
        }
        return true;
    }
    static bool Animator_SetLookAtWeight__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetLookAtWeight(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Animator_SetLookAtWeight__Single__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetLookAtWeight(arg0, arg1, arg2, arg3);
        }
        return true;
    }
    static bool Animator_SetLookAtWeight__Single__Single__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetLookAtWeight(arg0, arg1, arg2, arg3, arg4);
        }
        return true;
    }
    static bool Animator_SetTarget__AvatarTarget__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.AvatarTarget arg0 = (UnityEngine.AvatarTarget)JSApi.getEnum((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetTarget(arg0, arg1);
        }
        return true;
    }
    static bool Animator_SetTrigger__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetTrigger(arg0);
        }
        return true;
    }
    static bool Animator_SetTrigger__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).SetTrigger(arg0);
        }
        return true;
    }
    static bool Animator_StartPlayback(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Animator)vc.csObj).StartPlayback();
        }
        return true;
    }
    static bool Animator_StartRecording__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).StartRecording(arg0);
        }
        return true;
    }
    static bool Animator_StopPlayback(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Animator)vc.csObj).StopPlayback();
        }
        return true;
    }
    static bool Animator_StopRecording(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Animator)vc.csObj).StopRecording();
        }
        return true;
    }
    static bool Animator_Update__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Animator)vc.csObj).Update(arg0);
        }
        return true;
    }
    static bool Animator_StringToHash__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Animator.StringToHash(arg0)));
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Animator);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Animator_applyRootMotion,
            Animator_avatar,
            Animator_bodyPosition,
            Animator_bodyRotation,
            Animator_cullingMode,
            Animator_deltaPosition,
            Animator_deltaRotation,
            Animator_feetPivotActive,
            Animator_fireEvents,
            Animator_gravityWeight,
            Animator_hasRootMotion,
            Animator_hasTransformHierarchy,
            Animator_humanScale,
            Animator_isHuman,
            Animator_isMatchingTarget,
            Animator_isOptimizable,
            Animator_layerCount,
            Animator_layersAffectMassCenter,
            Animator_leftFeetBottomHeight,
            Animator_logWarnings,
            Animator_pivotPosition,
            Animator_pivotWeight,
            Animator_playbackTime,
            Animator_recorderStartTime,
            Animator_recorderStopTime,
            Animator_rightFeetBottomHeight,
            Animator_rootPosition,
            Animator_rootRotation,
            Animator_runtimeAnimatorController,
            Animator_speed,
            Animator_stabilizeFeet,
            Animator_targetPosition,
            Animator_targetRotation,
            Animator_updateMode,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Animator_Animator, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Animator_CrossFade__Int32__Single, "CrossFade"),
            new JSMgr.MethodCallBackInfo(Animator_CrossFade__Int32__Single__Int32, "CrossFade"),
            new JSMgr.MethodCallBackInfo(Animator_CrossFade__Int32__Single__Int32__Single, "CrossFade"),
            new JSMgr.MethodCallBackInfo(Animator_CrossFade__String__Single, "CrossFade"),
            new JSMgr.MethodCallBackInfo(Animator_CrossFade__String__Single__Int32, "CrossFade"),
            new JSMgr.MethodCallBackInfo(Animator_CrossFade__String__Single__Int32__Single, "CrossFade"),
            new JSMgr.MethodCallBackInfo(Animator_GetAnimatorTransitionInfo__Int32, "GetAnimatorTransitionInfo"),
            new JSMgr.MethodCallBackInfo(Animator_GetBoneTransform__HumanBodyBones, "GetBoneTransform"),
            new JSMgr.MethodCallBackInfo(Animator_GetBool__Int32, "GetBool"),
            new JSMgr.MethodCallBackInfo(Animator_GetBool__String, "GetBool"),
            new JSMgr.MethodCallBackInfo(Animator_GetCurrentAnimationClipState__Int32, "GetCurrentAnimationClipState"),
            new JSMgr.MethodCallBackInfo(Animator_GetCurrentAnimatorStateInfo__Int32, "GetCurrentAnimatorStateInfo"),
            new JSMgr.MethodCallBackInfo(Animator_GetFloat__Int32, "GetFloat"),
            new JSMgr.MethodCallBackInfo(Animator_GetFloat__String, "GetFloat"),
            new JSMgr.MethodCallBackInfo(Animator_GetIKPosition__AvatarIKGoal, "GetIKPosition"),
            new JSMgr.MethodCallBackInfo(Animator_GetIKPositionWeight__AvatarIKGoal, "GetIKPositionWeight"),
            new JSMgr.MethodCallBackInfo(Animator_GetIKRotation__AvatarIKGoal, "GetIKRotation"),
            new JSMgr.MethodCallBackInfo(Animator_GetIKRotationWeight__AvatarIKGoal, "GetIKRotationWeight"),
            new JSMgr.MethodCallBackInfo(Animator_GetInteger__Int32, "GetInteger"),
            new JSMgr.MethodCallBackInfo(Animator_GetInteger__String, "GetInteger"),
            new JSMgr.MethodCallBackInfo(Animator_GetLayerName__Int32, "GetLayerName"),
            new JSMgr.MethodCallBackInfo(Animator_GetLayerWeight__Int32, "GetLayerWeight"),
            new JSMgr.MethodCallBackInfo(Animator_GetNextAnimationClipState__Int32, "GetNextAnimationClipState"),
            new JSMgr.MethodCallBackInfo(Animator_GetNextAnimatorStateInfo__Int32, "GetNextAnimatorStateInfo"),
            new JSMgr.MethodCallBackInfo(Animator_InterruptMatchTarget, "InterruptMatchTarget"),
            new JSMgr.MethodCallBackInfo(Animator_InterruptMatchTarget__Boolean, "InterruptMatchTarget"),
            new JSMgr.MethodCallBackInfo(Animator_IsInTransition__Int32, "IsInTransition"),
            new JSMgr.MethodCallBackInfo(Animator_IsParameterControlledByCurve__Int32, "IsParameterControlledByCurve"),
            new JSMgr.MethodCallBackInfo(Animator_IsParameterControlledByCurve__String, "IsParameterControlledByCurve"),
            new JSMgr.MethodCallBackInfo(Animator_MatchTarget__Vector3__Quaternion__AvatarTarget__MatchTargetWeightMask__Single, "MatchTarget"),
            new JSMgr.MethodCallBackInfo(Animator_MatchTarget__Vector3__Quaternion__AvatarTarget__MatchTargetWeightMask__Single__Single, "MatchTarget"),
            new JSMgr.MethodCallBackInfo(Animator_Play__Int32, "Play"),
            new JSMgr.MethodCallBackInfo(Animator_Play__Int32__Int32, "Play"),
            new JSMgr.MethodCallBackInfo(Animator_Play__Int32__Int32__Single, "Play"),
            new JSMgr.MethodCallBackInfo(Animator_Play__String, "Play"),
            new JSMgr.MethodCallBackInfo(Animator_Play__String__Int32, "Play"),
            new JSMgr.MethodCallBackInfo(Animator_Play__String__Int32__Single, "Play"),
            new JSMgr.MethodCallBackInfo(Animator_Rebind, "Rebind"),
            new JSMgr.MethodCallBackInfo(Animator_ResetTrigger__Int32, "ResetTrigger"),
            new JSMgr.MethodCallBackInfo(Animator_ResetTrigger__String, "ResetTrigger"),
            new JSMgr.MethodCallBackInfo(Animator_SetBool__Int32__Boolean, "SetBool"),
            new JSMgr.MethodCallBackInfo(Animator_SetBool__String__Boolean, "SetBool"),
            new JSMgr.MethodCallBackInfo(Animator_SetFloat__Int32__Single, "SetFloat"),
            new JSMgr.MethodCallBackInfo(Animator_SetFloat__Int32__Single__Single__Single, "SetFloat"),
            new JSMgr.MethodCallBackInfo(Animator_SetFloat__String__Single, "SetFloat"),
            new JSMgr.MethodCallBackInfo(Animator_SetFloat__String__Single__Single__Single, "SetFloat"),
            new JSMgr.MethodCallBackInfo(Animator_SetIKPosition__AvatarIKGoal__Vector3, "SetIKPosition"),
            new JSMgr.MethodCallBackInfo(Animator_SetIKPositionWeight__AvatarIKGoal__Single, "SetIKPositionWeight"),
            new JSMgr.MethodCallBackInfo(Animator_SetIKRotation__AvatarIKGoal__Quaternion, "SetIKRotation"),
            new JSMgr.MethodCallBackInfo(Animator_SetIKRotationWeight__AvatarIKGoal__Single, "SetIKRotationWeight"),
            new JSMgr.MethodCallBackInfo(Animator_SetInteger__Int32__Int32, "SetInteger"),
            new JSMgr.MethodCallBackInfo(Animator_SetInteger__String__Int32, "SetInteger"),
            new JSMgr.MethodCallBackInfo(Animator_SetLayerWeight__Int32__Single, "SetLayerWeight"),
            new JSMgr.MethodCallBackInfo(Animator_SetLookAtPosition__Vector3, "SetLookAtPosition"),
            new JSMgr.MethodCallBackInfo(Animator_SetLookAtWeight__Single, "SetLookAtWeight"),
            new JSMgr.MethodCallBackInfo(Animator_SetLookAtWeight__Single__Single, "SetLookAtWeight"),
            new JSMgr.MethodCallBackInfo(Animator_SetLookAtWeight__Single__Single__Single, "SetLookAtWeight"),
            new JSMgr.MethodCallBackInfo(Animator_SetLookAtWeight__Single__Single__Single__Single, "SetLookAtWeight"),
            new JSMgr.MethodCallBackInfo(Animator_SetLookAtWeight__Single__Single__Single__Single__Single, "SetLookAtWeight"),
            new JSMgr.MethodCallBackInfo(Animator_SetTarget__AvatarTarget__Single, "SetTarget"),
            new JSMgr.MethodCallBackInfo(Animator_SetTrigger__Int32, "SetTrigger"),
            new JSMgr.MethodCallBackInfo(Animator_SetTrigger__String, "SetTrigger"),
            new JSMgr.MethodCallBackInfo(Animator_StartPlayback, "StartPlayback"),
            new JSMgr.MethodCallBackInfo(Animator_StartRecording__Int32, "StartRecording"),
            new JSMgr.MethodCallBackInfo(Animator_StopPlayback, "StopPlayback"),
            new JSMgr.MethodCallBackInfo(Animator_StopRecording, "StopRecording"),
            new JSMgr.MethodCallBackInfo(Animator_Update__Single, "Update"),
            new JSMgr.MethodCallBackInfo(Animator_StringToHash__String, "StringToHash"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}