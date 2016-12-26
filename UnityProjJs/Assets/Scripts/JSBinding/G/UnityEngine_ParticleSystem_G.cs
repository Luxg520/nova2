﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_ParticleSystem_G
{
    ////////////////////// ParticleSystem ///////////////////////////////////////
    // constructors
    static bool ParticleSystem_ParticleSystem(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.ParticleSystem());
        }
        return true;
    }
    // fields
    // properties
    static void ParticleSystem_duration(JSVCall vc)
    {
        UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
        var result = _this.duration;
        JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
    }
    static void ParticleSystem_emissionRate(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            var result = _this.emissionRate;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            _this.emissionRate = arg0;
        }
    }
    static void ParticleSystem_enableEmission(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            var result = _this.enableEmission;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            _this.enableEmission = arg0;
        }
    }
    static void ParticleSystem_gravityModifier(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            var result = _this.gravityModifier;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            _this.gravityModifier = arg0;
        }
    }
    static void ParticleSystem_isPaused(JSVCall vc)
    {
        UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
        var result = _this.isPaused;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void ParticleSystem_isPlaying(JSVCall vc)
    {
        UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
        var result = _this.isPlaying;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void ParticleSystem_isStopped(JSVCall vc)
    {
        UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
        var result = _this.isStopped;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void ParticleSystem_loop(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            var result = _this.loop;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            _this.loop = arg0;
        }
    }
    static void ParticleSystem_maxParticles(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            var result = _this.maxParticles;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            _this.maxParticles = arg0;
        }
    }
    static void ParticleSystem_particleCount(JSVCall vc)
    {
        UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
        var result = _this.particleCount;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void ParticleSystem_playbackSpeed(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            var result = _this.playbackSpeed;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            _this.playbackSpeed = arg0;
        }
    }
    static void ParticleSystem_playOnAwake(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            var result = _this.playOnAwake;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            _this.playOnAwake = arg0;
        }
    }
    static void ParticleSystem_randomSeed(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            var result = _this.randomSeed;
            JSApi.setUInt32((int)JSApi.SetType.Rval, (uint)(result));
        }
        else
        {
            uint arg0 = JSApi.getUInt32((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            _this.randomSeed = arg0;
        }
    }
    static void ParticleSystem_safeCollisionEventSize(JSVCall vc)
    {
        UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
        var result = _this.safeCollisionEventSize;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void ParticleSystem_simulationSpace(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            var result = _this.simulationSpace;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.ParticleSystemSimulationSpace arg0 = (UnityEngine.ParticleSystemSimulationSpace)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            _this.simulationSpace = arg0;
        }
    }
    static void ParticleSystem_startColor(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            var result = _this.startColor;
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
        }
        else
        {
            UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            _this.startColor = arg0;
        }
    }
    static void ParticleSystem_startDelay(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            var result = _this.startDelay;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            _this.startDelay = arg0;
        }
    }
    static void ParticleSystem_startLifetime(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            var result = _this.startLifetime;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            _this.startLifetime = arg0;
        }
    }
    static void ParticleSystem_startRotation(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            var result = _this.startRotation;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            _this.startRotation = arg0;
        }
    }
    static void ParticleSystem_startSize(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            var result = _this.startSize;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            _this.startSize = arg0;
        }
    }
    static void ParticleSystem_startSpeed(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            var result = _this.startSpeed;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            _this.startSpeed = arg0;
        }
    }
    static void ParticleSystem_time(JSVCall vc)
    {
        if (vc.bGet)
        {
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            var result = _this.time;
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(result));
        }
        else
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystem _this = (UnityEngine.ParticleSystem)vc.csObj;
            _this.time = arg0;
        }
    }
    // methods
    static bool ParticleSystem_Clear(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.ParticleSystem)vc.csObj).Clear();
        }
        return true;
    }
    static bool ParticleSystem_Clear__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            ((UnityEngine.ParticleSystem)vc.csObj).Clear(arg0);
        }
        return true;
    }
    static bool ParticleSystem_Emit__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.ParticleSystem)vc.csObj).Emit(arg0);
        }
        return true;
    }
    static bool ParticleSystem_Emit__Particle(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.ParticleSystem.Particle arg0 = (UnityEngine.ParticleSystem.Particle)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.ParticleSystem)vc.csObj).Emit(arg0);
        }
        return true;
    }
    static bool ParticleSystem_Emit__Vector3__Vector3__Single__Single__Color32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 5)
        {
            UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            float arg2 = JSApi.getSingle((int)JSApi.GetType.Arg);
            float arg3 = JSApi.getSingle((int)JSApi.GetType.Arg);
            UnityEngine.Color32 arg4 = (UnityEngine.Color32)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            ((UnityEngine.ParticleSystem)vc.csObj).Emit(arg0, arg1, arg2, arg3, arg4);
        }
        return true;
    }
    static bool ParticleSystem_GetCollisionEvents__GameObject__CollisionEvent_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.GameObject arg0 = (UnityEngine.GameObject)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            UnityEngine.ParticleSystem.CollisionEvent[] arg1 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.ParticleSystem.CollisionEvent[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.ParticleSystem.CollisionEvent[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.ParticleSystem.CollisionEvent)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.ParticleSystem)vc.csObj).GetCollisionEvents(arg0, arg1)));
        }
        return true;
    }
    static bool ParticleSystem_GetParticles__Particle_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.ParticleSystem.Particle[] arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.ParticleSystem.Particle[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.ParticleSystem.Particle[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.ParticleSystem.Particle)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(((UnityEngine.ParticleSystem)vc.csObj).GetParticles(arg0)));
        }
        return true;
    }
    static bool ParticleSystem_IsAlive(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.ParticleSystem)vc.csObj).IsAlive()));
        }
        return true;
    }
    static bool ParticleSystem_IsAlive__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(((UnityEngine.ParticleSystem)vc.csObj).IsAlive(arg0)));
        }
        return true;
    }
    static bool ParticleSystem_Pause(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.ParticleSystem)vc.csObj).Pause();
        }
        return true;
    }
    static bool ParticleSystem_Pause__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            ((UnityEngine.ParticleSystem)vc.csObj).Pause(arg0);
        }
        return true;
    }
    static bool ParticleSystem_Play(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.ParticleSystem)vc.csObj).Play();
        }
        return true;
    }
    static bool ParticleSystem_Play__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            ((UnityEngine.ParticleSystem)vc.csObj).Play(arg0);
        }
        return true;
    }
    static bool ParticleSystem_SetParticles__Particle_Array__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.ParticleSystem.Particle[] arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.ParticleSystem.Particle[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new UnityEngine.ParticleSystem.Particle[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (UnityEngine.ParticleSystem.Particle)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            ((UnityEngine.ParticleSystem)vc.csObj).SetParticles(arg0, arg1);
        }
        return true;
    }
    static bool ParticleSystem_Simulate__Single(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            ((UnityEngine.ParticleSystem)vc.csObj).Simulate(arg0);
        }
        return true;
    }
    static bool ParticleSystem_Simulate__Single__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            bool arg1 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            ((UnityEngine.ParticleSystem)vc.csObj).Simulate(arg0, arg1);
        }
        return true;
    }
    static bool ParticleSystem_Simulate__Single__Boolean__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 3)
        {
            float arg0 = JSApi.getSingle((int)JSApi.GetType.Arg);
            bool arg1 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            bool arg2 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            ((UnityEngine.ParticleSystem)vc.csObj).Simulate(arg0, arg1, arg2);
        }
        return true;
    }
    static bool ParticleSystem_Stop(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            ((UnityEngine.ParticleSystem)vc.csObj).Stop();
        }
        return true;
    }
    static bool ParticleSystem_Stop__Boolean(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            ((UnityEngine.ParticleSystem)vc.csObj).Stop(arg0);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.ParticleSystem);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            ParticleSystem_duration,
            ParticleSystem_emissionRate,
            ParticleSystem_enableEmission,
            ParticleSystem_gravityModifier,
            ParticleSystem_isPaused,
            ParticleSystem_isPlaying,
            ParticleSystem_isStopped,
            ParticleSystem_loop,
            ParticleSystem_maxParticles,
            ParticleSystem_particleCount,
            ParticleSystem_playbackSpeed,
            ParticleSystem_playOnAwake,
            ParticleSystem_randomSeed,
            ParticleSystem_safeCollisionEventSize,
            ParticleSystem_simulationSpace,
            ParticleSystem_startColor,
            ParticleSystem_startDelay,
            ParticleSystem_startLifetime,
            ParticleSystem_startRotation,
            ParticleSystem_startSize,
            ParticleSystem_startSpeed,
            ParticleSystem_time,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(ParticleSystem_ParticleSystem, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(ParticleSystem_Clear, "Clear"),
            new JSMgr.MethodCallBackInfo(ParticleSystem_Clear__Boolean, "Clear"),
            new JSMgr.MethodCallBackInfo(ParticleSystem_Emit__Int32, "Emit"),
            new JSMgr.MethodCallBackInfo(ParticleSystem_Emit__Particle, "Emit"),
            new JSMgr.MethodCallBackInfo(ParticleSystem_Emit__Vector3__Vector3__Single__Single__Color32, "Emit"),
            new JSMgr.MethodCallBackInfo(ParticleSystem_GetCollisionEvents__GameObject__CollisionEvent_Array, "GetCollisionEvents"),
            new JSMgr.MethodCallBackInfo(ParticleSystem_GetParticles__Particle_Array, "GetParticles"),
            new JSMgr.MethodCallBackInfo(ParticleSystem_IsAlive, "IsAlive"),
            new JSMgr.MethodCallBackInfo(ParticleSystem_IsAlive__Boolean, "IsAlive"),
            new JSMgr.MethodCallBackInfo(ParticleSystem_Pause, "Pause"),
            new JSMgr.MethodCallBackInfo(ParticleSystem_Pause__Boolean, "Pause"),
            new JSMgr.MethodCallBackInfo(ParticleSystem_Play, "Play"),
            new JSMgr.MethodCallBackInfo(ParticleSystem_Play__Boolean, "Play"),
            new JSMgr.MethodCallBackInfo(ParticleSystem_SetParticles__Particle_Array__Int32, "SetParticles"),
            new JSMgr.MethodCallBackInfo(ParticleSystem_Simulate__Single, "Simulate"),
            new JSMgr.MethodCallBackInfo(ParticleSystem_Simulate__Single__Boolean, "Simulate"),
            new JSMgr.MethodCallBackInfo(ParticleSystem_Simulate__Single__Boolean__Boolean, "Simulate"),
            new JSMgr.MethodCallBackInfo(ParticleSystem_Stop, "Stop"),
            new JSMgr.MethodCallBackInfo(ParticleSystem_Stop__Boolean, "Stop"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}