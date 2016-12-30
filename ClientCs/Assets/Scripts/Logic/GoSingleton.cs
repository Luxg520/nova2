using UnityEngine;
using System.Collections;

// 永久GameObject单例
// 这里假设：
// 1. 必须由代码创建对象，不能手动创建
// 2. 创建后不会被删除
//
//
// 把这个类定义打开，Bridge 生成的JS代码有问题，基类定义有的出现在其子类后面了
// 论坛上问了问题：http://forums.bridge.net/forum/community/help/3250-type-order-in-created-js-file-is-wrong
//
//public class GoSington<T> : MonoBehaviour where T : GoSington<T>
//{
//    static T instance = null;
//    public static T Instance
//    {
//        get
//        {
//            if (instance == null)
//            {
//                GameObject go = new GameObject("_" + typeof(T).Name);
//                instance = go.AddComponent<T>();
//                DontDestroyOnLoad(go);
//            }
//            return instance;
//        }
//    }
//}
