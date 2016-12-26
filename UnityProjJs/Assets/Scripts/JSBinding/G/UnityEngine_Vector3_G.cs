
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Vector3_G
{
    ////////////////////// Vector3 ///////////////////////////////////////
    // constructors
    public static ConstructorID constructorID0 = new ConstructorID(null, null);
     
    static bool Vector3_Vector3(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Vector3());
        }
        return true;
    }
    static bool Vector3_Vector31(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 2)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.addJSCSRel(_this, new UnityEngine.Vector3(arg0, arg1));
        }
        return true;
    }
    static bool Vector3_Vector32(JSVCall vc, int argc)
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
            JSMgr.addJSCSRel(_this, new UnityEngine.Vector3(arg0, arg1, arg2));
        }
        return true;
    }
    // fields
    static void Vector3_kEpsilon(JSVCall vc)
    {
        var result = UnityEngine.Vector3.kEpsilon;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Vector3_x(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
            var result = _this.x;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
            _this.x = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void Vector3_y(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
            var result = _this.y;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
            _this.y = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void Vector3_z(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
            var result = _this.z;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
            _this.z = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    // properties
    static void Vector3_Item_Int32(JSVCall vc)
    {
        int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
        if (vc.bGet)
        {
            UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
            var result = _this[arg0];
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
            _this[arg0] = arg1;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void Vector3_magnitude(JSVCall vc)
    {
        UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
        var result = _this.magnitude;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Vector3_normalized(JSVCall vc)
    {
        UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
        var result = _this.normalized;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Vector3_sqrMagnitude(JSVCall vc)
    {
        UnityEngine.Vector3 _this = (UnityEngine.Vector3)vc.csObj;
        var result = _this.sqrMagnitude;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Vector3_back(JSVCall vc)
    {
        var result = UnityEngine.Vector3.back;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Vector3_down(JSVCall vc)
    {
        var result = UnityEngine.Vector3.down;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Vector3_forward(JSVCall vc)
    {
        var result = UnityEngine.Vector3.forward;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Vector3_left(JSVCall vc)
    {
        var result = UnityEngine.Vector3.left;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Vector3_one(JSVCall vc)
    {
        var result = UnityEngine.Vector3.one;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Vector3_right(JSVCall vc)
    {
        var result = UnityEngine.Vector3.right;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Vector3_up(JSVCall vc)
    {
        var result = UnityEngine.Vector3.up;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Vector3_zero(JSVCall vc)
    {
        var result = UnityEngine.Vector3.zero;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    // methods
    static bool Vector3_Equals__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 argThis = (UnityEngine.Vector3)vc.csObj;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(argThis.Equals(arg0)));
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Vector3_GetHashCode(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            UnityEngine.Vector3 argThis = (UnityEngine.Vector3)vc.csObj;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(argThis.GetHashCode()));
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Vector3_Normalize(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            UnityEngine.Vector3 argThis = (UnityEngine.Vector3)vc.csObj;
            argThis.Normalize();
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Vector3_Scale__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 argThis = (UnityEngine.Vector3)vc.csObj;
            argThis.Scale(arg0);
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Vector3_Set__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 argThis = (UnityEngine.Vector3)vc.csObj;
            argThis.Set(arg0, arg1, arg2);
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Vector3_ToString(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            UnityEngine.Vector3 argThis = (UnityEngine.Vector3)vc.csObj;
            JSApi.setStringS((int)JSApi.SetType.Rval, argThis.ToString());
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Vector3_ToString__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 argThis = (UnityEngine.Vector3)vc.csObj;
            JSApi.setStringS((int)JSApi.SetType.Rval, argThis.ToString(arg0));
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Vector3_Angle__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Vector3.Angle(arg0, arg1)));
        }
        return true;
    }
    static bool Vector3_ClampMagnitude__Vector3__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector3.ClampMagnitude(arg0, arg1));
        }
        return true;
    }
    static bool Vector3_Cross__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector3.Cross(arg0, arg1));
        }
        return true;
    }
    static bool Vector3_Distance__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Vector3.Distance(arg0, arg1)));
        }
        return true;
    }
    static bool Vector3_Dot__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Vector3.Dot(arg0, arg1)));
        }
        return true;
    }
    static bool Vector3_Lerp__Vector3__Vector3__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector3.Lerp(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Vector3_Magnitude__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Vector3.Magnitude(arg0)));
        }
        return true;
    }
    static bool Vector3_Max__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector3.Max(arg0, arg1));
        }
        return true;
    }
    static bool Vector3_Min__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector3.Min(arg0, arg1));
        }
        return true;
    }
    static bool Vector3_MoveTowards__Vector3__Vector3__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector3.MoveTowards(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Vector3_Normalize__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector3.Normalize(arg0));
        }
        return true;
    }
    static bool Vector3_op_Addition__Vector3__Vector3(JSVCall vc, int argc)
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 + arg1);
        return true;
    }
    static bool Vector3_op_Division__Vector3__Single(JSVCall vc, int argc)
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 / arg1);
        return true;
    }
    static bool Vector3_op_Equality__Vector3__Vector3(JSVCall vc, int argc)
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(arg0 == arg1));
        return true;
    }
    static bool Vector3_op_Inequality__Vector3__Vector3(JSVCall vc, int argc)
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(arg0 != arg1));
        return true;
    }
    static bool Vector3_op_Multiply__Single__Vector3(JSVCall vc, int argc)
    {
        float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 * arg1);
        return true;
    }
    static bool Vector3_op_Multiply__Vector3__Single(JSVCall vc, int argc)
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 * arg1);
        return true;
    }
    static bool Vector3_op_Subtraction__Vector3__Vector3(JSVCall vc, int argc)
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 - arg1);
        return true;
    }
    static bool Vector3_op_UnaryNegation__Vector3(JSVCall vc, int argc)
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, -arg0);
        return true;
    }
    static bool Vector3_OrthoNormalize__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int r_arg0 = JSApi.getArgIndex();
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.ArgRef);
            int r_arg1 = JSApi.getArgIndex();
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.ArgRef);
            UnityEngine.Vector3.OrthoNormalize(ref arg0, ref arg1);
            JSApi.setArgIndex(r_arg0);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg0);
            JSApi.setArgIndex(r_arg1);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg1);
        }
        return true;
    }
    static bool Vector3_OrthoNormalize__Vector3__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            int r_arg0 = JSApi.getArgIndex();
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.ArgRef);
            int r_arg1 = JSApi.getArgIndex();
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.ArgRef);
            int r_arg2 = JSApi.getArgIndex();
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.ArgRef);
            UnityEngine.Vector3.OrthoNormalize(ref arg0, ref arg1, ref arg2);
            JSApi.setArgIndex(r_arg0);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg0);
            JSApi.setArgIndex(r_arg1);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg1);
            JSApi.setArgIndex(r_arg2);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Vector3_Project__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector3.Project(arg0, arg1));
        }
        return true;
    }
    static bool Vector3_ProjectOnPlane__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector3.ProjectOnPlane(arg0, arg1));
        }
        return true;
    }
    static bool Vector3_Reflect__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector3.Reflect(arg0, arg1));
        }
        return true;
    }
    static bool Vector3_RotateTowards__Vector3__Vector3__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector3.RotateTowards(arg0, arg1, arg2, arg3));
        }
        return true;
    }
    static bool Vector3_Scale__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector3.Scale(arg0, arg1));
        }
        return true;
    }
    static bool Vector3_Slerp__Vector3__Vector3__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector3.Slerp(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Vector3_SmoothDamp__Vector3__Vector3__Vector3__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.getArgIndex();
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.ArgRef);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector3.SmoothDamp(arg0, arg1, ref arg2, arg3));
            JSApi.setArgIndex(r_arg2);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Vector3_SmoothDamp__Vector3__Vector3__Vector3__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.getArgIndex();
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.ArgRef);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector3.SmoothDamp(arg0, arg1, ref arg2, arg3, arg4));
            JSApi.setArgIndex(r_arg2);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Vector3_SmoothDamp__Vector3__Vector3__Vector3__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.getArgIndex();
            UnityEngine.Vector3 arg2 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.ArgRef);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector3.SmoothDamp(arg0, arg1, ref arg2, arg3, arg4, arg5));
            JSApi.setArgIndex(r_arg2);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Vector3_SqrMagnitude__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Vector3.SqrMagnitude(arg0)));
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Vector3);
        ci.fields = new JSMgr.CSCallbackField[]
        {
            Vector3_kEpsilon,
            Vector3_x,
            Vector3_y,
            Vector3_z,
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Vector3_Item_Int32,
            Vector3_magnitude,
            Vector3_normalized,
            Vector3_sqrMagnitude,
            Vector3_back,
            Vector3_down,
            Vector3_forward,
            Vector3_left,
            Vector3_one,
            Vector3_right,
            Vector3_up,
            Vector3_zero,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Vector3_Vector3, ".ctor"),
            new JSMgr.MethodCallBackInfo(Vector3_Vector31, ".ctor"),
            new JSMgr.MethodCallBackInfo(Vector3_Vector32, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Vector3_Equals__Object, "Equals"),
            new JSMgr.MethodCallBackInfo(Vector3_GetHashCode, "GetHashCode"),
            new JSMgr.MethodCallBackInfo(Vector3_Normalize, "Normalize"),
            new JSMgr.MethodCallBackInfo(Vector3_Scale__Vector3, "Scale"),
            new JSMgr.MethodCallBackInfo(Vector3_Set__Single__Single__Single, "Set"),
            new JSMgr.MethodCallBackInfo(Vector3_ToString, "ToString"),
            new JSMgr.MethodCallBackInfo(Vector3_ToString__String, "ToString"),
            new JSMgr.MethodCallBackInfo(Vector3_Angle__Vector3__Vector3, "Angle"),
            new JSMgr.MethodCallBackInfo(Vector3_ClampMagnitude__Vector3__Single, "ClampMagnitude"),
            new JSMgr.MethodCallBackInfo(Vector3_Cross__Vector3__Vector3, "Cross"),
            new JSMgr.MethodCallBackInfo(Vector3_Distance__Vector3__Vector3, "Distance"),
            new JSMgr.MethodCallBackInfo(Vector3_Dot__Vector3__Vector3, "Dot"),
            new JSMgr.MethodCallBackInfo(Vector3_Lerp__Vector3__Vector3__Single, "Lerp"),
            new JSMgr.MethodCallBackInfo(Vector3_Magnitude__Vector3, "Magnitude"),
            new JSMgr.MethodCallBackInfo(Vector3_Max__Vector3__Vector3, "Max"),
            new JSMgr.MethodCallBackInfo(Vector3_Min__Vector3__Vector3, "Min"),
            new JSMgr.MethodCallBackInfo(Vector3_MoveTowards__Vector3__Vector3__Single, "MoveTowards"),
            new JSMgr.MethodCallBackInfo(Vector3_Normalize__Vector3, "Normalize"),
            new JSMgr.MethodCallBackInfo(Vector3_op_Addition__Vector3__Vector3, "op_Addition"),
            new JSMgr.MethodCallBackInfo(Vector3_op_Division__Vector3__Single, "op_Division"),
            new JSMgr.MethodCallBackInfo(Vector3_op_Equality__Vector3__Vector3, "op_Equality"),
            new JSMgr.MethodCallBackInfo(Vector3_op_Inequality__Vector3__Vector3, "op_Inequality"),
            new JSMgr.MethodCallBackInfo(Vector3_op_Multiply__Single__Vector3, "op_Multiply"),
            new JSMgr.MethodCallBackInfo(Vector3_op_Multiply__Vector3__Single, "op_Multiply"),
            new JSMgr.MethodCallBackInfo(Vector3_op_Subtraction__Vector3__Vector3, "op_Subtraction"),
            new JSMgr.MethodCallBackInfo(Vector3_op_UnaryNegation__Vector3, "op_UnaryNegation"),
            new JSMgr.MethodCallBackInfo(Vector3_OrthoNormalize__Vector3__Vector3, "OrthoNormalize"),
            new JSMgr.MethodCallBackInfo(Vector3_OrthoNormalize__Vector3__Vector3__Vector3, "OrthoNormalize"),
            new JSMgr.MethodCallBackInfo(Vector3_Project__Vector3__Vector3, "Project"),
            new JSMgr.MethodCallBackInfo(Vector3_ProjectOnPlane__Vector3__Vector3, "ProjectOnPlane"),
            new JSMgr.MethodCallBackInfo(Vector3_Reflect__Vector3__Vector3, "Reflect"),
            new JSMgr.MethodCallBackInfo(Vector3_RotateTowards__Vector3__Vector3__Single__Single, "RotateTowards"),
            new JSMgr.MethodCallBackInfo(Vector3_Scale__Vector3__Vector3, "Scale"),
            new JSMgr.MethodCallBackInfo(Vector3_Slerp__Vector3__Vector3__Single, "Slerp"),
            new JSMgr.MethodCallBackInfo(Vector3_SmoothDamp__Vector3__Vector3__Vector3__Single, "SmoothDamp"),
            new JSMgr.MethodCallBackInfo(Vector3_SmoothDamp__Vector3__Vector3__Vector3__Single__Single, "SmoothDamp"),
            new JSMgr.MethodCallBackInfo(Vector3_SmoothDamp__Vector3__Vector3__Vector3__Single__Single__Single, "SmoothDamp"),
            new JSMgr.MethodCallBackInfo(Vector3_SqrMagnitude__Vector3, "SqrMagnitude"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}