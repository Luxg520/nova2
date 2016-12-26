
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine.UI;
using jsval = JSApi.jsval;
public class UnityEngine_UI_Selectable_G
{
    ////////////////////// Selectable ///////////////////////////////////////
    // constructors
    // fields
    // properties
    static void Selectable_animationTriggers(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Selectable _this = (UnityEngine.UI.Selectable)vc.csObj;
            var result = _this.animationTriggers;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.UI.AnimationTriggers arg0 = (UnityEngine.UI.AnimationTriggers)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.UI.Selectable _this = (UnityEngine.UI.Selectable)vc.csObj;
            _this.animationTriggers = arg0;
        }
    }
    static void Selectable_animator(JSVCall vc)
    {
        UnityEngine.UI.Selectable _this = (UnityEngine.UI.Selectable)vc.csObj;
        var result = _this.animator;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Selectable_colors(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Selectable _this = (UnityEngine.UI.Selectable)vc.csObj;
            var result = _this.colors;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.UI.ColorBlock arg0 = (UnityEngine.UI.ColorBlock)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.UI.Selectable _this = (UnityEngine.UI.Selectable)vc.csObj;
            _this.colors = arg0;
        }
    }
    static void Selectable_image(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Selectable _this = (UnityEngine.UI.Selectable)vc.csObj;
            var result = _this.image;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.UI.Image arg0 = (UnityEngine.UI.Image)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.UI.Selectable _this = (UnityEngine.UI.Selectable)vc.csObj;
            _this.image = arg0;
        }
    }
    static void Selectable_interactable(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Selectable _this = (UnityEngine.UI.Selectable)vc.csObj;
            var result = _this.interactable;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.UI.Selectable _this = (UnityEngine.UI.Selectable)vc.csObj;
            _this.interactable = arg0;
        }
    }
    static void Selectable_navigation(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Selectable _this = (UnityEngine.UI.Selectable)vc.csObj;
            var result = _this.navigation;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.UI.Navigation arg0 = (UnityEngine.UI.Navigation)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.UI.Selectable _this = (UnityEngine.UI.Selectable)vc.csObj;
            _this.navigation = arg0;
        }
    }
    static void Selectable_spriteState(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Selectable _this = (UnityEngine.UI.Selectable)vc.csObj;
            var result = _this.spriteState;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.UI.SpriteState arg0 = (UnityEngine.UI.SpriteState)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.UI.Selectable _this = (UnityEngine.UI.Selectable)vc.csObj;
            _this.spriteState = arg0;
        }
    }
    static void Selectable_targetGraphic(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Selectable _this = (UnityEngine.UI.Selectable)vc.csObj;
            var result = _this.targetGraphic;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.UI.Graphic arg0 = (UnityEngine.UI.Graphic)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.UI.Selectable _this = (UnityEngine.UI.Selectable)vc.csObj;
            _this.targetGraphic = arg0;
        }
    }
    static void Selectable_transition(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Selectable _this = (UnityEngine.UI.Selectable)vc.csObj;
            var result = _this.transition;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.UI.Selectable.Transition arg0 = (UnityEngine.UI.Selectable.Transition)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.UI.Selectable _this = (UnityEngine.UI.Selectable)vc.csObj;
            _this.transition = arg0;
        }
    }
    static void Selectable_allSelectables(JSVCall vc)
    {
        var result = UnityEngine.UI.Selectable.allSelectables;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    // methods
    static bool Selectable_FindSelectable__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.UI.Selectable)vc.csObj).FindSelectable(arg0));
        }
        return true;
    }
    static bool Selectable_FindSelectableOnDown(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.UI.Selectable)vc.csObj).FindSelectableOnDown());
        }
        return true;
    }
    static bool Selectable_FindSelectableOnLeft(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.UI.Selectable)vc.csObj).FindSelectableOnLeft());
        }
        return true;
    }
    static bool Selectable_FindSelectableOnRight(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.UI.Selectable)vc.csObj).FindSelectableOnRight());
        }
        return true;
    }
    static bool Selectable_FindSelectableOnUp(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.UI.Selectable)vc.csObj).FindSelectableOnUp());
        }
        return true;
    }
    static bool Selectable_IsInteractable(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.UI.Selectable)vc.csObj).IsInteractable()));
        }
        return true;
    }
    static bool Selectable_OnDeselect__BaseEventData(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.UI.Selectable)vc.csObj).OnDeselect(arg0);
        }
        return true;
    }
    static bool Selectable_OnMove__AxisEventData(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.EventSystems.AxisEventData arg0 = (UnityEngine.EventSystems.AxisEventData)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.UI.Selectable)vc.csObj).OnMove(arg0);
        }
        return true;
    }
    static bool Selectable_OnPointerDown__PointerEventData(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.UI.Selectable)vc.csObj).OnPointerDown(arg0);
        }
        return true;
    }
    static bool Selectable_OnPointerEnter__PointerEventData(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.UI.Selectable)vc.csObj).OnPointerEnter(arg0);
        }
        return true;
    }
    static bool Selectable_OnPointerExit__PointerEventData(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.UI.Selectable)vc.csObj).OnPointerExit(arg0);
        }
        return true;
    }
    static bool Selectable_OnPointerUp__PointerEventData(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.UI.Selectable)vc.csObj).OnPointerUp(arg0);
        }
        return true;
    }
    static bool Selectable_OnSelect__BaseEventData(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.UI.Selectable)vc.csObj).OnSelect(arg0);
        }
        return true;
    }
    static bool Selectable_Select(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.Selectable)vc.csObj).Select();
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.UI.Selectable);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Selectable_animationTriggers,
            Selectable_animator,
            Selectable_colors,
            Selectable_image,
            Selectable_interactable,
            Selectable_navigation,
            Selectable_spriteState,
            Selectable_targetGraphic,
            Selectable_transition,
            Selectable_allSelectables,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Selectable_FindSelectable__Vector3, "FindSelectable"),
            new JSMgr.MethodCallBackInfo(Selectable_FindSelectableOnDown, "FindSelectableOnDown"),
            new JSMgr.MethodCallBackInfo(Selectable_FindSelectableOnLeft, "FindSelectableOnLeft"),
            new JSMgr.MethodCallBackInfo(Selectable_FindSelectableOnRight, "FindSelectableOnRight"),
            new JSMgr.MethodCallBackInfo(Selectable_FindSelectableOnUp, "FindSelectableOnUp"),
            new JSMgr.MethodCallBackInfo(Selectable_IsInteractable, "IsInteractable"),
            new JSMgr.MethodCallBackInfo(Selectable_OnDeselect__BaseEventData, "OnDeselect"),
            new JSMgr.MethodCallBackInfo(Selectable_OnMove__AxisEventData, "OnMove"),
            new JSMgr.MethodCallBackInfo(Selectable_OnPointerDown__PointerEventData, "OnPointerDown"),
            new JSMgr.MethodCallBackInfo(Selectable_OnPointerEnter__PointerEventData, "OnPointerEnter"),
            new JSMgr.MethodCallBackInfo(Selectable_OnPointerExit__PointerEventData, "OnPointerExit"),
            new JSMgr.MethodCallBackInfo(Selectable_OnPointerUp__PointerEventData, "OnPointerUp"),
            new JSMgr.MethodCallBackInfo(Selectable_OnSelect__BaseEventData, "OnSelect"),
            new JSMgr.MethodCallBackInfo(Selectable_Select, "Select"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}