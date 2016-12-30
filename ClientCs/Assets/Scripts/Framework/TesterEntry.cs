using UnityEngine;
using UnityEditor;
using System.Collections;

public class TesterEntry : MonoBehaviour {

    void Start()
    {
#if JS
        Instantiate(AssetDatabase.LoadMainAssetAtPath("Assets/Scripts/JSBinding/_JSEngine.prefab"));
        JSComponent.s_AddComponent(gameObject, "GameDriver");
#else
        gameObject.AddComponent<GameDriver>();
#endif
    }
}
