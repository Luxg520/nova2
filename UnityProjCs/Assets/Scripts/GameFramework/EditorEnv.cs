using UnityEngine;
using System.Collections;
using UnityEditor;

public class EditorEnv
{
    public static UnityEngine.Object LoadMainAssetAtPath(string path)
    {
        return AssetDatabase.LoadMainAssetAtPath(path);
    }
}
