using UnityEngine;
//using System.IO;
using System.Collections;
/// <summary>
/// 资源路径配置
/// </summary>
public class ResourceConfig
{
    #region 编辑器资源路径（仅编辑器下使用）

    // 临时路径
    public static readonly string EditorTempPath = "Assets/TempData";
    // 编辑器下持久化目录
    public static readonly string EditorPersistentPath = EditorTempPath + "/PersistentAssets";
    // 资源路径
    public static readonly string AssetBundlePath = "Assets/AssetBundles";
    // UI资源路径
    public static readonly string UIPath = AssetBundlePath + "/Prefabs/UI";
    // 场景资源路径
    public static readonly string ScenePath = AssetBundlePath + "/Prefabs/Scenes";   
    // 配置表路径
    public static readonly string ConfigPath = AssetBundlePath + "/Config";
    // 图片路径
    public static readonly string TexturePath = AssetBundlePath + "/Textures";
    // Sprite路径
    public static readonly string SrpitePath = AssetBundlePath + "/Sprites";
    // Unity场景路径
    public static readonly string UnityScenePath = AssetBundlePath + "/Scenes";

    #endregion

    #region AssetBundle资源路径

    // AssetBundle 扩展名
    public static readonly string ABExtension = ".assetbundle";

    // 持久化目录
    private static string _persistentDataPath;
    public static string PersistentDataPath
    {
        get
        {
            if (string.IsNullOrEmpty(_persistentDataPath))
            {
                if ((Application.isEditor || Application.platform == RuntimePlatform.WindowsPlayer))
                    _persistentDataPath = EditorPersistentPath;
                else
                    _persistentDataPath = Application.persistentDataPath;
            }
            return _persistentDataPath;
        }
    }

    // AssetBundle 本地资源路径
    public static string LocalABPath
    {
        get
        {                
            return Application.streamingAssetsPath + "/AssetBundle";
        }
    }

    // AssetBundle 外部资源路径
    public static string ExternalABPath
    {
        get
        {
            return PersistentDataPath + "/AssetBundle";
        }
    }

    // AssetBundle Manifest 内部文件路径
    public static string LocalABManifest
    {
        get
        {
            return LocalABPath + "/AssetBundle";
        }
    }

    // AssetBundle Manifest 外部文件路径
    public static string ExternalABManifest
    {
        get
        {
            return ExternalABPath + "/AssetBundle";
        }
    }

    // AssetBundle Manifest 文件路径
//     public static string ABManifestPath
//     {
//         get
//         {            
//             if (File.Exists(ExternalABManifest))
//                 return ExternalABManifest;
//             return LocalABManifest;
//         }
//     }

    // 获取指定UI的AssetPath
    public static string GetUIPath(string uiName)
    {        
        return "Assets/AssetBundles/Prefabs/UI/" + uiName + ".prefab";
    }

    // 获取指定场景资源的AssetPath
    public static string GetScenePath(string sceneName)
    {        
        return ("Prefabs/Scenes/" + sceneName + ".prefab").ToLower();
    }

    // 获取指定图片的AssetPath
    public static string GetTexturePath(string assetPath)
    {
        return ("Textures/" + assetPath).ToLower();
    }

    // 获取Sprite的AssetPath
    public static string GetSpritePath(string assetPath)
    {
        return ("Sprites/" + assetPath).ToLower();
    }

    #endregion

    #region 更新相关

    // 资源更新地址
    public static string UpdateUrl
    {
        get
        {
            string url = "http://192.168.1.232/";
#if UNITY_IPHONE
            url =  url + "ios";
#elif UNITY_ANDROID
            url =  url + "android";
#else
            url = url + "win";
#endif
            return url;
        }
    }

    // 资源更新版本地址
    public static string UpdateResourceUrl
    {
        get 
        {
            return UpdateUrl + "/AssetBundle";
        }
    }

    // 临时下载路径
    public static string DownloadTempPath
    {
        get
        {
            return PersistentDataPath + "/Download";
        }
    }

    #endregion

}
