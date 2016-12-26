
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Rigidbody_G
{
    ////////////////////// Rigidbody ///////////////////////////////////////
    // constructors
    static bool Rigidbody_Rigidbody(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Rigidbody());
        }
        return true;
    }
    // fields
    // properties
    static void Rigidbody_angularDrag(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.angularDrag;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.angularDrag = arg0;
        }
    }
    static void Rigidbody_angularVelocity(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.angularVelocity;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.angularVelocity = arg0;
        }
    }
    static void Rigidbody_centerOfMass(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.centerOfMass;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.centerOfMass = arg0;
        }
    }
    static void Rigidbody_collisionDetectionMode(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.collisionDetectionMode;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.CollisionDetectionMode arg0 = (UnityEngine.CollisionDetectionMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.collisionDetectionMode = arg0;
        }
    }
    static void Rigidbody_constraints(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.constraints;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.RigidbodyConstraints arg0 = (UnityEngine.RigidbodyConstraints)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.constraints = arg0;
        }
    }
    static void Rigidbody_detectCollisions(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.detectCollisions;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.detectCollisions = arg0;
        }
    }
    static void Rigidbody_drag(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.drag;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.drag = arg0;
        }
    }
    static void Rigidbody_freezeRotation(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.freezeRotation;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.freezeRotation = arg0;
        }
    }
    static void Rigidbody_inertiaTensor(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.inertiaTensor;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.inertiaTensor = arg0;
        }
    }
    static void Rigidbody_inertiaTensorRotation(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.inertiaTensorRotation;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Quaternion arg0 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.inertiaTensorRotation = arg0;
        }
    }
    static void Rigidbody_interpolation(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.interpolation;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.RigidbodyInterpolation arg0 = (UnityEngine.RigidbodyInterpolation)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.interpolation = arg0;
        }
    }
    static void Rigidbody_isKinematic(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.isKinematic;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.isKinematic = arg0;
        }
    }
    static void Rigidbody_mass(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.mass;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.mass = arg0;
        }
    }
    static void Rigidbody_maxAngularVelocity(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.maxAngularVelocity;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.maxAngularVelocity = arg0;
        }
    }
    static void Rigidbody_position(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.position;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.position = arg0;
        }
    }
    static void Rigidbody_rotation(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.rotation;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Quaternion arg0 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.rotation = arg0;
        }
    }
    static void Rigidbody_sleepAngularVelocity(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.sleepAngularVelocity;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.sleepAngularVelocity = arg0;
        }
    }
    static void Rigidbody_sleepVelocity(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.sleepVelocity;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.sleepVelocity = arg0;
        }
    }
    static void Rigidbody_solverIterationCount(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.solverIterationCount;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.solverIterationCount = arg0;
        }
    }
    static void Rigidbody_useConeFriction(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.useConeFriction;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.useConeFriction = arg0;
        }
    }
    static void Rigidbody_useGravity(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.useGravity;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.useGravity = arg0;
        }
    }
    static void Rigidbody_velocity(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            var result = _this.velocity;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
            _this.velocity = arg0;
        }
    }
    static void Rigidbody_worldCenterOfMass(JSVCall vc)
    {
        UnityEngine.Rigidbody _this = (UnityEngine.Rigidbody)vc.csObj;
        var result = _this.worldCenterOfMass;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    // methods
    static bool Rigidbody_AddExplosionForce__Single__Vector3__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).AddExplosionForce(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Rigidbody_AddExplosionForce__Single__Vector3__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).AddExplosionForce(arg0, arg1, arg2, arg3);
        }
        return true;
    }
    static bool Rigidbody_AddExplosionForce__Single__Vector3__Single__Single__ForceMode(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ForceMode arg4 = (UnityEngine.ForceMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).AddExplosionForce(arg0, arg1, arg2, arg3, arg4);
        }
        return true;
    }
    static bool Rigidbody_AddForce__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).AddForce(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Rigidbody_AddForce__Single__Single__Single__ForceMode(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ForceMode arg3 = (UnityEngine.ForceMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).AddForce(arg0, arg1, arg2, arg3);
        }
        return true;
    }
    static bool Rigidbody_AddForce__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).AddForce(arg0);
        }
        return true;
    }
    static bool Rigidbody_AddForce__Vector3__ForceMode(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.ForceMode arg1 = (UnityEngine.ForceMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).AddForce(arg0, arg1);
        }
        return true;
    }
    static bool Rigidbody_AddForceAtPosition__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).AddForceAtPosition(arg0, arg1);
        }
        return true;
    }
    static bool Rigidbody_AddForceAtPosition__Vector3__Vector3__ForceMode(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.ForceMode arg2 = (UnityEngine.ForceMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).AddForceAtPosition(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Rigidbody_AddRelativeForce__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).AddRelativeForce(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Rigidbody_AddRelativeForce__Single__Single__Single__ForceMode(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ForceMode arg3 = (UnityEngine.ForceMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).AddRelativeForce(arg0, arg1, arg2, arg3);
        }
        return true;
    }
    static bool Rigidbody_AddRelativeForce__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).AddRelativeForce(arg0);
        }
        return true;
    }
    static bool Rigidbody_AddRelativeForce__Vector3__ForceMode(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.ForceMode arg1 = (UnityEngine.ForceMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).AddRelativeForce(arg0, arg1);
        }
        return true;
    }
    static bool Rigidbody_AddRelativeTorque__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).AddRelativeTorque(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Rigidbody_AddRelativeTorque__Single__Single__Single__ForceMode(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ForceMode arg3 = (UnityEngine.ForceMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).AddRelativeTorque(arg0, arg1, arg2, arg3);
        }
        return true;
    }
    static bool Rigidbody_AddRelativeTorque__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).AddRelativeTorque(arg0);
        }
        return true;
    }
    static bool Rigidbody_AddRelativeTorque__Vector3__ForceMode(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.ForceMode arg1 = (UnityEngine.ForceMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).AddRelativeTorque(arg0, arg1);
        }
        return true;
    }
    static bool Rigidbody_AddTorque__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).AddTorque(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Rigidbody_AddTorque__Single__Single__Single__ForceMode(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ForceMode arg3 = (UnityEngine.ForceMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).AddTorque(arg0, arg1, arg2, arg3);
        }
        return true;
    }
    static bool Rigidbody_AddTorque__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).AddTorque(arg0);
        }
        return true;
    }
    static bool Rigidbody_AddTorque__Vector3__ForceMode(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.ForceMode arg1 = (UnityEngine.ForceMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).AddTorque(arg0, arg1);
        }
        return true;
    }
    static bool Rigidbody_ClosestPointOnBounds__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Rigidbody)vc.csObj).ClosestPointOnBounds(arg0));
        }
        return true;
    }
    static bool Rigidbody_GetPointVelocity__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Rigidbody)vc.csObj).GetPointVelocity(arg0));
        }
        return true;
    }
    static bool Rigidbody_GetRelativePointVelocity__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Rigidbody)vc.csObj).GetRelativePointVelocity(arg0));
        }
        return true;
    }
    static bool Rigidbody_IsSleeping(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Rigidbody)vc.csObj).IsSleeping()));
        }
        return true;
    }
    static bool Rigidbody_MovePosition__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).MovePosition(arg0);
        }
        return true;
    }
    static bool Rigidbody_MoveRotation__Quaternion(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Quaternion arg0 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).MoveRotation(arg0);
        }
        return true;
    }
    static bool Rigidbody_SetDensity__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Rigidbody)vc.csObj).SetDensity(arg0);
        }
        return true;
    }
    static bool Rigidbody_Sleep(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Rigidbody)vc.csObj).Sleep();
        }
        return true;
    }
    static bool Rigidbody_SweepTest__Vector3__RaycastHit(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg1 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg1;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Rigidbody)vc.csObj).SweepTest(arg0, out arg1)));
            JSApi.setArgIndex(r_arg1);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg1);
        }
        return true;
    }
    static bool Rigidbody_SweepTest__Vector3__RaycastHit__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg1 = JSApi.incArgIndex();
            UnityEngine.RaycastHit arg1;
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Rigidbody)vc.csObj).SweepTest(arg0, out arg1, arg2)));
            JSApi.setArgIndex(r_arg1);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg1);
        }
        return true;
    }
    static bool Rigidbody_SweepTestAll__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])((UnityEngine.Rigidbody)vc.csObj).SweepTestAll(arg0);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Rigidbody_SweepTestAll__Vector3__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.RaycastHit[])((UnityEngine.Rigidbody)vc.csObj).SweepTestAll(arg0, arg1);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Rigidbody_WakeUp(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Rigidbody)vc.csObj).WakeUp();
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Rigidbody);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Rigidbody_angularDrag,
            Rigidbody_angularVelocity,
            Rigidbody_centerOfMass,
            Rigidbody_collisionDetectionMode,
            Rigidbody_constraints,
            Rigidbody_detectCollisions,
            Rigidbody_drag,
            Rigidbody_freezeRotation,
            Rigidbody_inertiaTensor,
            Rigidbody_inertiaTensorRotation,
            Rigidbody_interpolation,
            Rigidbody_isKinematic,
            Rigidbody_mass,
            Rigidbody_maxAngularVelocity,
            Rigidbody_position,
            Rigidbody_rotation,
            Rigidbody_sleepAngularVelocity,
            Rigidbody_sleepVelocity,
            Rigidbody_solverIterationCount,
            Rigidbody_useConeFriction,
            Rigidbody_useGravity,
            Rigidbody_velocity,
            Rigidbody_worldCenterOfMass,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Rigidbody_Rigidbody, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Rigidbody_AddExplosionForce__Single__Vector3__Single, "AddExplosionForce"),
            new JSMgr.MethodCallBackInfo(Rigidbody_AddExplosionForce__Single__Vector3__Single__Single, "AddExplosionForce"),
            new JSMgr.MethodCallBackInfo(Rigidbody_AddExplosionForce__Single__Vector3__Single__Single__ForceMode, "AddExplosionForce"),
            new JSMgr.MethodCallBackInfo(Rigidbody_AddForce__Single__Single__Single, "AddForce"),
            new JSMgr.MethodCallBackInfo(Rigidbody_AddForce__Single__Single__Single__ForceMode, "AddForce"),
            new JSMgr.MethodCallBackInfo(Rigidbody_AddForce__Vector3, "AddForce"),
            new JSMgr.MethodCallBackInfo(Rigidbody_AddForce__Vector3__ForceMode, "AddForce"),
            new JSMgr.MethodCallBackInfo(Rigidbody_AddForceAtPosition__Vector3__Vector3, "AddForceAtPosition"),
            new JSMgr.MethodCallBackInfo(Rigidbody_AddForceAtPosition__Vector3__Vector3__ForceMode, "AddForceAtPosition"),
            new JSMgr.MethodCallBackInfo(Rigidbody_AddRelativeForce__Single__Single__Single, "AddRelativeForce"),
            new JSMgr.MethodCallBackInfo(Rigidbody_AddRelativeForce__Single__Single__Single__ForceMode, "AddRelativeForce"),
            new JSMgr.MethodCallBackInfo(Rigidbody_AddRelativeForce__Vector3, "AddRelativeForce"),
            new JSMgr.MethodCallBackInfo(Rigidbody_AddRelativeForce__Vector3__ForceMode, "AddRelativeForce"),
            new JSMgr.MethodCallBackInfo(Rigidbody_AddRelativeTorque__Single__Single__Single, "AddRelativeTorque"),
            new JSMgr.MethodCallBackInfo(Rigidbody_AddRelativeTorque__Single__Single__Single__ForceMode, "AddRelativeTorque"),
            new JSMgr.MethodCallBackInfo(Rigidbody_AddRelativeTorque__Vector3, "AddRelativeTorque"),
            new JSMgr.MethodCallBackInfo(Rigidbody_AddRelativeTorque__Vector3__ForceMode, "AddRelativeTorque"),
            new JSMgr.MethodCallBackInfo(Rigidbody_AddTorque__Single__Single__Single, "AddTorque"),
            new JSMgr.MethodCallBackInfo(Rigidbody_AddTorque__Single__Single__Single__ForceMode, "AddTorque"),
            new JSMgr.MethodCallBackInfo(Rigidbody_AddTorque__Vector3, "AddTorque"),
            new JSMgr.MethodCallBackInfo(Rigidbody_AddTorque__Vector3__ForceMode, "AddTorque"),
            new JSMgr.MethodCallBackInfo(Rigidbody_ClosestPointOnBounds__Vector3, "ClosestPointOnBounds"),
            new JSMgr.MethodCallBackInfo(Rigidbody_GetPointVelocity__Vector3, "GetPointVelocity"),
            new JSMgr.MethodCallBackInfo(Rigidbody_GetRelativePointVelocity__Vector3, "GetRelativePointVelocity"),
            new JSMgr.MethodCallBackInfo(Rigidbody_IsSleeping, "IsSleeping"),
            new JSMgr.MethodCallBackInfo(Rigidbody_MovePosition__Vector3, "MovePosition"),
            new JSMgr.MethodCallBackInfo(Rigidbody_MoveRotation__Quaternion, "MoveRotation"),
            new JSMgr.MethodCallBackInfo(Rigidbody_SetDensity__Single, "SetDensity"),
            new JSMgr.MethodCallBackInfo(Rigidbody_Sleep, "Sleep"),
            new JSMgr.MethodCallBackInfo(Rigidbody_SweepTest__Vector3__RaycastHit, "SweepTest"),
            new JSMgr.MethodCallBackInfo(Rigidbody_SweepTest__Vector3__RaycastHit__Single, "SweepTest"),
            new JSMgr.MethodCallBackInfo(Rigidbody_SweepTestAll__Vector3, "SweepTestAll"),
            new JSMgr.MethodCallBackInfo(Rigidbody_SweepTestAll__Vector3__Single, "SweepTestAll"),
            new JSMgr.MethodCallBackInfo(Rigidbody_WakeUp, "WakeUp"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}