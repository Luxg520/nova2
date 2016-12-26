﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Quaternion_G
{
    ////////////////////// Quaternion ///////////////////////////////////////
    // constructors
    public static ConstructorID constructorID0 = new ConstructorID(null, null);
     
    static bool Quaternion_Quaternion(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Quaternion());
        }
        return true;
    }
    static bool Quaternion_Quaternion1(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 4)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.addJSCSRel(_this, new UnityEngine.Quaternion(arg0, arg1, arg2, arg3));
        }
        return true;
    }
    // fields
    static void Quaternion_kEpsilon(JSVCall vc)
    {
        var result = UnityEngine.Quaternion.kEpsilon;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void Quaternion_x(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Quaternion _this = (UnityEngine.Quaternion)vc.csObj;
            var result = _this.x;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion _this = (UnityEngine.Quaternion)vc.csObj;
            _this.x = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void Quaternion_y(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Quaternion _this = (UnityEngine.Quaternion)vc.csObj;
            var result = _this.y;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion _this = (UnityEngine.Quaternion)vc.csObj;
            _this.y = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void Quaternion_z(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Quaternion _this = (UnityEngine.Quaternion)vc.csObj;
            var result = _this.z;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion _this = (UnityEngine.Quaternion)vc.csObj;
            _this.z = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void Quaternion_w(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Quaternion _this = (UnityEngine.Quaternion)vc.csObj;
            var result = _this.w;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion _this = (UnityEngine.Quaternion)vc.csObj;
            _this.w = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    // properties
    static void Quaternion_eulerAngles(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Quaternion _this = (UnityEngine.Quaternion)vc.csObj;
            var result = _this.eulerAngles;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion _this = (UnityEngine.Quaternion)vc.csObj;
            _this.eulerAngles = arg0;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void Quaternion_Item_Int32(JSVCall vc)
    {
        int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
        if (vc.bGet)
        {
            UnityEngine.Quaternion _this = (UnityEngine.Quaternion)vc.csObj;
            var result = _this[arg0];
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion _this = (UnityEngine.Quaternion)vc.csObj;
            _this[arg0] = arg1;
            JSMgr.changeJSObj(vc.jsObjID, _this);
        }
    }
    static void Quaternion_identity(JSVCall vc)
    {
        var result = UnityEngine.Quaternion.identity;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    // methods
    static bool Quaternion_Equals__Object(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            object arg0 = JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion argThis = (UnityEngine.Quaternion)vc.csObj;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(argThis.Equals(arg0)));
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Quaternion_GetHashCode(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            UnityEngine.Quaternion argThis = (UnityEngine.Quaternion)vc.csObj;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(argThis.GetHashCode()));
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Quaternion_Set__Single__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion argThis = (UnityEngine.Quaternion)vc.csObj;
            argThis.Set(arg0, arg1, arg2, arg3);
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Quaternion_SetFromToRotation__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion argThis = (UnityEngine.Quaternion)vc.csObj;
            argThis.SetFromToRotation(arg0, arg1);
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Quaternion_SetLookRotation__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion argThis = (UnityEngine.Quaternion)vc.csObj;
            argThis.SetLookRotation(arg0);
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Quaternion_SetLookRotation__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion argThis = (UnityEngine.Quaternion)vc.csObj;
            argThis.SetLookRotation(arg0, arg1);
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Quaternion_ToAngleAxis__Single__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            int r_arg0 = JSApi.incArgIndex();
            float arg0;
            int r_arg1 = JSApi.incArgIndex();
            UnityEngine.Vector3 arg1;
            UnityEngine.Quaternion argThis = (UnityEngine.Quaternion)vc.csObj;
            argThis.ToAngleAxis(out arg0, out arg1);
            JSMgr.changeJSObj(vc.jsObjID, argThis);
            JSApi.setArgIndex(r_arg0);
            JSApi.setSingle((int)JSApi.SetType.ArgRef, arg0);
            JSApi.setArgIndex(r_arg1);
            JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg1);
        }
        return true;
    }
    static bool Quaternion_ToString(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            UnityEngine.Quaternion argThis = (UnityEngine.Quaternion)vc.csObj;
            JSApi.setStringS((int)JSApi.SetType.Rval, argThis.ToString());
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Quaternion_ToString__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion argThis = (UnityEngine.Quaternion)vc.csObj;
            JSApi.setStringS((int)JSApi.SetType.Rval, argThis.ToString(arg0));
            JSMgr.changeJSObj(vc.jsObjID, argThis);
        }
        return true;
    }
    static bool Quaternion_Angle__Quaternion__Quaternion(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Quaternion arg0 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg1 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Quaternion.Angle(arg0, arg1)));
        }
        return true;
    }
    static bool Quaternion_AngleAxis__Single__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Quaternion.AngleAxis(arg0, arg1));
        }
        return true;
    }
    static bool Quaternion_Dot__Quaternion__Quaternion(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Quaternion arg0 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg1 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Quaternion.Dot(arg0, arg1)));
        }
        return true;
    }
    static bool Quaternion_Euler__Single__Single__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Quaternion.Euler(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Quaternion_Euler__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Quaternion.Euler(arg0));
        }
        return true;
    }
    static bool Quaternion_FromToRotation__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Quaternion.FromToRotation(arg0, arg1));
        }
        return true;
    }
    static bool Quaternion_Inverse__Quaternion(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Quaternion arg0 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Quaternion.Inverse(arg0));
        }
        return true;
    }
    static bool Quaternion_Lerp__Quaternion__Quaternion__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Quaternion arg0 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg1 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Quaternion.Lerp(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Quaternion_LookRotation__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Quaternion.LookRotation(arg0));
        }
        return true;
    }
    static bool Quaternion_LookRotation__Vector3__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Quaternion.LookRotation(arg0, arg1));
        }
        return true;
    }
    static bool Quaternion_op_Equality__Quaternion__Quaternion(JSVCall vc, int argc)
    {
        UnityEngine.Quaternion arg0 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Quaternion arg1 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(arg0 == arg1));
        return true;
    }
    static bool Quaternion_op_Inequality__Quaternion__Quaternion(JSVCall vc, int argc)
    {
        UnityEngine.Quaternion arg0 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Quaternion arg1 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(arg0 != arg1));
        return true;
    }
    static bool Quaternion_op_Multiply__Quaternion__Quaternion(JSVCall vc, int argc)
    {
        UnityEngine.Quaternion arg0 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Quaternion arg1 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 * arg1);
        return true;
    }
    static bool Quaternion_op_Multiply__Quaternion__Vector3(JSVCall vc, int argc)
    {
        UnityEngine.Quaternion arg0 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, arg0 * arg1);
        return true;
    }
    static bool Quaternion_RotateTowards__Quaternion__Quaternion__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Quaternion arg0 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg1 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Quaternion.RotateTowards(arg0, arg1, arg2));
        }
        return true;
    }
    static bool Quaternion_Slerp__Quaternion__Quaternion__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.Quaternion arg0 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Quaternion arg1 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Quaternion.Slerp(arg0, arg1, arg2));
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Quaternion);
        ci.fields = new JSMgr.CSCallbackField[]
        {
            Quaternion_kEpsilon,
            Quaternion_x,
            Quaternion_y,
            Quaternion_z,
            Quaternion_w,
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Quaternion_eulerAngles,
            Quaternion_Item_Int32,
            Quaternion_identity,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Quaternion_Quaternion, ".ctor"),
            new JSMgr.MethodCallBackInfo(Quaternion_Quaternion1, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Quaternion_Equals__Object, "Equals"),
            new JSMgr.MethodCallBackInfo(Quaternion_GetHashCode, "GetHashCode"),
            new JSMgr.MethodCallBackInfo(Quaternion_Set__Single__Single__Single__Single, "Set"),
            new JSMgr.MethodCallBackInfo(Quaternion_SetFromToRotation__Vector3__Vector3, "SetFromToRotation"),
            new JSMgr.MethodCallBackInfo(Quaternion_SetLookRotation__Vector3, "SetLookRotation"),
            new JSMgr.MethodCallBackInfo(Quaternion_SetLookRotation__Vector3__Vector3, "SetLookRotation"),
            new JSMgr.MethodCallBackInfo(Quaternion_ToAngleAxis__Single__Vector3, "ToAngleAxis"),
            new JSMgr.MethodCallBackInfo(Quaternion_ToString, "ToString"),
            new JSMgr.MethodCallBackInfo(Quaternion_ToString__String, "ToString"),
            new JSMgr.MethodCallBackInfo(Quaternion_Angle__Quaternion__Quaternion, "Angle"),
            new JSMgr.MethodCallBackInfo(Quaternion_AngleAxis__Single__Vector3, "AngleAxis"),
            new JSMgr.MethodCallBackInfo(Quaternion_Dot__Quaternion__Quaternion, "Dot"),
            new JSMgr.MethodCallBackInfo(Quaternion_Euler__Single__Single__Single, "Euler"),
            new JSMgr.MethodCallBackInfo(Quaternion_Euler__Vector3, "Euler"),
            new JSMgr.MethodCallBackInfo(Quaternion_FromToRotation__Vector3__Vector3, "FromToRotation"),
            new JSMgr.MethodCallBackInfo(Quaternion_Inverse__Quaternion, "Inverse"),
            new JSMgr.MethodCallBackInfo(Quaternion_Lerp__Quaternion__Quaternion__Single, "Lerp"),
            new JSMgr.MethodCallBackInfo(Quaternion_LookRotation__Vector3, "LookRotation"),
            new JSMgr.MethodCallBackInfo(Quaternion_LookRotation__Vector3__Vector3, "LookRotation"),
            new JSMgr.MethodCallBackInfo(Quaternion_op_Equality__Quaternion__Quaternion, "op_Equality"),
            new JSMgr.MethodCallBackInfo(Quaternion_op_Inequality__Quaternion__Quaternion, "op_Inequality"),
            new JSMgr.MethodCallBackInfo(Quaternion_op_Multiply__Quaternion__Quaternion, "op_Multiply"),
            new JSMgr.MethodCallBackInfo(Quaternion_op_Multiply__Quaternion__Vector3, "op_Multiply"),
            new JSMgr.MethodCallBackInfo(Quaternion_RotateTowards__Quaternion__Quaternion__Single, "RotateTowards"),
            new JSMgr.MethodCallBackInfo(Quaternion_Slerp__Quaternion__Quaternion__Single, "Slerp"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}