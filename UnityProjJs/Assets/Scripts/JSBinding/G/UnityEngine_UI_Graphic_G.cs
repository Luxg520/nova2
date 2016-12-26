
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine.UI;
using jsval = JSApi.jsval;
public class UnityEngine_UI_Graphic_G
{
    ////////////////////// Graphic ///////////////////////////////////////
    // constructors
    // fields
    // properties
    static void Graphic_canvas(JSVCall vc)
    {
        UnityEngine.UI.Graphic _this = (UnityEngine.UI.Graphic)vc.csObj;
        var result = _this.canvas;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Graphic_canvasRenderer(JSVCall vc)
    {
        UnityEngine.UI.Graphic _this = (UnityEngine.UI.Graphic)vc.csObj;
        var result = _this.canvasRenderer;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Graphic_color(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Graphic _this = (UnityEngine.UI.Graphic)vc.csObj;
            var result = _this.color;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.UI.Graphic _this = (UnityEngine.UI.Graphic)vc.csObj;
            _this.color = arg0;
        }
    }
    static void Graphic_defaultMaterial(JSVCall vc)
    {
        UnityEngine.UI.Graphic _this = (UnityEngine.UI.Graphic)vc.csObj;
        var result = _this.defaultMaterial;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Graphic_depth(JSVCall vc)
    {
        UnityEngine.UI.Graphic _this = (UnityEngine.UI.Graphic)vc.csObj;
        var result = _this.depth;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Graphic_mainTexture(JSVCall vc)
    {
        UnityEngine.UI.Graphic _this = (UnityEngine.UI.Graphic)vc.csObj;
        var result = _this.mainTexture;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Graphic_material(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Graphic _this = (UnityEngine.UI.Graphic)vc.csObj;
            var result = _this.material;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Material arg0 = (UnityEngine.Material)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.UI.Graphic _this = (UnityEngine.UI.Graphic)vc.csObj;
            _this.material = arg0;
        }
    }
    static void Graphic_materialForRendering(JSVCall vc)
    {
        UnityEngine.UI.Graphic _this = (UnityEngine.UI.Graphic)vc.csObj;
        var result = _this.materialForRendering;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Graphic_raycastTarget(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.UI.Graphic _this = (UnityEngine.UI.Graphic)vc.csObj;
            var result = _this.raycastTarget;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.UI.Graphic _this = (UnityEngine.UI.Graphic)vc.csObj;
            _this.raycastTarget = arg0;
        }
    }
    static void Graphic_rectTransform(JSVCall vc)
    {
        UnityEngine.UI.Graphic _this = (UnityEngine.UI.Graphic)vc.csObj;
        var result = _this.rectTransform;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Graphic_defaultGraphicMaterial(JSVCall vc)
    {
        var result = UnityEngine.UI.Graphic.defaultGraphicMaterial;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    // methods
    static bool Graphic_CrossFadeAlpha__Single__Single__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            bool arg2 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            ((UnityEngine.UI.Graphic)vc.csObj).CrossFadeAlpha(arg0, arg1, arg2);
        }
        return true;
    }
    static bool Graphic_CrossFadeColor__Color__Single__Boolean__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 4)
        {
            UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            bool arg2 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            bool arg3 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            ((UnityEngine.UI.Graphic)vc.csObj).CrossFadeColor(arg0, arg1, arg2, arg3);
        }
        return true;
    }
    static bool Graphic_CrossFadeColor__Color__Single__Boolean__Boolean__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            bool arg2 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            bool arg3 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            bool arg4 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            ((UnityEngine.UI.Graphic)vc.csObj).CrossFadeColor(arg0, arg1, arg2, arg3, arg4);
        }
        return true;
    }
    static bool Graphic_GetPixelAdjustedRect(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.UI.Graphic)vc.csObj).GetPixelAdjustedRect());
        }
        return true;
    }
    static bool Graphic_GraphicUpdateComplete(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.Graphic)vc.csObj).GraphicUpdateComplete();
        }
        return true;
    }
    static bool Graphic_LayoutComplete(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.Graphic)vc.csObj).LayoutComplete();
        }
        return true;
    }
    static bool Graphic_OnRebuildRequested(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.Graphic)vc.csObj).OnRebuildRequested();
        }
        return true;
    }
    static bool Graphic_PixelAdjustPoint__Vector2(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.UI.Graphic)vc.csObj).PixelAdjustPoint(arg0));
        }
        return true;
    }
    static bool Graphic_Raycast__Vector2__Camera(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Camera arg1 = (UnityEngine.Camera)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.UI.Graphic)vc.csObj).Raycast(arg0, arg1)));
        }
        return true;
    }
    static bool Graphic_Rebuild__CanvasUpdate(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.UI.CanvasUpdate arg0 = (UnityEngine.UI.CanvasUpdate)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.UI.Graphic)vc.csObj).Rebuild(arg0);
        }
        return true;
    }
    public static UnityEngine.Events.UnityAction Graphic_RegisterDirtyLayoutCallback_GetDelegate_member10_arg0(CSRepresentedObject objFunction)
    {
        if (objFunction == null || objFunction.jsObjID == 0)
            return null;
         
        UnityEngine.Events.UnityAction action = JSMgr.getJSFunCSDelegateRel<UnityEngine.Events.UnityAction>(objFunction.jsObjID);
        if (action != null)
            return action;
         
        action = () => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
        return action;

    }
    static bool Graphic_RegisterDirtyLayoutCallback__UnityAction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Events.UnityAction arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Events.UnityAction>(() => 
                {
                    if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                    {
                        return Graphic_RegisterDirtyLayoutCallback_GetDelegate_member10_arg0(JSApi.getFunctionS((int)JSApi.GetType.Arg));
                    }
                    else
                    {
                        return (UnityEngine.Events.UnityAction)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                    }
                }
                );
            ;
            ((UnityEngine.UI.Graphic)vc.csObj).RegisterDirtyLayoutCallback(arg0);
        }
        return true;
    }
    public static UnityEngine.Events.UnityAction Graphic_RegisterDirtyMaterialCallback_GetDelegate_member11_arg0(CSRepresentedObject objFunction)
    {
        if (objFunction == null || objFunction.jsObjID == 0)
            return null;
         
        UnityEngine.Events.UnityAction action = JSMgr.getJSFunCSDelegateRel<UnityEngine.Events.UnityAction>(objFunction.jsObjID);
        if (action != null)
            return action;
         
        action = () => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
        return action;

    }
    static bool Graphic_RegisterDirtyMaterialCallback__UnityAction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Events.UnityAction arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Events.UnityAction>(() => 
                {
                    if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                    {
                        return Graphic_RegisterDirtyMaterialCallback_GetDelegate_member11_arg0(JSApi.getFunctionS((int)JSApi.GetType.Arg));
                    }
                    else
                    {
                        return (UnityEngine.Events.UnityAction)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                    }
                }
                );
            ;
            ((UnityEngine.UI.Graphic)vc.csObj).RegisterDirtyMaterialCallback(arg0);
        }
        return true;
    }
    public static UnityEngine.Events.UnityAction Graphic_RegisterDirtyVerticesCallback_GetDelegate_member12_arg0(CSRepresentedObject objFunction)
    {
        if (objFunction == null || objFunction.jsObjID == 0)
            return null;
         
        UnityEngine.Events.UnityAction action = JSMgr.getJSFunCSDelegateRel<UnityEngine.Events.UnityAction>(objFunction.jsObjID);
        if (action != null)
            return action;
         
        action = () => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
        return action;

    }
    static bool Graphic_RegisterDirtyVerticesCallback__UnityAction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Events.UnityAction arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Events.UnityAction>(() => 
                {
                    if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                    {
                        return Graphic_RegisterDirtyVerticesCallback_GetDelegate_member12_arg0(JSApi.getFunctionS((int)JSApi.GetType.Arg));
                    }
                    else
                    {
                        return (UnityEngine.Events.UnityAction)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                    }
                }
                );
            ;
            ((UnityEngine.UI.Graphic)vc.csObj).RegisterDirtyVerticesCallback(arg0);
        }
        return true;
    }
    static bool Graphic_SetAllDirty(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.Graphic)vc.csObj).SetAllDirty();
        }
        return true;
    }
    static bool Graphic_SetLayoutDirty(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.Graphic)vc.csObj).SetLayoutDirty();
        }
        return true;
    }
    static bool Graphic_SetMaterialDirty(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.Graphic)vc.csObj).SetMaterialDirty();
        }
        return true;
    }
    static bool Graphic_SetNativeSize(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.Graphic)vc.csObj).SetNativeSize();
        }
        return true;
    }
    static bool Graphic_SetVerticesDirty(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.UI.Graphic)vc.csObj).SetVerticesDirty();
        }
        return true;
    }
    public static UnityEngine.Events.UnityAction Graphic_UnregisterDirtyLayoutCallback_GetDelegate_member18_arg0(CSRepresentedObject objFunction)
    {
        if (objFunction == null || objFunction.jsObjID == 0)
            return null;
         
        UnityEngine.Events.UnityAction action = JSMgr.getJSFunCSDelegateRel<UnityEngine.Events.UnityAction>(objFunction.jsObjID);
        if (action != null)
            return action;
         
        action = () => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
        return action;

    }
    static bool Graphic_UnregisterDirtyLayoutCallback__UnityAction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Events.UnityAction arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Events.UnityAction>(() => 
                {
                    if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                    {
                        return Graphic_UnregisterDirtyLayoutCallback_GetDelegate_member18_arg0(JSApi.getFunctionS((int)JSApi.GetType.Arg));
                    }
                    else
                    {
                        return (UnityEngine.Events.UnityAction)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                    }
                }
                );
            ;
            ((UnityEngine.UI.Graphic)vc.csObj).UnregisterDirtyLayoutCallback(arg0);
        }
        return true;
    }
    public static UnityEngine.Events.UnityAction Graphic_UnregisterDirtyMaterialCallback_GetDelegate_member19_arg0(CSRepresentedObject objFunction)
    {
        if (objFunction == null || objFunction.jsObjID == 0)
            return null;
         
        UnityEngine.Events.UnityAction action = JSMgr.getJSFunCSDelegateRel<UnityEngine.Events.UnityAction>(objFunction.jsObjID);
        if (action != null)
            return action;
         
        action = () => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
        return action;

    }
    static bool Graphic_UnregisterDirtyMaterialCallback__UnityAction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Events.UnityAction arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Events.UnityAction>(() => 
                {
                    if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                    {
                        return Graphic_UnregisterDirtyMaterialCallback_GetDelegate_member19_arg0(JSApi.getFunctionS((int)JSApi.GetType.Arg));
                    }
                    else
                    {
                        return (UnityEngine.Events.UnityAction)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                    }
                }
                );
            ;
            ((UnityEngine.UI.Graphic)vc.csObj).UnregisterDirtyMaterialCallback(arg0);
        }
        return true;
    }
    public static UnityEngine.Events.UnityAction Graphic_UnregisterDirtyVerticesCallback_GetDelegate_member20_arg0(CSRepresentedObject objFunction)
    {
        if (objFunction == null || objFunction.jsObjID == 0)
            return null;
         
        UnityEngine.Events.UnityAction action = JSMgr.getJSFunCSDelegateRel<UnityEngine.Events.UnityAction>(objFunction.jsObjID);
        if (action != null)
            return action;
         
        action = () => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
        return action;

    }
    static bool Graphic_UnregisterDirtyVerticesCallback__UnityAction(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Events.UnityAction arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Events.UnityAction>(() => 
                {
                    if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                    {
                        return Graphic_UnregisterDirtyVerticesCallback_GetDelegate_member20_arg0(JSApi.getFunctionS((int)JSApi.GetType.Arg));
                    }
                    else
                    {
                        return (UnityEngine.Events.UnityAction)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                    }
                }
                );
            ;
            ((UnityEngine.UI.Graphic)vc.csObj).UnregisterDirtyVerticesCallback(arg0);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.UI.Graphic);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Graphic_canvas,
            Graphic_canvasRenderer,
            Graphic_color,
            Graphic_defaultMaterial,
            Graphic_depth,
            Graphic_mainTexture,
            Graphic_material,
            Graphic_materialForRendering,
            Graphic_raycastTarget,
            Graphic_rectTransform,
            Graphic_defaultGraphicMaterial,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Graphic_CrossFadeAlpha__Single__Single__Boolean, "CrossFadeAlpha"),
            new JSMgr.MethodCallBackInfo(Graphic_CrossFadeColor__Color__Single__Boolean__Boolean, "CrossFadeColor"),
            new JSMgr.MethodCallBackInfo(Graphic_CrossFadeColor__Color__Single__Boolean__Boolean__Boolean, "CrossFadeColor"),
            new JSMgr.MethodCallBackInfo(Graphic_GetPixelAdjustedRect, "GetPixelAdjustedRect"),
            new JSMgr.MethodCallBackInfo(Graphic_GraphicUpdateComplete, "GraphicUpdateComplete"),
            new JSMgr.MethodCallBackInfo(Graphic_LayoutComplete, "LayoutComplete"),
            new JSMgr.MethodCallBackInfo(Graphic_OnRebuildRequested, "OnRebuildRequested"),
            new JSMgr.MethodCallBackInfo(Graphic_PixelAdjustPoint__Vector2, "PixelAdjustPoint"),
            new JSMgr.MethodCallBackInfo(Graphic_Raycast__Vector2__Camera, "Raycast"),
            new JSMgr.MethodCallBackInfo(Graphic_Rebuild__CanvasUpdate, "Rebuild"),
            new JSMgr.MethodCallBackInfo(Graphic_RegisterDirtyLayoutCallback__UnityAction, "RegisterDirtyLayoutCallback"),
            new JSMgr.MethodCallBackInfo(Graphic_RegisterDirtyMaterialCallback__UnityAction, "RegisterDirtyMaterialCallback"),
            new JSMgr.MethodCallBackInfo(Graphic_RegisterDirtyVerticesCallback__UnityAction, "RegisterDirtyVerticesCallback"),
            new JSMgr.MethodCallBackInfo(Graphic_SetAllDirty, "SetAllDirty"),
            new JSMgr.MethodCallBackInfo(Graphic_SetLayoutDirty, "SetLayoutDirty"),
            new JSMgr.MethodCallBackInfo(Graphic_SetMaterialDirty, "SetMaterialDirty"),
            new JSMgr.MethodCallBackInfo(Graphic_SetNativeSize, "SetNativeSize"),
            new JSMgr.MethodCallBackInfo(Graphic_SetVerticesDirty, "SetVerticesDirty"),
            new JSMgr.MethodCallBackInfo(Graphic_UnregisterDirtyLayoutCallback__UnityAction, "UnregisterDirtyLayoutCallback"),
            new JSMgr.MethodCallBackInfo(Graphic_UnregisterDirtyMaterialCallback__UnityAction, "UnregisterDirtyMaterialCallback"),
            new JSMgr.MethodCallBackInfo(Graphic_UnregisterDirtyVerticesCallback__UnityAction, "UnregisterDirtyVerticesCallback"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}