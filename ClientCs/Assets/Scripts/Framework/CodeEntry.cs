using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// CodeEntry是框架代码
public class CodeEntry : MonoBehaviour
{
    void Start()
    {
        // 这个函数是一个演示，他是整个应用程序的入口
        // 逻辑代码不能直接在Inspector中挂上去，那么总得有一个入口点，就是这里
        // 
        //

        GameObject go = gameObject;
#if JS
        Instantiate(AssetDatabase.LoadMainAssetAtPath("Assets/Scripts/JSBinding/_JSEngine.prefab"));
        JSComponent.s_AddComponent(go, "GameDriver");
#else
        go.AddComponent<GameDriver>();
#endif
    }
}
