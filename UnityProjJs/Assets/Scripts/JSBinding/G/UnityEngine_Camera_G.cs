﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Camera_G
{
    ////////////////////// Camera ///////////////////////////////////////
    // constructors
    static bool Camera_Camera(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Camera());
        }
        return true;
    }
    // fields
    public static UnityEngine.Camera.CameraCallback Camera_onPreCull_GetDelegate_member0_arg0(CSRepresentedObject objFunction)
    {
        if (objFunction == null || objFunction.jsObjID == 0)
            return null;
         
        UnityEngine.Camera.CameraCallback action = JSMgr.getJSFunCSDelegateRel<UnityEngine.Camera.CameraCallback>(objFunction.jsObjID);
        if (action != null)
            return action;
         
        action = (cam) => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID, cam);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
        return action;

    }
    static void Camera_onPreCull(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Camera.onPreCull;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Camera.onPreCull = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Camera.CameraCallback>(() => 
                {
                    if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                    {
                        return Camera_onPreCull_GetDelegate_member0_arg0(JSApi.getFunctionS((int)JSApi.GetType.Arg));
                    }
                    else
                    {
                        return (UnityEngine.Camera.CameraCallback)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                    }
                }
                );
            ;
        }
    }
    public static UnityEngine.Camera.CameraCallback Camera_onPreRender_GetDelegate_member1_arg0(CSRepresentedObject objFunction)
    {
        if (objFunction == null || objFunction.jsObjID == 0)
            return null;
         
        UnityEngine.Camera.CameraCallback action = JSMgr.getJSFunCSDelegateRel<UnityEngine.Camera.CameraCallback>(objFunction.jsObjID);
        if (action != null)
            return action;
         
        action = (cam) => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID, cam);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
        return action;

    }
    static void Camera_onPreRender(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Camera.onPreRender;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Camera.onPreRender = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Camera.CameraCallback>(() => 
                {
                    if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                    {
                        return Camera_onPreRender_GetDelegate_member1_arg0(JSApi.getFunctionS((int)JSApi.GetType.Arg));
                    }
                    else
                    {
                        return (UnityEngine.Camera.CameraCallback)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                    }
                }
                );
            ;
        }
    }
    public static UnityEngine.Camera.CameraCallback Camera_onPostRender_GetDelegate_member2_arg0(CSRepresentedObject objFunction)
    {
        if (objFunction == null || objFunction.jsObjID == 0)
            return null;
         
        UnityEngine.Camera.CameraCallback action = JSMgr.getJSFunCSDelegateRel<UnityEngine.Camera.CameraCallback>(objFunction.jsObjID);
        if (action != null)
            return action;
         
        action = (cam) => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID, cam);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
        return action;

    }
    static void Camera_onPostRender(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Camera.onPostRender;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Camera.onPostRender = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Camera.CameraCallback>(() => 
                {
                    if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                    {
                        return Camera_onPostRender_GetDelegate_member2_arg0(JSApi.getFunctionS((int)JSApi.GetType.Arg));
                    }
                    else
                    {
                        return (UnityEngine.Camera.CameraCallback)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                    }
                }
                );
            ;
        }
    }
    // properties
    static void Camera_actualRenderingPath(JSVCall vc)
    {
        UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
        var result = _this.actualRenderingPath;
        JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    static void Camera_aspect(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.aspect;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.aspect = arg0;
        }
    }
    static void Camera_backgroundColor(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.backgroundColor;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.backgroundColor = arg0;
        }
    }
    static void Camera_cameraToWorldMatrix(JSVCall vc)
    {
        UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
        var result = _this.cameraToWorldMatrix;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Camera_cameraType(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.cameraType;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.CameraType arg0 = (UnityEngine.CameraType)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.cameraType = arg0;
        }
    }
    static void Camera_clearFlags(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.clearFlags;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.CameraClearFlags arg0 = (UnityEngine.CameraClearFlags)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.clearFlags = arg0;
        }
    }
    static void Camera_clearStencilAfterLightingPass(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.clearStencilAfterLightingPass;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.clearStencilAfterLightingPass = arg0;
        }
    }
    static void Camera_commandBufferCount(JSVCall vc)
    {
        UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
        var result = _this.commandBufferCount;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Camera_cullingMask(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.cullingMask;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.cullingMask = arg0;
        }
    }
    static void Camera_cullingMatrix(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.cullingMatrix;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Matrix4x4 arg0 = (UnityEngine.Matrix4x4)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.cullingMatrix = arg0;
        }
    }
    static void Camera_depth(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.depth;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.depth = arg0;
        }
    }
    static void Camera_depthTextureMode(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.depthTextureMode;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.DepthTextureMode arg0 = (UnityEngine.DepthTextureMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.depthTextureMode = arg0;
        }
    }
    static void Camera_eventMask(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.eventMask;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.eventMask = arg0;
        }
    }
    static void Camera_farClipPlane(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.farClipPlane;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.farClipPlane = arg0;
        }
    }
    static void Camera_fieldOfView(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.fieldOfView;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.fieldOfView = arg0;
        }
    }
    static void Camera_hdr(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.hdr;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.hdr = arg0;
        }
    }
    static void Camera_layerCullDistances(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.layerCullDistances;
                var arrRet = (float[])result;
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSApi.setSingle((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        else
        {
            float[] arg0 = 
                JSDataExchangeMgr.GetJSArg<float[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new float[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (float)JSApi.getSingle((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.layerCullDistances = arg0;
        }
    }
    static void Camera_layerCullSpherical(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.layerCullSpherical;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.layerCullSpherical = arg0;
        }
    }
    static void Camera_nearClipPlane(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.nearClipPlane;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.nearClipPlane = arg0;
        }
    }
    static void Camera_nonJitteredProjectionMatrix(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.nonJitteredProjectionMatrix;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Matrix4x4 arg0 = (UnityEngine.Matrix4x4)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.nonJitteredProjectionMatrix = arg0;
        }
    }
    static void Camera_opaqueSortMode(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.opaqueSortMode;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.Rendering.OpaqueSortMode arg0 = (UnityEngine.Rendering.OpaqueSortMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.opaqueSortMode = arg0;
        }
    }
    static void Camera_orthographic(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.orthographic;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.orthographic = arg0;
        }
    }
    static void Camera_orthographicSize(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.orthographicSize;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.orthographicSize = arg0;
        }
    }
    static void Camera_pixelHeight(JSVCall vc)
    {
        UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
        var result = _this.pixelHeight;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Camera_pixelRect(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.pixelRect;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.pixelRect = arg0;
        }
    }
    static void Camera_pixelWidth(JSVCall vc)
    {
        UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
        var result = _this.pixelWidth;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Camera_projectionMatrix(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.projectionMatrix;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Matrix4x4 arg0 = (UnityEngine.Matrix4x4)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.projectionMatrix = arg0;
        }
    }
    static void Camera_rect(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.rect;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.rect = arg0;
        }
    }
    static void Camera_renderingPath(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.renderingPath;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.RenderingPath arg0 = (UnityEngine.RenderingPath)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.renderingPath = arg0;
        }
    }
    static void Camera_stereoConvergence(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.stereoConvergence;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.stereoConvergence = arg0;
        }
    }
    static void Camera_stereoEnabled(JSVCall vc)
    {
        UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
        var result = _this.stereoEnabled;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Camera_stereoMirrorMode(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.stereoMirrorMode;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.stereoMirrorMode = arg0;
        }
    }
    static void Camera_stereoSeparation(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.stereoSeparation;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.stereoSeparation = arg0;
        }
    }
    static void Camera_stereoTargetEye(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.stereoTargetEye;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.StereoTargetEyeMask arg0 = (UnityEngine.StereoTargetEyeMask)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.stereoTargetEye = arg0;
        }
    }
    static void Camera_targetDisplay(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.targetDisplay;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.targetDisplay = arg0;
        }
    }
    static void Camera_targetTexture(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.targetTexture;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.RenderTexture arg0 = (UnityEngine.RenderTexture)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.targetTexture = arg0;
        }
    }
    static void Camera_transparencySortMode(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.transparencySortMode;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.TransparencySortMode arg0 = (UnityEngine.TransparencySortMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.transparencySortMode = arg0;
        }
    }
    static void Camera_useOcclusionCulling(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.useOcclusionCulling;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.useOcclusionCulling = arg0;
        }
    }
    static void Camera_velocity(JSVCall vc)
    {
        UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
        var result = _this.velocity;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Camera_worldToCameraMatrix(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            var result = _this.worldToCameraMatrix;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Matrix4x4 arg0 = (UnityEngine.Matrix4x4)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Camera _this = (UnityEngine.Camera)vc.csObj;
            _this.worldToCameraMatrix = arg0;
        }
    }
    static void Camera_allCameras(JSVCall vc)
    {
        var result = UnityEngine.Camera.allCameras;
            var arrRet = (UnityEngine.Camera[])result;
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }
    static void Camera_allCamerasCount(JSVCall vc)
    {
        var result = UnityEngine.Camera.allCamerasCount;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Camera_current(JSVCall vc)
    {
        var result = UnityEngine.Camera.current;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    static void Camera_main(JSVCall vc)
    {
        var result = UnityEngine.Camera.main;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    // methods
    static bool Camera_AddCommandBuffer__CameraEvent__CommandBuffer(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Rendering.CameraEvent arg0 = (UnityEngine.Rendering.CameraEvent)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Rendering.CommandBuffer arg1 = (UnityEngine.Rendering.CommandBuffer)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Camera)vc.csObj).AddCommandBuffer(arg0, arg1);
        }
        return true;
    }
    static bool Camera_CalculateObliqueMatrix__Vector4(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector4 arg0 = (UnityEngine.Vector4)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Camera)vc.csObj).CalculateObliqueMatrix(arg0));
        }
        return true;
    }
    static bool Camera_CopyFrom__Camera(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Camera arg0 = (UnityEngine.Camera)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Camera)vc.csObj).CopyFrom(arg0);
        }
        return true;
    }
    static bool Camera_GetCommandBuffers__CameraEvent(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Rendering.CameraEvent arg0 = (UnityEngine.Rendering.CameraEvent)JSApi.getEnum((int)JSApi.GetType.Arg);
                var arrRet = (UnityEngine.Rendering.CommandBuffer[])((UnityEngine.Camera)vc.csObj).GetCommandBuffers(arg0);
    for (int i = 0; arrRet != null && i < arrRet.Length; i++)
    {
        JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
        JSApi.moveSaveID2Arr(i);
    }
    JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
        }
        return true;
    }
    static bool Camera_RemoveAllCommandBuffers(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Camera)vc.csObj).RemoveAllCommandBuffers();
        }
        return true;
    }
    static bool Camera_RemoveCommandBuffer__CameraEvent__CommandBuffer(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Rendering.CameraEvent arg0 = (UnityEngine.Rendering.CameraEvent)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Rendering.CommandBuffer arg1 = (UnityEngine.Rendering.CommandBuffer)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Camera)vc.csObj).RemoveCommandBuffer(arg0, arg1);
        }
        return true;
    }
    static bool Camera_RemoveCommandBuffers__CameraEvent(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Rendering.CameraEvent arg0 = (UnityEngine.Rendering.CameraEvent)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.Camera)vc.csObj).RemoveCommandBuffers(arg0);
        }
        return true;
    }
    static bool Camera_Render(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Camera)vc.csObj).Render();
        }
        return true;
    }
    static bool Camera_RenderDontRestore(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Camera)vc.csObj).RenderDontRestore();
        }
        return true;
    }
    static bool Camera_RenderToCubemap__Cubemap(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Cubemap arg0 = (UnityEngine.Cubemap)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Camera)vc.csObj).RenderToCubemap(arg0)));
        }
        return true;
    }
    static bool Camera_RenderToCubemap__Cubemap__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Cubemap arg0 = (UnityEngine.Cubemap)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Camera)vc.csObj).RenderToCubemap(arg0, arg1)));
        }
        return true;
    }
    static bool Camera_RenderToCubemap__RenderTexture(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.RenderTexture arg0 = (UnityEngine.RenderTexture)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Camera)vc.csObj).RenderToCubemap(arg0)));
        }
        return true;
    }
    static bool Camera_RenderToCubemap__RenderTexture__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.RenderTexture arg0 = (UnityEngine.RenderTexture)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.Camera)vc.csObj).RenderToCubemap(arg0, arg1)));
        }
        return true;
    }
    static bool Camera_RenderWithShader__Shader__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Shader arg0 = (UnityEngine.Shader)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            string arg1 = JSApi.getStringS((int)JSApi.GetType.Arg);
            ((UnityEngine.Camera)vc.csObj).RenderWithShader(arg0, arg1);
        }
        return true;
    }
    static bool Camera_ResetAspect(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Camera)vc.csObj).ResetAspect();
        }
        return true;
    }
    static bool Camera_ResetCullingMatrix(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Camera)vc.csObj).ResetCullingMatrix();
        }
        return true;
    }
    static bool Camera_ResetFieldOfView(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Camera)vc.csObj).ResetFieldOfView();
        }
        return true;
    }
    static bool Camera_ResetProjectionMatrix(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Camera)vc.csObj).ResetProjectionMatrix();
        }
        return true;
    }
    static bool Camera_ResetReplacementShader(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Camera)vc.csObj).ResetReplacementShader();
        }
        return true;
    }
    static bool Camera_ResetStereoProjectionMatrices(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Camera)vc.csObj).ResetStereoProjectionMatrices();
        }
        return true;
    }
    static bool Camera_ResetStereoViewMatrices(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Camera)vc.csObj).ResetStereoViewMatrices();
        }
        return true;
    }
    static bool Camera_ResetWorldToCameraMatrix(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.Camera)vc.csObj).ResetWorldToCameraMatrix();
        }
        return true;
    }
    static bool Camera_ScreenPointToRay__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Camera)vc.csObj).ScreenPointToRay(arg0));
        }
        return true;
    }
    static bool Camera_ScreenToViewportPoint__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Camera)vc.csObj).ScreenToViewportPoint(arg0));
        }
        return true;
    }
    static bool Camera_ScreenToWorldPoint__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Camera)vc.csObj).ScreenToWorldPoint(arg0));
        }
        return true;
    }
    static bool Camera_SetReplacementShader__Shader__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Shader arg0 = (UnityEngine.Shader)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            string arg1 = JSApi.getStringS((int)JSApi.GetType.Arg);
            ((UnityEngine.Camera)vc.csObj).SetReplacementShader(arg0, arg1);
        }
        return true;
    }
    static bool Camera_SetStereoProjectionMatrices__Matrix4x4__Matrix4x4(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Matrix4x4 arg0 = (UnityEngine.Matrix4x4)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Matrix4x4 arg1 = (UnityEngine.Matrix4x4)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Camera)vc.csObj).SetStereoProjectionMatrices(arg0, arg1);
        }
        return true;
    }
    static bool Camera_SetStereoViewMatrices__Matrix4x4__Matrix4x4(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.Matrix4x4 arg0 = (UnityEngine.Matrix4x4)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Matrix4x4 arg1 = (UnityEngine.Matrix4x4)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Camera)vc.csObj).SetStereoViewMatrices(arg0, arg1);
        }
        return true;
    }
    static bool Camera_SetTargetBuffers__RenderBuffer__RenderBuffer(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.RenderBuffer arg0 = (UnityEngine.RenderBuffer)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.RenderBuffer arg1 = (UnityEngine.RenderBuffer)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Camera)vc.csObj).SetTargetBuffers(arg0, arg1);
        }
        return true;
    }
    static bool Camera_SetTargetBuffers__RenderBuffer_Array__RenderBuffer(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.RenderBuffer[] arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.RenderBuffer[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.RenderBuffer[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.RenderBuffer)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            UnityEngine.RenderBuffer arg1 = (UnityEngine.RenderBuffer)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.Camera)vc.csObj).SetTargetBuffers(arg0, arg1);
        }
        return true;
    }
    static bool Camera_ViewportPointToRay__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Camera)vc.csObj).ViewportPointToRay(arg0));
        }
        return true;
    }
    static bool Camera_ViewportToScreenPoint__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Camera)vc.csObj).ViewportToScreenPoint(arg0));
        }
        return true;
    }
    static bool Camera_ViewportToWorldPoint__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Camera)vc.csObj).ViewportToWorldPoint(arg0));
        }
        return true;
    }
    static bool Camera_WorldToScreenPoint__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Camera)vc.csObj).WorldToScreenPoint(arg0));
        }
        return true;
    }
    static bool Camera_WorldToViewportPoint__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.Camera)vc.csObj).WorldToViewportPoint(arg0));
        }
        return true;
    }
    static bool Camera_GetAllCameras__Camera_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Camera[] arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Camera[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.Camera[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.Camera)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(UnityEngine.Camera.GetAllCameras(arg0)));
        }
        return true;
    }
    static bool Camera_SetupCurrent__Camera(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Camera arg0 = (UnityEngine.Camera)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Camera.SetupCurrent(arg0);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Camera);
        ci.fields = new JSMgr.CSCallbackField[]
        {
            Camera_onPreCull,
            Camera_onPreRender,
            Camera_onPostRender,
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Camera_actualRenderingPath,
            Camera_aspect,
            Camera_backgroundColor,
            Camera_cameraToWorldMatrix,
            Camera_cameraType,
            Camera_clearFlags,
            Camera_clearStencilAfterLightingPass,
            Camera_commandBufferCount,
            Camera_cullingMask,
            Camera_cullingMatrix,
            Camera_depth,
            Camera_depthTextureMode,
            Camera_eventMask,
            Camera_farClipPlane,
            Camera_fieldOfView,
            Camera_hdr,
            Camera_layerCullDistances,
            Camera_layerCullSpherical,
            Camera_nearClipPlane,
            Camera_nonJitteredProjectionMatrix,
            Camera_opaqueSortMode,
            Camera_orthographic,
            Camera_orthographicSize,
            Camera_pixelHeight,
            Camera_pixelRect,
            Camera_pixelWidth,
            Camera_projectionMatrix,
            Camera_rect,
            Camera_renderingPath,
            Camera_stereoConvergence,
            Camera_stereoEnabled,
            Camera_stereoMirrorMode,
            Camera_stereoSeparation,
            Camera_stereoTargetEye,
            Camera_targetDisplay,
            Camera_targetTexture,
            Camera_transparencySortMode,
            Camera_useOcclusionCulling,
            Camera_velocity,
            Camera_worldToCameraMatrix,
            Camera_allCameras,
            Camera_allCamerasCount,
            Camera_current,
            Camera_main,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Camera_Camera, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Camera_AddCommandBuffer__CameraEvent__CommandBuffer, "AddCommandBuffer"),
            new JSMgr.MethodCallBackInfo(Camera_CalculateObliqueMatrix__Vector4, "CalculateObliqueMatrix"),
            new JSMgr.MethodCallBackInfo(Camera_CopyFrom__Camera, "CopyFrom"),
            new JSMgr.MethodCallBackInfo(Camera_GetCommandBuffers__CameraEvent, "GetCommandBuffers"),
            new JSMgr.MethodCallBackInfo(Camera_RemoveAllCommandBuffers, "RemoveAllCommandBuffers"),
            new JSMgr.MethodCallBackInfo(Camera_RemoveCommandBuffer__CameraEvent__CommandBuffer, "RemoveCommandBuffer"),
            new JSMgr.MethodCallBackInfo(Camera_RemoveCommandBuffers__CameraEvent, "RemoveCommandBuffers"),
            new JSMgr.MethodCallBackInfo(Camera_Render, "Render"),
            new JSMgr.MethodCallBackInfo(Camera_RenderDontRestore, "RenderDontRestore"),
            new JSMgr.MethodCallBackInfo(Camera_RenderToCubemap__Cubemap, "RenderToCubemap"),
            new JSMgr.MethodCallBackInfo(Camera_RenderToCubemap__Cubemap__Int32, "RenderToCubemap"),
            new JSMgr.MethodCallBackInfo(Camera_RenderToCubemap__RenderTexture, "RenderToCubemap"),
            new JSMgr.MethodCallBackInfo(Camera_RenderToCubemap__RenderTexture__Int32, "RenderToCubemap"),
            new JSMgr.MethodCallBackInfo(Camera_RenderWithShader__Shader__String, "RenderWithShader"),
            new JSMgr.MethodCallBackInfo(Camera_ResetAspect, "ResetAspect"),
            new JSMgr.MethodCallBackInfo(Camera_ResetCullingMatrix, "ResetCullingMatrix"),
            new JSMgr.MethodCallBackInfo(Camera_ResetFieldOfView, "ResetFieldOfView"),
            new JSMgr.MethodCallBackInfo(Camera_ResetProjectionMatrix, "ResetProjectionMatrix"),
            new JSMgr.MethodCallBackInfo(Camera_ResetReplacementShader, "ResetReplacementShader"),
            new JSMgr.MethodCallBackInfo(Camera_ResetStereoProjectionMatrices, "ResetStereoProjectionMatrices"),
            new JSMgr.MethodCallBackInfo(Camera_ResetStereoViewMatrices, "ResetStereoViewMatrices"),
            new JSMgr.MethodCallBackInfo(Camera_ResetWorldToCameraMatrix, "ResetWorldToCameraMatrix"),
            new JSMgr.MethodCallBackInfo(Camera_ScreenPointToRay__Vector3, "ScreenPointToRay"),
            new JSMgr.MethodCallBackInfo(Camera_ScreenToViewportPoint__Vector3, "ScreenToViewportPoint"),
            new JSMgr.MethodCallBackInfo(Camera_ScreenToWorldPoint__Vector3, "ScreenToWorldPoint"),
            new JSMgr.MethodCallBackInfo(Camera_SetReplacementShader__Shader__String, "SetReplacementShader"),
            new JSMgr.MethodCallBackInfo(Camera_SetStereoProjectionMatrices__Matrix4x4__Matrix4x4, "SetStereoProjectionMatrices"),
            new JSMgr.MethodCallBackInfo(Camera_SetStereoViewMatrices__Matrix4x4__Matrix4x4, "SetStereoViewMatrices"),
            new JSMgr.MethodCallBackInfo(Camera_SetTargetBuffers__RenderBuffer__RenderBuffer, "SetTargetBuffers"),
            new JSMgr.MethodCallBackInfo(Camera_SetTargetBuffers__RenderBuffer_Array__RenderBuffer, "SetTargetBuffers"),
            new JSMgr.MethodCallBackInfo(Camera_ViewportPointToRay__Vector3, "ViewportPointToRay"),
            new JSMgr.MethodCallBackInfo(Camera_ViewportToScreenPoint__Vector3, "ViewportToScreenPoint"),
            new JSMgr.MethodCallBackInfo(Camera_ViewportToWorldPoint__Vector3, "ViewportToWorldPoint"),
            new JSMgr.MethodCallBackInfo(Camera_WorldToScreenPoint__Vector3, "WorldToScreenPoint"),
            new JSMgr.MethodCallBackInfo(Camera_WorldToViewportPoint__Vector3, "WorldToViewportPoint"),
            new JSMgr.MethodCallBackInfo(Camera_GetAllCameras__Camera_Array, "GetAllCameras"),
            new JSMgr.MethodCallBackInfo(Camera_SetupCurrent__Camera, "SetupCurrent"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}