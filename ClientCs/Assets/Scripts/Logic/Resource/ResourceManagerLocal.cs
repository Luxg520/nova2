using System;
using UnityEngine;
using System.Collections;

public class ResourceManagerLocal : ObjSingleton<ResourceManagerLocal>
{
//     static ResourceManagerLocal instance = null;
//     public static ResourceManagerLocal Instance
//     {
//         get
//         {
//             if (instance == null)
//                 instance = new ResourceManagerLocal();
//             return instance;
//         }
//     }

    // 同步加载资源
    public void Load(string path, Action<UnityEngine.Object> cb)
    {
#if UNITY_EDITOR
        UnityEngine.Object obj = EditorEnv.LoadMainAssetAtPath(path);
        if (cb != null)
            cb(obj);
#else
        if (cb != null)
            cb(null);
#endif
    }
}
