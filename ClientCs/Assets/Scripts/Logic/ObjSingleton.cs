using UnityEngine;
using System.Collections;

// 逻辑对象单例
public class ObjSingleton<T> where T : class, new()
{
    static T instance = null;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new T();
            }
            return instance;
        }
    }
}
