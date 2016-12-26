﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Rigidbody2D_G
{
    ////////////////////// Rigidbody2D ///////////////////////////////////////
    // constructors
    static bool Rigidbody2D_Rigidbody2D(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Rigidbody2D());
        }
        return true;
    }
    // fields
    // properties
    static void Rigidbody2D_angularDrag(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            var result = _this.angularDrag;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            _this.angularDrag = arg0;
        }
    }
    static void Rigidbody2D_angularVelocity(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            var result = _this.angularVelocity;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            _this.angularVelocity = arg0;
        }
    }
    static void Rigidbody2D_centerOfMass(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            var result = _this.centerOfMass;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            _this.centerOfMass = arg0;
        }
    }
    static void Rigidbody2D_collisionDetectionMode(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            var result = _this.collisionDetectionMode;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.CollisionDetectionMode2D arg0 = (UnityEngine.CollisionDetectionMode2D)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            _this.collisionDetectionMode = arg0;
        }
    }
    static void Rigidbody2D_constraints(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            var result = _this.constraints;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.RigidbodyConstraints2D arg0 = (UnityEngine.RigidbodyConstraints2D)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            _this.constraints = arg0;
        }
    }
    static void Rigidbody2D_drag(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            var result = _this.drag;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            _this.drag = arg0;
        }
    }
    static void Rigidbody2D_freezeRotation(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            var result = _this.freezeRotation;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            _this.freezeRotation = arg0;
        }
    }
    static void Rigidbody2D_gravityScale(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            var result = _this.gravityScale;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            _this.gravityScale = arg0;
        }
    }
    static void Rigidbody2D_inertia(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            var result = _this.inertia;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            _this.inertia = arg0;
        }
    }
    static void Rigidbody2D_interpolation(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            var result = _this.interpolation;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.RigidbodyInterpolation2D arg0 = (UnityEngine.RigidbodyInterpolation2D)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            _this.interpolation = arg0;
        }
    }
    static void Rigidbody2D_isKinematic(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            var result = _this.isKinematic;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            _this.isKinematic = arg0;
        }
    }
    static void Rigidbody2D_mass(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            var result = _this.mass;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            _this.mass = arg0;
        }
    }
    static void Rigidbody2D_position(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            var result = _this.position;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            _this.position = arg0;
        }
    }
    static void Rigidbody2D_rotation(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            var result = _this.rotation;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            _this.rotation = arg0;
        }
    }
    static void Rigidbody2D_simulated(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            var result = _this.simulated;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            _this.simulated = arg0;
        }
    }
    static void Rigidbody2D_sleepMode(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            var result = _this.sleepMode;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.RigidbodySleepMode2D arg0 = (UnityEngine.RigidbodySleepMode2D)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            _this.sleepMode = arg0;
        }
    }
    static void Rigidbody2D_useAutoMass(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            var result = _this.useAutoMass;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            _this.useAutoMass = arg0;
        }
    }
    static void Rigidbody2D_velocity(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            var result = _this.velocity;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
            _this.velocity = arg0;
        }
    }
    static void Rigidbody2D_worldCenterOfMass(JSVCall vc)
    {
        UnityEngine.Rigidbody2D _this = (UnityEngine.Rigidbody2D)vc.csObj;
        var result = _this.worldCenterOfMass;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    // methods
    static bool Rigidbody2D_AddForce__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody2D)vc.csObj).AddForce(arg0);
        }
        return true;
    }
    static bool Rigidbody2D_AddForce__Vector2__ForceMode2D(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.ForceMode2D arg1 = (UnityEngine.ForceMode2D)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody2D)vc.csObj).AddForce(arg0, arg1);
        }
        return true;
    }
    static bool Rigidbody2D_AddForceAtPosition__Vector2__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody2D)vc.csObj).AddForceAtPosition(arg0, arg1);
        }
        return true;
    }
    static bool Rigidbody2D_AddForceAtPosition__Vector2__Vector2__ForceMode2D(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.ForceMode2D arg2 = (UnityEngine.ForceMode2D)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody2D)vc.csObj).AddForceAtPosition(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Rigidbody2D_AddRelativeForce__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody2D)vc.csObj).AddRelativeForce(arg0);
        }
        return true;
    }
    static bool Rigidbody2D_AddRelativeForce__Vector2__ForceMode2D(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.ForceMode2D arg1 = (UnityEngine.ForceMode2D)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody2D)vc.csObj).AddRelativeForce(arg0, arg1);
        }
        return true;
    }
    static bool Rigidbody2D_AddTorque__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody2D)vc.csObj).AddTorque(arg0);
        }
        return true;
    }
    static bool Rigidbody2D_AddTorque__Single__ForceMode2D(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ForceMode2D arg1 = (UnityEngine.ForceMode2D)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody2D)vc.csObj).AddTorque(arg0, arg1);
        }
        return true;
    }
    static bool Rigidbody2D_Cast__Vector2__RaycastHit2D_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
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
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.Rigidbody2D)vc.csObj).Cast(arg0, arg1)));
        }
        return true;
    }
    static bool Rigidbody2D_Cast__Vector2__RaycastHit2D_Array__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
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
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.Rigidbody2D)vc.csObj).Cast(arg0, arg1, arg2)));
        }
        return true;
    }
    static bool Rigidbody2D_GetPoint__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Rigidbody2D)vc.csObj).GetPoint(arg0));
        }
        return true;
    }
    static bool Rigidbody2D_GetPointVelocity__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Rigidbody2D)vc.csObj).GetPointVelocity(arg0));
        }
        return true;
    }
    static bool Rigidbody2D_GetRelativePoint__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Rigidbody2D)vc.csObj).GetRelativePoint(arg0));
        }
        return true;
    }
    static bool Rigidbody2D_GetRelativePointVelocity__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Rigidbody2D)vc.csObj).GetRelativePointVelocity(arg0));
        }
        return true;
    }
    static bool Rigidbody2D_GetRelativeVector__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Rigidbody2D)vc.csObj).GetRelativeVector(arg0));
        }
        return true;
    }
    static bool Rigidbody2D_GetVector__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Rigidbody2D)vc.csObj).GetVector(arg0));
        }
        return true;
    }
    static bool Rigidbody2D_IsAwake(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Rigidbody2D)vc.csObj).IsAwake()));
        }
        return true;
    }
    static bool Rigidbody2D_IsSleeping(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Rigidbody2D)vc.csObj).IsSleeping()));
        }
        return true;
    }
    static bool Rigidbody2D_IsTouching__Collider2D(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Collider2D arg0 = (UnityEngine.Collider2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Rigidbody2D)vc.csObj).IsTouching(arg0)));
        }
        return true;
    }
    static bool Rigidbody2D_IsTouchingLayers(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Rigidbody2D)vc.csObj).IsTouchingLayers()));
        }
        return true;
    }
    static bool Rigidbody2D_IsTouchingLayers__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Rigidbody2D)vc.csObj).IsTouchingLayers(arg0)));
        }
        return true;
    }
    static bool Rigidbody2D_MovePosition__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody2D)vc.csObj).MovePosition(arg0);
        }
        return true;
    }
    static bool Rigidbody2D_MoveRotation__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody2D)vc.csObj).MoveRotation(arg0);
        }
        return true;
    }
    static bool Rigidbody2D_OverlapPoint__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Rigidbody2D)vc.csObj).OverlapPoint(arg0)));
        }
        return true;
    }
    static bool Rigidbody2D_Sleep(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Rigidbody2D)vc.csObj).Sleep();
        }
        return true;
    }
    static bool Rigidbody2D_WakeUp(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Rigidbody2D)vc.csObj).WakeUp();
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Rigidbody2D);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Rigidbody2D_angularDrag,
            Rigidbody2D_angularVelocity,
            Rigidbody2D_centerOfMass,
            Rigidbody2D_collisionDetectionMode,
            Rigidbody2D_constraints,
            Rigidbody2D_drag,
            Rigidbody2D_freezeRotation,
            Rigidbody2D_gravityScale,
            Rigidbody2D_inertia,
            Rigidbody2D_interpolation,
            Rigidbody2D_isKinematic,
            Rigidbody2D_mass,
            Rigidbody2D_position,
            Rigidbody2D_rotation,
            Rigidbody2D_simulated,
            Rigidbody2D_sleepMode,
            Rigidbody2D_useAutoMass,
            Rigidbody2D_velocity,
            Rigidbody2D_worldCenterOfMass,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Rigidbody2D_Rigidbody2D, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Rigidbody2D_AddForce__Vector2, "AddForce"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_AddForce__Vector2__ForceMode2D, "AddForce"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_AddForceAtPosition__Vector2__Vector2, "AddForceAtPosition"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_AddForceAtPosition__Vector2__Vector2__ForceMode2D, "AddForceAtPosition"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_AddRelativeForce__Vector2, "AddRelativeForce"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_AddRelativeForce__Vector2__ForceMode2D, "AddRelativeForce"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_AddTorque__Single, "AddTorque"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_AddTorque__Single__ForceMode2D, "AddTorque"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_Cast__Vector2__RaycastHit2D_Array, "Cast"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_Cast__Vector2__RaycastHit2D_Array__Single, "Cast"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_GetPoint__Vector2, "GetPoint"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_GetPointVelocity__Vector2, "GetPointVelocity"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_GetRelativePoint__Vector2, "GetRelativePoint"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_GetRelativePointVelocity__Vector2, "GetRelativePointVelocity"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_GetRelativeVector__Vector2, "GetRelativeVector"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_GetVector__Vector2, "GetVector"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_IsAwake, "IsAwake"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_IsSleeping, "IsSleeping"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_IsTouching__Collider2D, "IsTouching"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_IsTouchingLayers, "IsTouchingLayers"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_IsTouchingLayers__Int32, "IsTouchingLayers"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_MovePosition__Vector2, "MovePosition"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_MoveRotation__Single, "MoveRotation"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_OverlapPoint__Vector2, "OverlapPoint"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_Sleep, "Sleep"),
            new JSMgr.MethodCallBackInfo(Rigidbody2D_WakeUp, "WakeUp"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}