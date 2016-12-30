using UnityEngine;
using System;
using System.Collections.Generic;

/// <summary>
/// 用于帮助序列化 MonoBehaviour 和 GameObject 的关系
/// </summary>
public class DictBehaviour : MonoBehaviour
{
    public List<NamedGo> Gos;
    public List<string> BNames;

    bool inited = false;
    Dictionary<string, GameObject> gos = new Dictionary<string, GameObject>();

    void Awake()
    {
        MakeSureInited();
    }

    void MakeSureInited()
    {
        if (!inited)
        {
            // 将 GameObject 列表转换成 kv 表
            foreach (var go in Gos)
            {
                var name = go.name;
                if (name == null || name.Trim() == "" || go == null || go.go == null)
                    continue;

                if (gos.ContainsKey(name))
                    throw new Exception("Named GameObject conflict: " + name);

                gos[name] = go.go;
            }

            foreach (var bn in BNames)
            {
#if JS
                JSComponent.s_AddComponent(gameObject, bn);
#else
                gameObject.AddComponent(Swift.DynamicIOS.GetTypeByName(bn));
#endif
            }

            inited = true;
        }
    }

    public GameObject Get(string name)
    {
        return gos[name];
    }
}

[Serializable]
public class NamedGo
{
    public string name;
    public GameObject go;
}

// 方便使用 DictBehaviour
public static class MonoBehavioursExt
{
    public static GameObject Get(this MonoBehaviour b, string name)
    {
        var db = b.GetComponent<DictBehaviour>();
        if (db == null)
            throw new Exception("Need DictBehaviour to use this method");

        return db.Get(name);
    }

    public static T Get<T>(this MonoBehaviour b, string name) where T: MonoBehaviour
    {
        return b.Get(name).GetComponent<T>();
    }
}
