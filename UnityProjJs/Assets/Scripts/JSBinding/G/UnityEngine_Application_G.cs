
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using jsval = JSApi.jsval;
public class UnityEngine_Application_G
{
    ////////////////////// Application ///////////////////////////////////////
    // constructors
    static bool Application_Application(JSVCall vc, int argc)
    {
        int _this = JSApi.getObject((int)JSApi.GetType.Arg);
        JSApi.attachFinalizerObject(_this);
        --argc;
         
        int len = argc;
        if (len == 0)
        {
            JSMgr.addJSCSRel(_this, new UnityEngine.Application());
        }
        return true;
    }
    // fields
    // properties
    static void Application_absoluteURL(JSVCall vc)
    {
        var result = UnityEngine.Application.absoluteURL;
        JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    static void Application_backgroundLoadingPriority(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Application.backgroundLoadingPriority;
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
        }
        else
        {
            UnityEngine.ThreadPriority arg0 = (UnityEngine.ThreadPriority)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Application.backgroundLoadingPriority = arg0;
        }
    }
    static void Application_bundleIdentifier(JSVCall vc)
    {
        var result = UnityEngine.Application.bundleIdentifier;
        JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    static void Application_cloudProjectId(JSVCall vc)
    {
        var result = UnityEngine.Application.cloudProjectId;
        JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    static void Application_companyName(JSVCall vc)
    {
        var result = UnityEngine.Application.companyName;
        JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    static void Application_dataPath(JSVCall vc)
    {
        var result = UnityEngine.Application.dataPath;
        JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    static void Application_genuine(JSVCall vc)
    {
        var result = UnityEngine.Application.genuine;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Application_genuineCheckAvailable(JSVCall vc)
    {
        var result = UnityEngine.Application.genuineCheckAvailable;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Application_installMode(JSVCall vc)
    {
        var result = UnityEngine.Application.installMode;
        JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    static void Application_internetReachability(JSVCall vc)
    {
        var result = UnityEngine.Application.internetReachability;
        JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    static void Application_isConsolePlatform(JSVCall vc)
    {
        var result = UnityEngine.Application.isConsolePlatform;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Application_isEditor(JSVCall vc)
    {
        var result = UnityEngine.Application.isEditor;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Application_isMobilePlatform(JSVCall vc)
    {
        var result = UnityEngine.Application.isMobilePlatform;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Application_isPlaying(JSVCall vc)
    {
        var result = UnityEngine.Application.isPlaying;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Application_isShowingSplashScreen(JSVCall vc)
    {
        var result = UnityEngine.Application.isShowingSplashScreen;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Application_isWebPlayer(JSVCall vc)
    {
        var result = UnityEngine.Application.isWebPlayer;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Application_persistentDataPath(JSVCall vc)
    {
        var result = UnityEngine.Application.persistentDataPath;
        JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    static void Application_platform(JSVCall vc)
    {
        var result = UnityEngine.Application.platform;
        JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    static void Application_productName(JSVCall vc)
    {
        var result = UnityEngine.Application.productName;
        JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    static void Application_runInBackground(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Application.runInBackground;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
        }
        else
        {
            bool arg0 = JSApi.getBooleanS((int)JSApi.GetType.Arg);
            UnityEngine.Application.runInBackground = arg0;
        }
    }
    static void Application_sandboxType(JSVCall vc)
    {
        var result = UnityEngine.Application.sandboxType;
        JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    static void Application_srcValue(JSVCall vc)
    {
        var result = UnityEngine.Application.srcValue;
        JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    static void Application_streamedBytes(JSVCall vc)
    {
        var result = UnityEngine.Application.streamedBytes;
        JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
    }
    static void Application_streamingAssetsPath(JSVCall vc)
    {
        var result = UnityEngine.Application.streamingAssetsPath;
        JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    static void Application_systemLanguage(JSVCall vc)
    {
        var result = UnityEngine.Application.systemLanguage;
        JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    static void Application_targetFrameRate(JSVCall vc)
    {
        if (vc.bGet)
        {
            var result = UnityEngine.Application.targetFrameRate;
            JSApi.setInt32((int)JSApi.SetType.Rval, (int)(result));
        }
        else
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Application.targetFrameRate = arg0;
        }
    }
    static void Application_temporaryCachePath(JSVCall vc)
    {
        var result = UnityEngine.Application.temporaryCachePath;
        JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    static void Application_unityVersion(JSVCall vc)
    {
        var result = UnityEngine.Application.unityVersion;
        JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    static void Application_version(JSVCall vc)
    {
        var result = UnityEngine.Application.version;
        JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    static void Application_webSecurityEnabled(JSVCall vc)
    {
        var result = UnityEngine.Application.webSecurityEnabled;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(result));
    }
    static void Application_webSecurityHostUrl(JSVCall vc)
    {
        var result = UnityEngine.Application.webSecurityHostUrl;
        JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    // methods
    static bool Application_CancelQuit(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            UnityEngine.Application.CancelQuit();
        }
        return true;
    }
    static bool Application_CanStreamedLevelBeLoaded__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Application.CanStreamedLevelBeLoaded(arg0)));
        }
        return true;
    }
    static bool Application_CanStreamedLevelBeLoaded__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Application.CanStreamedLevelBeLoaded(arg0)));
        }
        return true;
    }
    static bool Application_CaptureScreenshot__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.Application.CaptureScreenshot(arg0);
        }
        return true;
    }
    static bool Application_CaptureScreenshot__String__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            int arg1 = JSApi.getInt32((int)JSApi.GetType.Arg);
            UnityEngine.Application.CaptureScreenshot(arg0, arg1);
        }
        return true;
    }
    static bool Application_ExternalCall__String__Object_Array(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            object[] arg1 = 
                JSDataExchangeMgr.GetJSArg<object[]>(() => 
                {
                    int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
                    int length = jsObjID == 0 ? 0 : JSApi.getArrayLength(jsObjID);
                    var ret = new object[length];
                    for (var i = 0; i < length; i++)
                    {
                        JSApi.getElement(jsObjID, i);
                        ret[i] = (object)JSMgr.datax.getWhatever((int)JSApi.GetType.SaveAndRemove);
                    }
                    return ret;
                })
            ;
            UnityEngine.Application.ExternalCall(arg0, arg1);
        }
        return true;
    }
    static bool Application_GetStackTraceLogType__LogType(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.LogType arg0 = (UnityEngine.LogType)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setEnum((int)JSApi.SetType.Rval, (int)UnityEngine.Application.GetStackTraceLogType(arg0));
        }
        return true;
    }
    static bool Application_GetStreamProgressForLevel__Int32(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            int arg0 = JSApi.getInt32((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Application.GetStreamProgressForLevel(arg0)));
        }
        return true;
    }
    static bool Application_GetStreamProgressForLevel__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            JSApi.setSingle((int)JSApi.SetType.Rval, (float)(UnityEngine.Application.GetStreamProgressForLevel(arg0)));
        }
        return true;
    }
    static bool Application_HasProLicense(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Application.HasProLicense()));
        }
        return true;
    }
    static bool Application_HasUserAuthorization__UserAuthorization(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.UserAuthorization arg0 = (UnityEngine.UserAuthorization)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Application.HasUserAuthorization(arg0)));
        }
        return true;
    }
    static bool Application_OpenURL__String(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            string arg0 = JSApi.getStringS((int)JSApi.GetType.Arg);
            UnityEngine.Application.OpenURL(arg0);
        }
        return true;
    }
    static bool Application_Quit(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 0)
        {
            UnityEngine.Application.Quit();
        }
        return true;
    }
    public static UnityEngine.Application.AdvertisingIdentifierCallback Application_RequestAdvertisingIdentifierAsync_GetDelegate_member13_arg0(CSRepresentedObject objFunction)
    {
        if (objFunction == null || objFunction.jsObjID == 0)
            return null;
         
        UnityEngine.Application.AdvertisingIdentifierCallback action = JSMgr.getJSFunCSDelegateRel<UnityEngine.Application.AdvertisingIdentifierCallback>(objFunction.jsObjID);
        if (action != null)
            return action;
         
        action = (advertisingId, trackingEnabled, errorMsg) => 
        {
            JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID, advertisingId, trackingEnabled, errorMsg);
        };
        JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
        return action;

    }
    static bool Application_RequestAdvertisingIdentifierAsync__AdvertisingIdentifierCallback(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.Application.AdvertisingIdentifierCallback arg0 = 
                JSDataExchangeMgr.GetJSArg<UnityEngine.Application.AdvertisingIdentifierCallback>(() => 
                {
                    if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
                    {
                        return Application_RequestAdvertisingIdentifierAsync_GetDelegate_member13_arg0(JSApi.getFunctionS((int)JSApi.GetType.Arg));
                    }
                    else
                    {
                        return (UnityEngine.Application.AdvertisingIdentifierCallback)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                    }
                }
                );
            ;
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (bool)(UnityEngine.Application.RequestAdvertisingIdentifierAsync(arg0)));
        }
        return true;
    }
    static bool Application_RequestUserAuthorization__UserAuthorization(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 1)
        {
            UnityEngine.UserAuthorization arg0 = (UnityEngine.UserAuthorization)JSApi.getEnum((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Application.RequestUserAuthorization(arg0));
        }
        return true;
    }
    static bool Application_SetStackTraceLogType__LogType__StackTraceLogType(JSVCall vc, int argc)
    {
        int len = argc;
        if (len == 2)
        {
            UnityEngine.LogType arg0 = (UnityEngine.LogType)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.StackTraceLogType arg1 = (UnityEngine.StackTraceLogType)JSApi.getEnum((int)JSApi.GetType.Arg);
            UnityEngine.Application.SetStackTraceLogType(arg0, arg1);
        }
        return true;
    }
     
    // register
    public static void __Register()
    {
        JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
        ci.type = typeof(UnityEngine.Application);
        ci.fields = new JSMgr.CSCallbackField[]
        {
        };
        ci.properties = new JSMgr.CSCallbackProperty[]
        {
            Application_absoluteURL,
            Application_backgroundLoadingPriority,
            Application_bundleIdentifier,
            Application_cloudProjectId,
            Application_companyName,
            Application_dataPath,
            Application_genuine,
            Application_genuineCheckAvailable,
            Application_installMode,
            Application_internetReachability,
            Application_isConsolePlatform,
            Application_isEditor,
            Application_isMobilePlatform,
            Application_isPlaying,
            Application_isShowingSplashScreen,
            Application_isWebPlayer,
            Application_persistentDataPath,
            Application_platform,
            Application_productName,
            Application_runInBackground,
            Application_sandboxType,
            Application_srcValue,
            Application_streamedBytes,
            Application_streamingAssetsPath,
            Application_systemLanguage,
            Application_targetFrameRate,
            Application_temporaryCachePath,
            Application_unityVersion,
            Application_version,
            Application_webSecurityEnabled,
            Application_webSecurityHostUrl,
        };
        ci.constructors = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Application_Application, ".ctor"),
        };
        ci.methods = new JSMgr.MethodCallBackInfo[]
        {
            new JSMgr.MethodCallBackInfo(Application_CancelQuit, "CancelQuit"),
            new JSMgr.MethodCallBackInfo(Application_CanStreamedLevelBeLoaded__Int32, "CanStreamedLevelBeLoaded"),
            new JSMgr.MethodCallBackInfo(Application_CanStreamedLevelBeLoaded__String, "CanStreamedLevelBeLoaded"),
            new JSMgr.MethodCallBackInfo(Application_CaptureScreenshot__String, "CaptureScreenshot"),
            new JSMgr.MethodCallBackInfo(Application_CaptureScreenshot__String__Int32, "CaptureScreenshot"),
            new JSMgr.MethodCallBackInfo(Application_ExternalCall__String__Object_Array, "ExternalCall"),
            new JSMgr.MethodCallBackInfo(Application_GetStackTraceLogType__LogType, "GetStackTraceLogType"),
            new JSMgr.MethodCallBackInfo(Application_GetStreamProgressForLevel__Int32, "GetStreamProgressForLevel"),
            new JSMgr.MethodCallBackInfo(Application_GetStreamProgressForLevel__String, "GetStreamProgressForLevel"),
            new JSMgr.MethodCallBackInfo(Application_HasProLicense, "HasProLicense"),
            new JSMgr.MethodCallBackInfo(Application_HasUserAuthorization__UserAuthorization, "HasUserAuthorization"),
            new JSMgr.MethodCallBackInfo(Application_OpenURL__String, "OpenURL"),
            new JSMgr.MethodCallBackInfo(Application_Quit, "Quit"),
            new JSMgr.MethodCallBackInfo(Application_RequestAdvertisingIdentifierAsync__AdvertisingIdentifierCallback, "RequestAdvertisingIdentifierAsync"),
            new JSMgr.MethodCallBackInfo(Application_RequestUserAuthorization__UserAuthorization, "RequestUserAuthorization"),
            new JSMgr.MethodCallBackInfo(Application_SetStackTraceLogType__LogType__StackTraceLogType, "SetStackTraceLogType"),
        };
        JSMgr.allCallbackInfo.Add(ci);
    }
}