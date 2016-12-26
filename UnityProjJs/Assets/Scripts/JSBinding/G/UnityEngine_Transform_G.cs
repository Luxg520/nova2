
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Transform_G
{
    ////////////////////// Transform ///////////////////////////////////////
    // constructors
    // fields
    // properties
    static void Transform_childCount(JSVCall vc)
    {
        UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
        var result = _this.childCount;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Transform_eulerAngles(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            var result = _this.eulerAngles;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            _this.eulerAngles = arg0;
        }
    }
    static void Transform_forward(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            var result = _this.forward;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            _this.forward = arg0;
        }
    }
    static void Transform_hasChanged(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            var result = _this.hasChanged;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            _this.hasChanged = arg0;
        }
    }
    static void Transform_localEulerAngles(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            var result = _this.localEulerAngles;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            _this.localEulerAngles = arg0;
        }
    }
    static void Transform_localPosition(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            var result = _this.localPosition;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            _this.localPosition = arg0;
        }
    }
    static void Transform_localRotation(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            var result = _this.localRotation;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Quaternion arg0 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            _this.localRotation = arg0;
        }
    }
    static void Transform_localScale(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            var result = _this.localScale;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            _this.localScale = arg0;
        }
    }
    static void Transform_localToWorldMatrix(JSVCall vc)
    {
        UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
        var result = _this.localToWorldMatrix;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Transform_lossyScale(JSVCall vc)
    {
        UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
        var result = _this.lossyScale;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Transform_parent(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            var result = _this.parent;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Transform arg0 = (UnityEngine.Transform)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            _this.parent = arg0;
        }
    }
    static void Transform_position(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            var result = _this.position;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            _this.position = arg0;
        }
    }
    static void Transform_right(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            var result = _this.right;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            _this.right = arg0;
        }
    }
    static void Transform_root(JSVCall vc)
    {
        UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
        var result = _this.root;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Transform_rotation(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            var result = _this.rotation;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Quaternion arg0 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            _this.rotation = arg0;
        }
    }
    static void Transform_up(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            var result = _this.up;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
            _this.up = arg0;
        }
    }
    static void Transform_worldToLocalMatrix(JSVCall vc)
    {
        UnityEngine.Transform _this = (UnityEngine.Transform)vc.csObj;
        var result = _this.worldToLocalMatrix;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    // methods
    static bool Transform_DetachChildren(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Transform)vc.csObj).DetachChildren();
        }
        return true;
    }
    static bool Transform_Find__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Transform)vc.csObj).Find(arg0));
        }
        return true;
    }
    static bool Transform_FindChild__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Transform)vc.csObj).FindChild(arg0));
        }
        return true;
    }
    static bool Transform_GetChild__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Transform)vc.csObj).GetChild(arg0));
        }
        return true;
    }
    static bool Transform_GetEnumerator(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Transform)vc.csObj).GetEnumerator());
        }
        return true;
    }
    static bool Transform_GetSiblingIndex(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.Transform)vc.csObj).GetSiblingIndex()));
        }
        return true;
    }
    static bool Transform_InverseTransformDirection__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Transform)vc.csObj).InverseTransformDirection(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Transform_InverseTransformDirection__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Transform)vc.csObj).InverseTransformDirection(arg0));
        }
        return true;
    }
    static bool Transform_InverseTransformPoint__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Transform)vc.csObj).InverseTransformPoint(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Transform_InverseTransformPoint__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Transform)vc.csObj).InverseTransformPoint(arg0));
        }
        return true;
    }
    static bool Transform_InverseTransformVector__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Transform)vc.csObj).InverseTransformVector(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Transform_InverseTransformVector__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Transform)vc.csObj).InverseTransformVector(arg0));
        }
        return true;
    }
    static bool Transform_IsChildOf__Transform(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Transform arg0 = (UnityEngine.Transform)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Transform)vc.csObj).IsChildOf(arg0)));
        }
        return true;
    }
    static bool Transform_LookAt__Transform(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Transform arg0 = (UnityEngine.Transform)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Transform)vc.csObj).LookAt(arg0);
        }
        return true;
    }
    static bool Transform_LookAt__Transform__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Transform arg0 = (UnityEngine.Transform)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Transform)vc.csObj).LookAt(arg0, arg1);
        }
        return true;
    }
    static bool Transform_LookAt__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Transform)vc.csObj).LookAt(arg0);
        }
        return true;
    }
    static bool Transform_LookAt__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Transform)vc.csObj).LookAt(arg0, arg1);
        }
        return true;
    }
    static bool Transform_Rotate__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Transform)vc.csObj).Rotate(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Transform_Rotate__Single__Single__Single__Space(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Space arg3 = (UnityEngine.Space)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Transform)vc.csObj).Rotate(arg0, arg1, arg2, arg3);
        }
        return true;
    }
    static bool Transform_Rotate__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Transform)vc.csObj).Rotate(arg0);
        }
        return true;
    }
    static bool Transform_Rotate__Vector3__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Transform)vc.csObj).Rotate(arg0, arg1);
        }
        return true;
    }
    static bool Transform_Rotate__Vector3__Single__Space(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Space arg2 = (UnityEngine.Space)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Transform)vc.csObj).Rotate(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Transform_Rotate__Vector3__Space(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Space arg1 = (UnityEngine.Space)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Transform)vc.csObj).Rotate(arg0, arg1);
        }
        return true;
    }
    static bool Transform_RotateAround__Vector3__Vector3__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Transform)vc.csObj).RotateAround(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Transform_SetAsFirstSibling(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Transform)vc.csObj).SetAsFirstSibling();
        }
        return true;
    }
    static bool Transform_SetAsLastSibling(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Transform)vc.csObj).SetAsLastSibling();
        }
        return true;
    }
    static bool Transform_SetParent__Transform(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Transform arg0 = (UnityEngine.Transform)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Transform)vc.csObj).SetParent(arg0);
        }
        return true;
    }
    static bool Transform_SetParent__Transform__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Transform arg0 = (UnityEngine.Transform)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            bool arg1 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            ((UnityEngine.Transform)vc.csObj).SetParent(arg0, arg1);
        }
        return true;
    }
    static bool Transform_SetSiblingIndex__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.Transform)vc.csObj).SetSiblingIndex(arg0);
        }
        return true;
    }
    static bool Transform_TransformDirection__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Transform)vc.csObj).TransformDirection(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Transform_TransformDirection__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Transform)vc.csObj).TransformDirection(arg0));
        }
        return true;
    }
    static bool Transform_TransformPoint__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Transform)vc.csObj).TransformPoint(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Transform_TransformPoint__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Transform)vc.csObj).TransformPoint(arg0));
        }
        return true;
    }
    static bool Transform_TransformVector__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Transform)vc.csObj).TransformVector(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Transform_TransformVector__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Transform)vc.csObj).TransformVector(arg0));
        }
        return true;
    }
    static bool Transform_Translate__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.Transform)vc.csObj).Translate(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Transform_Translate__Single__Single__Single__Space(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Space arg3 = (UnityEngine.Space)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Transform)vc.csObj).Translate(arg0, arg1, arg2, arg3);
        }
        return true;
    }
    static bool Transform_Translate__Single__Single__Single__Transform(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Transform arg3 = (UnityEngine.Transform)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Transform)vc.csObj).Translate(arg0, arg1, arg2, arg3);
        }
        return true;
    }
    static bool Transform_Translate__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Transform)vc.csObj).Translate(arg0);
        }
        return true;
    }
    static bool Transform_Translate__Vector3__Space(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Space arg1 = (UnityEngine.Space)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Transform)vc.csObj).Translate(arg0, arg1);
        }
        return true;
    }
    static bool Transform_Translate__Vector3__Transform(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Transform arg1 = (UnityEngine.Transform)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Transform)vc.csObj).Translate(arg0, arg1);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Transform);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Transform_childCount,
            Transform_eulerAngles,
            Transform_forward,
            Transform_hasChanged,
            Transform_localEulerAngles,
            Transform_localPosition,
            Transform_localRotation,
            Transform_localScale,
            Transform_localToWorldMatrix,
            Transform_lossyScale,
            Transform_parent,
            Transform_position,
            Transform_right,
            Transform_root,
            Transform_rotation,
            Transform_up,
            Transform_worldToLocalMatrix,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Transform_DetachChildren, "DetachChildren"),
            new JSMgr.MethodCallBackInfo(Transform_Find__String, "Find"),
            new JSMgr.MethodCallBackInfo(Transform_FindChild__String, "FindChild"),
            new JSMgr.MethodCallBackInfo(Transform_GetChild__Int32, "GetChild"),
            new JSMgr.MethodCallBackInfo(Transform_GetEnumerator, "GetEnumerator"),
            new JSMgr.MethodCallBackInfo(Transform_GetSiblingIndex, "GetSiblingIndex"),
            new JSMgr.MethodCallBackInfo(Transform_InverseTransformDirection__Single__Single__Single, "InverseTransformDirection"),
            new JSMgr.MethodCallBackInfo(Transform_InverseTransformDirection__Vector3, "InverseTransformDirection"),
            new JSMgr.MethodCallBackInfo(Transform_InverseTransformPoint__Single__Single__Single, "InverseTransformPoint"),
            new JSMgr.MethodCallBackInfo(Transform_InverseTransformPoint__Vector3, "InverseTransformPoint"),
            new JSMgr.MethodCallBackInfo(Transform_InverseTransformVector__Single__Single__Single, "InverseTransformVector"),
            new JSMgr.MethodCallBackInfo(Transform_InverseTransformVector__Vector3, "InverseTransformVector"),
            new JSMgr.MethodCallBackInfo(Transform_IsChildOf__Transform, "IsChildOf"),
            new JSMgr.MethodCallBackInfo(Transform_LookAt__Transform, "LookAt"),
            new JSMgr.MethodCallBackInfo(Transform_LookAt__Transform__Vector3, "LookAt"),
            new JSMgr.MethodCallBackInfo(Transform_LookAt__Vector3, "LookAt"),
            new JSMgr.MethodCallBackInfo(Transform_LookAt__Vector3__Vector3, "LookAt"),
            new JSMgr.MethodCallBackInfo(Transform_Rotate__Single__Single__Single, "Rotate"),
            new JSMgr.MethodCallBackInfo(Transform_Rotate__Single__Single__Single__Space, "Rotate"),
            new JSMgr.MethodCallBackInfo(Transform_Rotate__Vector3, "Rotate"),
            new JSMgr.MethodCallBackInfo(Transform_Rotate__Vector3__Single, "Rotate"),
            new JSMgr.MethodCallBackInfo(Transform_Rotate__Vector3__Single__Space, "Rotate"),
            new JSMgr.MethodCallBackInfo(Transform_Rotate__Vector3__Space, "Rotate"),
            new JSMgr.MethodCallBackInfo(Transform_RotateAround__Vector3__Vector3__Single, "RotateAround"),
            new JSMgr.MethodCallBackInfo(Transform_SetAsFirstSibling, "SetAsFirstSibling"),
            new JSMgr.MethodCallBackInfo(Transform_SetAsLastSibling, "SetAsLastSibling"),
            new JSMgr.MethodCallBackInfo(Transform_SetParent__Transform, "SetParent"),
            new JSMgr.MethodCallBackInfo(Transform_SetParent__Transform__Boolean, "SetParent"),
            new JSMgr.MethodCallBackInfo(Transform_SetSiblingIndex__Int32, "SetSiblingIndex"),
            new JSMgr.MethodCallBackInfo(Transform_TransformDirection__Single__Single__Single, "TransformDirection"),
            new JSMgr.MethodCallBackInfo(Transform_TransformDirection__Vector3, "TransformDirection"),
            new JSMgr.MethodCallBackInfo(Transform_TransformPoint__Single__Single__Single, "TransformPoint"),
            new JSMgr.MethodCallBackInfo(Transform_TransformPoint__Vector3, "TransformPoint"),
            new JSMgr.MethodCallBackInfo(Transform_TransformVector__Single__Single__Single, "TransformVector"),
            new JSMgr.MethodCallBackInfo(Transform_TransformVector__Vector3, "TransformVector"),
            new JSMgr.MethodCallBackInfo(Transform_Translate__Single__Single__Single, "Translate"),
            new JSMgr.MethodCallBackInfo(Transform_Translate__Single__Single__Single__Space, "Translate"),
            new JSMgr.MethodCallBackInfo(Transform_Translate__Single__Single__Single__Transform, "Translate"),
            new JSMgr.MethodCallBackInfo(Transform_Translate__Vector3, "Translate"),
            new JSMgr.MethodCallBackInfo(Transform_Translate__Vector3__Space, "Translate"),
            new JSMgr.MethodCallBackInfo(Transform_Translate__Vector3__Transform, "Translate"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}