
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine.UI;
using jsval = JSApi.jsval;
public class UnityEngine_UI_GridLayoutGroup_G
{
    ////////////////////// GridLayoutGroup ///////////////////////////////////////
    // constructors
    // fields
    // properties
    static void GridLayoutGroup_cellSize(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.GridLayoutGroup _this = (UnityEngine.UI.GridLayoutGroup)vc.csObj;
            var result = _this.cellSize;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.UI.GridLayoutGroup _this = (UnityEngine.UI.GridLayoutGroup)vc.csObj;
            _this.cellSize = arg0;
        }
    }
    static void GridLayoutGroup_constraint(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.GridLayoutGroup _this = (UnityEngine.UI.GridLayoutGroup)vc.csObj;
            var result = _this.constraint;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.UI.GridLayoutGroup.Constraint arg0 = (UnityEngine.UI.GridLayoutGroup.Constraint)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.UI.GridLayoutGroup _this = (UnityEngine.UI.GridLayoutGroup)vc.csObj;
            _this.constraint = arg0;
        }
    }
    static void GridLayoutGroup_constraintCount(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.GridLayoutGroup _this = (UnityEngine.UI.GridLayoutGroup)vc.csObj;
            var result = _this.constraintCount;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.UI.GridLayoutGroup _this = (UnityEngine.UI.GridLayoutGroup)vc.csObj;
            _this.constraintCount = arg0;
        }
    }
    static void GridLayoutGroup_spacing(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.GridLayoutGroup _this = (UnityEngine.UI.GridLayoutGroup)vc.csObj;
            var result = _this.spacing;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.UI.GridLayoutGroup _this = (UnityEngine.UI.GridLayoutGroup)vc.csObj;
            _this.spacing = arg0;
        }
    }
    static void GridLayoutGroup_startAxis(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.GridLayoutGroup _this = (UnityEngine.UI.GridLayoutGroup)vc.csObj;
            var result = _this.startAxis;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.UI.GridLayoutGroup.Axis arg0 = (UnityEngine.UI.GridLayoutGroup.Axis)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.UI.GridLayoutGroup _this = (UnityEngine.UI.GridLayoutGroup)vc.csObj;
            _this.startAxis = arg0;
        }
    }
    static void GridLayoutGroup_startCorner(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.GridLayoutGroup _this = (UnityEngine.UI.GridLayoutGroup)vc.csObj;
            var result = _this.startCorner;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.UI.GridLayoutGroup.Corner arg0 = (UnityEngine.UI.GridLayoutGroup.Corner)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.UI.GridLayoutGroup _this = (UnityEngine.UI.GridLayoutGroup)vc.csObj;
            _this.startCorner = arg0;
        }
    }
    // methods
    static bool GridLayoutGroup_CalculateLayoutInputHorizontal(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.GridLayoutGroup)vc.csObj).CalculateLayoutInputHorizontal();
        }
        return true;
    }
    static bool GridLayoutGroup_CalculateLayoutInputVertical(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.GridLayoutGroup)vc.csObj).CalculateLayoutInputVertical();
        }
        return true;
    }
    static bool GridLayoutGroup_SetLayoutHorizontal(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.GridLayoutGroup)vc.csObj).SetLayoutHorizontal();
        }
        return true;
    }
    static bool GridLayoutGroup_SetLayoutVertical(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.GridLayoutGroup)vc.csObj).SetLayoutVertical();
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.UI.GridLayoutGroup);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            GridLayoutGroup_cellSize,
            GridLayoutGroup_constraint,
            GridLayoutGroup_constraintCount,
            GridLayoutGroup_spacing,
            GridLayoutGroup_startAxis,
            GridLayoutGroup_startCorner,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(GridLayoutGroup_CalculateLayoutInputHorizontal, "CalculateLayoutInputHorizontal"),
            new JSMgr.MethodCallBackInfo(GridLayoutGroup_CalculateLayoutInputVertical, "CalculateLayoutInputVertical"),
            new JSMgr.MethodCallBackInfo(GridLayoutGroup_SetLayoutHorizontal, "SetLayoutHorizontal"),
            new JSMgr.MethodCallBackInfo(GridLayoutGroup_SetLayoutVertical, "SetLayoutVertical"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}