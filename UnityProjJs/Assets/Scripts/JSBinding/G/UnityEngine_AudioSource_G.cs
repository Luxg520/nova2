
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_AudioSource_G
{
    ////////////////////// AudioSource ///////////////////////////////////////
    // constructors
    static bool AudioSource_AudioSource(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.AudioSource());
        }
        return true;
    }
    // fields
    // properties
    static void AudioSource_bypassEffects(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.bypassEffects;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.bypassEffects = arg0;
        }
    }
    static void AudioSource_bypassListenerEffects(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.bypassListenerEffects;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.bypassListenerEffects = arg0;
        }
    }
    static void AudioSource_bypassReverbZones(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.bypassReverbZones;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.bypassReverbZones = arg0;
        }
    }
    static void AudioSource_clip(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.clip;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.AudioClip arg0 = (UnityEngine.AudioClip)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.clip = arg0;
        }
    }
    static void AudioSource_dopplerLevel(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.dopplerLevel;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.dopplerLevel = arg0;
        }
    }
    static void AudioSource_ignoreListenerPause(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.ignoreListenerPause;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.ignoreListenerPause = arg0;
        }
    }
    static void AudioSource_ignoreListenerVolume(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.ignoreListenerVolume;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.ignoreListenerVolume = arg0;
        }
    }
    static void AudioSource_isPlaying(JSVCall vc)
    {
        UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
        var result = _this.isPlaying;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void AudioSource_loop(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.loop;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.loop = arg0;
        }
    }
    static void AudioSource_maxDistance(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.maxDistance;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.maxDistance = arg0;
        }
    }
    static void AudioSource_minDistance(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.minDistance;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.minDistance = arg0;
        }
    }
    static void AudioSource_mute(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.mute;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.mute = arg0;
        }
    }
    static void AudioSource_pan(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.pan;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.pan = arg0;
        }
    }
    static void AudioSource_panLevel(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.panLevel;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.panLevel = arg0;
        }
    }
    static void AudioSource_pitch(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.pitch;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.pitch = arg0;
        }
    }
    static void AudioSource_playOnAwake(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.playOnAwake;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.playOnAwake = arg0;
        }
    }
    static void AudioSource_priority(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.priority;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.priority = arg0;
        }
    }
    static void AudioSource_rolloffMode(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.rolloffMode;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.AudioRolloffMode arg0 = (UnityEngine.AudioRolloffMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.rolloffMode = arg0;
        }
    }
    static void AudioSource_spread(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.spread;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.spread = arg0;
        }
    }
    static void AudioSource_time(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.time;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.time = arg0;
        }
    }
    static void AudioSource_timeSamples(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.timeSamples;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.timeSamples = arg0;
        }
    }
    static void AudioSource_velocityUpdateMode(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.velocityUpdateMode;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.AudioVelocityUpdateMode arg0 = (UnityEngine.AudioVelocityUpdateMode)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.velocityUpdateMode = arg0;
        }
    }
    static void AudioSource_volume(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            var result = _this.volume;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource _this = (UnityEngine.AudioSource)vc.csObj;
            _this.volume = arg0;
        }
    }
    // methods
    static bool AudioSource_GetOutputData__Single_Array__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
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
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.AudioSource)vc.csObj).GetOutputData(arg0, arg1);
        }
        return true;
    }
    static bool AudioSource_GetSpectrumData__Single_Array__Int32__FFTWindow(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
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
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.FFTWindow arg2 = (UnityEngine.FFTWindow)JSApi.getEnum((int)JSApi.GetType.Arg);
            ((UnityEngine.AudioSource)vc.csObj).GetSpectrumData(arg0, arg1, arg2);
        }
        return true;
    }
    static bool AudioSource_Pause(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.AudioSource)vc.csObj).Pause();
        }
        return true;
    }
    static bool AudioSource_Play(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.AudioSource)vc.csObj).Play();
        }
        return true;
    }
    static bool AudioSource_Play__UInt64(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            ulong arg0 = JSApi.getUInt64((int)JSApi.GetType.Arg);
            ((UnityEngine.AudioSource)vc.csObj).Play(arg0);
        }
        return true;
    }
    static bool AudioSource_PlayDelayed__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.AudioSource)vc.csObj).PlayDelayed(arg0);
        }
        return true;
    }
    static bool AudioSource_PlayOneShot__AudioClip(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.AudioClip arg0 = (UnityEngine.AudioClip)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.AudioSource)vc.csObj).PlayOneShot(arg0);
        }
        return true;
    }
    static bool AudioSource_PlayOneShot__AudioClip__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.AudioClip arg0 = (UnityEngine.AudioClip)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg1 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.AudioSource)vc.csObj).PlayOneShot(arg0, arg1);
        }
        return true;
    }
    static bool AudioSource_PlayScheduled__Double(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            double arg0 = JSApi.getDouble((int)JSApi.GetType.Arg);
            ((UnityEngine.AudioSource)vc.csObj).PlayScheduled(arg0);
        }
        return true;
    }
    static bool AudioSource_SetScheduledEndTime__Double(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            double arg0 = JSApi.getDouble((int)JSApi.GetType.Arg);
            ((UnityEngine.AudioSource)vc.csObj).SetScheduledEndTime(arg0);
        }
        return true;
    }
    static bool AudioSource_SetScheduledStartTime__Double(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            double arg0 = JSApi.getDouble((int)JSApi.GetType.Arg);
            ((UnityEngine.AudioSource)vc.csObj).SetScheduledStartTime(arg0);
        }
        return true;
    }
    static bool AudioSource_Stop(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.AudioSource)vc.csObj).Stop();
        }
        return true;
    }
    static bool AudioSource_PlayClipAtPoint__AudioClip__Vector3(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.AudioClip arg0 = (UnityEngine.AudioClip)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource.PlayClipAtPoint(arg0, arg1);
        }
        return true;
    }
    static bool AudioSource_PlayClipAtPoint__AudioClip__Vector3__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            UnityEngine.AudioClip arg0 = (UnityEngine.AudioClip)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.AudioSource.PlayClipAtPoint(arg0, arg1, arg2);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.AudioSource);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            AudioSource_bypassEffects,
            AudioSource_bypassListenerEffects,
            AudioSource_bypassReverbZones,
            AudioSource_clip,
            AudioSource_dopplerLevel,
            AudioSource_ignoreListenerPause,
            AudioSource_ignoreListenerVolume,
            AudioSource_isPlaying,
            AudioSource_loop,
            AudioSource_maxDistance,
            AudioSource_minDistance,
            AudioSource_mute,
            AudioSource_pan,
            AudioSource_panLevel,
            AudioSource_pitch,
            AudioSource_playOnAwake,
            AudioSource_priority,
            AudioSource_rolloffMode,
            AudioSource_spread,
            AudioSource_time,
            AudioSource_timeSamples,
            AudioSource_velocityUpdateMode,
            AudioSource_volume,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(AudioSource_AudioSource, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(AudioSource_GetOutputData__Single_Array__Int32, "GetOutputData"),
            new JSMgr.MethodCallBackInfo(AudioSource_GetSpectrumData__Single_Array__Int32__FFTWindow, "GetSpectrumData"),
            new JSMgr.MethodCallBackInfo(AudioSource_Pause, "Pause"),
            new JSMgr.MethodCallBackInfo(AudioSource_Play, "Play"),
            new JSMgr.MethodCallBackInfo(AudioSource_Play__UInt64, "Play"),
            new JSMgr.MethodCallBackInfo(AudioSource_PlayDelayed__Single, "PlayDelayed"),
            new JSMgr.MethodCallBackInfo(AudioSource_PlayOneShot__AudioClip, "PlayOneShot"),
            new JSMgr.MethodCallBackInfo(AudioSource_PlayOneShot__AudioClip__Single, "PlayOneShot"),
            new JSMgr.MethodCallBackInfo(AudioSource_PlayScheduled__Double, "PlayScheduled"),
            new JSMgr.MethodCallBackInfo(AudioSource_SetScheduledEndTime__Double, "SetScheduledEndTime"),
            new JSMgr.MethodCallBackInfo(AudioSource_SetScheduledStartTime__Double, "SetScheduledStartTime"),
            new JSMgr.MethodCallBackInfo(AudioSource_Stop, "Stop"),
            new JSMgr.MethodCallBackInfo(AudioSource_PlayClipAtPoint__AudioClip__Vector3, "PlayClipAtPoint"),
            new JSMgr.MethodCallBackInfo(AudioSource_PlayClipAtPoint__AudioClip__Vector3__Single, "PlayClipAtPoint"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}