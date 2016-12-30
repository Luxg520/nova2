using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace jsb
{
    public class XXX<T>
    {

    }
}

// CodeEntry是框架代码
public class CodeEntry : MonoBehaviour
{
    void Start()
    {
        // 这个函数是一个演示，他是整个应用程序的入口
        // 逻辑代码不能直接在Inspector中挂上去，那么总得有一个入口点，就是这里
        // 
        //

        GameObject prefab = (GameObject)AssetDatabase.LoadMainAssetAtPath("Assets/AssetBundles/Prefabs/Root.prefab");
        GameObject go = (GameObject)Instantiate(prefab);
        DontDestroyOnLoad(go);

        string n = go.name;
        if (n.EndsWith("(Clone)"))
            go.name = n.Substring(0, n.Length - 7);
#if JS
        Instantiate(AssetDatabase.LoadMainAssetAtPath("Assets/Scripts/JSBinding/_JSEngine.prefab"));
        JSComponent.s_AddComponent(go, "GameDriver");
#else
        go.AddComponent<GameDriver>();
#endif

        Destroy(gameObject);
    }
}
