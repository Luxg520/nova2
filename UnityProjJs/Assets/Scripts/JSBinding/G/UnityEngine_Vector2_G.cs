
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Vector2_G
{
    ////////////////////// Vector2 ///////////////////////////////////////
    // constructors
    public static ConstructorID constructorID0 = new ConstructorID(null, null);
     
    static bool Vector2_Vector2(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Vector2());
        }
        return true;
    }
    static bool Vector2_Vector21(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 2)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.addJSCSRel(_this, new UnityEngine.Vector2(arg0, arg1));
        }
        return true;
    }
    // fields
    static void Vector2_kEpsilon(JSVCall vc)
    {
        var result = UnityEngine.Vector2.kEpsilon;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Vector2_x(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Vector2 _this = (UnityEngine.Vector2)vc.csObj;
            var result = _this.x;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 _this = (UnityEngine.Vector2)vc.csObj;
            _this.x = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void Vector2_y(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Vector2 _this = (UnityEngine.Vector2)vc.csObj;
            var result = _this.y;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 _this = (UnityEngine.Vector2)vc.csObj;
            _this.y = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    // properties
    static void Vector2_Item_Int32(JSVCall vc)
    {
        int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
        if (vc.bGet)
        {
            UnityEngine.Vector2 _this = (UnityEngine.Vector2)vc.csObj;
            var result = _this[arg0];
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 _this = (UnityEngine.Vector2)vc.csObj;
            _this[arg0] = arg1;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void Vector2_magnitude(JSVCall vc)
    {
        UnityEngine.Vector2 _this = (UnityEngine.Vector2)vc.csObj;
        var result = _this.magnitude;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Vector2_normalized(JSVCall vc)
    {
        UnityEngine.Vector2 _this = (UnityEngine.Vector2)vc.csObj;
        var result = _this.normalized;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Vector2_sqrMagnitude(JSVCall vc)
    {
        UnityEngine.Vector2 _this = (UnityEngine.Vector2)vc.csObj;
        var result = _this.sqrMagnitude;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Vector2_down(JSVCall vc)
    {
        var result = UnityEngine.Vector2.down;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Vector2_left(JSVCall vc)
    {
        var result = UnityEngine.Vector2.left;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Vector2_one(JSVCall vc)
    {
        var result = UnityEngine.Vector2.one;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Vector2_right(JSVCall vc)
    {
        var result = UnityEngine.Vector2.right;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Vector2_up(JSVCall vc)
    {
        var result = UnityEngine.Vector2.up;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Vector2_zero(JSVCall vc)
    {
        var result = UnityEngine.Vector2.zero;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    // methods
    static bool Vector2_Equals__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 argThis = (UnityEngine.Vector2)vc.csObj;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(argThis.Equals(arg0)));
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Vector2_GetHashCode(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            UnityEngine.Vector2 argThis = (UnityEngine.Vector2)vc.csObj;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(argThis.GetHashCode()));
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Vector2_Normalize(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            UnityEngine.Vector2 argThis = (UnityEngine.Vector2)vc.csObj;
            argThis.Normalize();
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Vector2_Scale__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 argThis = (UnityEngine.Vector2)vc.csObj;
            argThis.Scale(arg0);
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Vector2_Set__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 argThis = (UnityEngine.Vector2)vc.csObj;
            argThis.Set(arg0, arg1);
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Vector2_SqrMagnitude(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            UnityEngine.Vector2 argThis = (UnityEngine.Vector2)vc.csObj;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(argThis.SqrMagnitude()));
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Vector2_ToString(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            UnityEngine.Vector2 argThis = (UnityEngine.Vector2)vc.csObj;
            JSApi.setStringS((int)JSApi.SetType.Rval, argThis.ToString());
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Vector2_ToString__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 argThis = (UnityEngine.Vector2)vc.csObj;
            JSApi.setStringS((int)JSApi.SetType.Rval, argThis.ToString(arg0));
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Vector2_Angle__Vector2__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Vector2.Angle(arg0, arg1)));
        }
        return true;
    }
    static bool Vector2_ClampMagnitude__Vector2__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector2.ClampMagnitude(arg0, arg1));
        }
        return true;
    }
    static bool Vector2_Distance__Vector2__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Vector2.Distance(arg0, arg1)));
        }
        return true;
    }
    static bool Vector2_Dot__Vector2__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Vector2.Dot(arg0, arg1)));
        }
        return true;
    }
    static bool Vector2_Lerp__Vector2__Vector2__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector2.Lerp(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Vector2_LerpUnclamped__Vector2__Vector2__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector2.LerpUnclamped(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Vector2_Max__Vector2__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector2.Max(arg0, arg1));
        }
        return true;
    }
    static bool Vector2_Min__Vector2__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector2.Min(arg0, arg1));
        }
        return true;
    }
    static bool Vector2_MoveTowards__Vector2__Vector2__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector2.MoveTowards(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Vector2_op_Addition__Vector2__Vector2(JSVCall vc, int argc)
    {
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 + arg1);
        return true;
    }
    static bool Vector2_op_Division__Vector2__Single(JSVCall vc, int argc)
    {
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 / arg1);
        return true;
    }
    static bool Vector2_op_Equality__Vector2__Vector2(JSVCall vc, int argc)
    {
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(arg0 == arg1));
        return true;
    }
    static bool Vector2_op_Implicit__Vector3_to_Vector2(JSVCall vc, int argc)
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, (UnityEngine.Vector2)arg0);
        return true;
    }
    static bool Vector2_op_Implicit__Vector2_to_Vector3(JSVCall vc, int argc)
    {
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, (UnityEngine.Vector3)arg0);
        return true;
    }
    static bool Vector2_op_Inequality__Vector2__Vector2(JSVCall vc, int argc)
    {
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(arg0 != arg1));
        return true;
    }
    static bool Vector2_op_Multiply__Single__Vector2(JSVCall vc, int argc)
    {
        float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 * arg1);
        return true;
    }
    static bool Vector2_op_Multiply__Vector2__Single(JSVCall vc, int argc)
    {
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 * arg1);
        return true;
    }
    static bool Vector2_op_Subtraction__Vector2__Vector2(JSVCall vc, int argc)
    {
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 - arg1);
        return true;
    }
    static bool Vector2_op_UnaryNegation__Vector2(JSVCall vc, int argc)
    {
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, -arg0);
        return true;
    }
    static bool Vector2_Reflect__Vector2__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector2.Reflect(arg0, arg1));
        }
        return true;
    }
    static bool Vector2_Scale__Vector2__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector2.Scale(arg0, arg1));
        }
        return true;
    }
    static bool Vector2_SmoothDamp__Vector2__Vector2__Vector2__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.getArgIndex();
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.ArgRef);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector2.SmoothDamp(arg0, arg1, ref arg2, arg3));
            JSApi.setArgIndex(r_arg2);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Vector2_SmoothDamp__Vector2__Vector2__Vector2__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.getArgIndex();
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.ArgRef);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector2.SmoothDamp(arg0, arg1, ref arg2, arg3, arg4));
            JSApi.setArgIndex(r_arg2);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Vector2_SmoothDamp__Vector2__Vector2__Vector2__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 6)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int r_arg2 = JSApi.getArgIndex();
            UnityEngine.Vector2 arg2 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.ArgRef);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg4 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg5 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Vector2.SmoothDamp(arg0, arg1, ref arg2, arg3, arg4, arg5));
            JSApi.setArgIndex(r_arg2);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg2);
        }
        return true;
    }
    static bool Vector2_SqrMagnitude__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Vector2.SqrMagnitude(arg0)));
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Vector2);
        ci.fields = new JSMgr.CSCallbackField[]
        {
            Vector2_kEpsilon,
            Vector2_x,
            Vector2_y,
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Vector2_Item_Int32,
            Vector2_magnitude,
            Vector2_normalized,
            Vector2_sqrMagnitude,
            Vector2_down,
            Vector2_left,
            Vector2_one,
            Vector2_right,
            Vector2_up,
            Vector2_zero,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Vector2_Vector2, ".ctor"),
            new JSMgr.MethodCallBackInfo(Vector2_Vector21, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Vector2_Equals__Object, "Equals"),
            new JSMgr.MethodCallBackInfo(Vector2_GetHashCode, "GetHashCode"),
            new JSMgr.MethodCallBackInfo(Vector2_Normalize, "Normalize"),
            new JSMgr.MethodCallBackInfo(Vector2_Scale__Vector2, "Scale"),
            new JSMgr.MethodCallBackInfo(Vector2_Set__Single__Single, "Set"),
            new JSMgr.MethodCallBackInfo(Vector2_SqrMagnitude, "SqrMagnitude"),
            new JSMgr.MethodCallBackInfo(Vector2_ToString, "ToString"),
            new JSMgr.MethodCallBackInfo(Vector2_ToString__String, "ToString"),
            new JSMgr.MethodCallBackInfo(Vector2_Angle__Vector2__Vector2, "Angle"),
            new JSMgr.MethodCallBackInfo(Vector2_ClampMagnitude__Vector2__Single, "ClampMagnitude"),
            new JSMgr.MethodCallBackInfo(Vector2_Distance__Vector2__Vector2, "Distance"),
            new JSMgr.MethodCallBackInfo(Vector2_Dot__Vector2__Vector2, "Dot"),
            new JSMgr.MethodCallBackInfo(Vector2_Lerp__Vector2__Vector2__Single, "Lerp"),
            new JSMgr.MethodCallBackInfo(Vector2_LerpUnclamped__Vector2__Vector2__Single, "LerpUnclamped"),
            new JSMgr.MethodCallBackInfo(Vector2_Max__Vector2__Vector2, "Max"),
            new JSMgr.MethodCallBackInfo(Vector2_Min__Vector2__Vector2, "Min"),
            new JSMgr.MethodCallBackInfo(Vector2_MoveTowards__Vector2__Vector2__Single, "MoveTowards"),
            new JSMgr.MethodCallBackInfo(Vector2_op_Addition__Vector2__Vector2, "op_Addition"),
            new JSMgr.MethodCallBackInfo(Vector2_op_Division__Vector2__Single, "op_Division"),
            new JSMgr.MethodCallBackInfo(Vector2_op_Equality__Vector2__Vector2, "op_Equality"),
            new JSMgr.MethodCallBackInfo(Vector2_op_Implicit__Vector3_to_Vector2, "op_Implicit"),
            new JSMgr.MethodCallBackInfo(Vector2_op_Implicit__Vector2_to_Vector3, "op_Implicit"),
            new JSMgr.MethodCallBackInfo(Vector2_op_Inequality__Vector2__Vector2, "op_Inequality"),
            new JSMgr.MethodCallBackInfo(Vector2_op_Multiply__Single__Vector2, "op_Multiply"),
            new JSMgr.MethodCallBackInfo(Vector2_op_Multiply__Vector2__Single, "op_Multiply"),
            new JSMgr.MethodCallBackInfo(Vector2_op_Subtraction__Vector2__Vector2, "op_Subtraction"),
            new JSMgr.MethodCallBackInfo(Vector2_op_UnaryNegation__Vector2, "op_UnaryNegation"),
            new JSMgr.MethodCallBackInfo(Vector2_Reflect__Vector2__Vector2, "Reflect"),
            new JSMgr.MethodCallBackInfo(Vector2_Scale__Vector2__Vector2, "Scale"),
            new JSMgr.MethodCallBackInfo(Vector2_SmoothDamp__Vector2__Vector2__Vector2__Single, "SmoothDamp"),
            new JSMgr.MethodCallBackInfo(Vector2_SmoothDamp__Vector2__Vector2__Vector2__Single__Single, "SmoothDamp"),
            new JSMgr.MethodCallBackInfo(Vector2_SmoothDamp__Vector2__Vector2__Vector2__Single__Single__Single, "SmoothDamp"),
            new JSMgr.MethodCallBackInfo(Vector2_SqrMagnitude__Vector2, "SqrMagnitude"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}