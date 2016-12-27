#region Namespaces
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
#endregion

/// <summary>
/// <para>Version: 2.0.45</para>	 
/// <para>Author: Bob Berkebile (http://pixelplacement.com)</para>
/// <para>Support: http://itween.pixelplacement.com</para>
/// </summary>
public class iTweenRoot : MonoBehaviour {
	static iTweenRoot mInstance;
	public static Dictionary<GameObject, List<iTween>> objectToiTween = new Dictionary<GameObject, List<iTween>>();
	static Dictionary<GameObject, List<iTween>> addObjectToiTween = new Dictionary<GameObject, List<iTween>>();
	static Dictionary<GameObject, List<iTween>> removeObjectToiTween = new Dictionary<GameObject, List<iTween>>();
	static bool isLocked = false;
	public static bool isValid = true;
	delegate void UpdateCB(iTween itween);
	void Awake()
	{
		// mInstance = new GameObject("iTweenRoot").AddComponent<iTweenRoot>();
		if (mInstance == null)
		{
			mInstance = this;
			GameObject.DontDestroyOnLoad(mInstance.gameObject);
		}
		else
			throw new Exception("there can be only on iTweenRoot instance");
		
		//    #if UNITY_EDITOR
		//        mInstance.gameObject.AddComponent<DestroyDontDestroy>();
		//    #endif
	}
	public static bool HasiTweens(GameObject obj)
	{
		if (!isValid || obj == null)
			return false;
		
		List<iTween> its;
		if (!objectToiTween.TryGetValue(obj, out its))
			return false;
		else
			return (its.Count > 0);
	}
	
	// 这个函数JS不能用
	public static List<iTween> GetiTweens(GameObject obj) {
		if (!isValid || obj == null)
			return new List<iTween>();
		
		List<iTween> its, ret;
		if (objectToiTween.TryGetValue(obj, out its))
			ret = new List<iTween>(its);
		else
			ret = new List<iTween>();
		if (isLocked)
		{
			if (addObjectToiTween.TryGetValue(obj, out its))
				ret.AddRange(its);
		}
		return ret;
	}
	public static iTween AddiTween(GameObject obj, iTween.iTweenDictionary args) {
		if (!isValid || obj == null)
			return null;
		
		iTween i = new iTween();
		//		if (!isLocked)
		//		{
		//			List<iTween> its;
		//			if (!objectToiTween.TryGetValue(obj, out its))
		//				objectToiTween.Add(obj, its = new List<iTween>());
		//			its.Add(i);
		//		}
		//		else
		//		{
		//			List<iTween> its;
		//			if (!addObjectToiTween.TryGetValue(obj, out its))
		//				addObjectToiTween.Add(obj, its = new List<iTween>());
		//			its.Add(i);
		//			if (removeObjectToiTween.TryGetValue(obj, out its))
		//				its.Remove(i);
		//		}
		i.gameObject = obj;
		i.PreStart(args);
		return i;
	}
	public static iTween AddiTweenAndAwake(GameObject obj) {
		if (!isValid || obj == null)
			return null;
		
		iTween i = new iTween();
		if (!isLocked)
		{
			List<iTween> its;
			if (!objectToiTween.TryGetValue(obj, out its))
				objectToiTween.Add(obj, its = new List<iTween>());
			its.Add(i);
		}
		else
		{
			List<iTween> its;
			if (!addObjectToiTween.TryGetValue(obj, out its))
				addObjectToiTween.Add(obj, its = new List<iTween>());
			its.Add(i);
			if (removeObjectToiTween.TryGetValue(obj, out its))
				its.Remove(i);
		}
		i.gameObject = obj;
		i.Awake();
		return i;
	}
	
	public static void RemoveiTweenInLock(GameObject obj, iTween i)
	{
		if (!isValid || obj == null)
			return;
		
		List<iTween> its;
		if (!removeObjectToiTween.TryGetValue(obj, out its))
			removeObjectToiTween.Add(obj, its = new List<iTween>());
		its.Add(i);
		if (addObjectToiTween.TryGetValue(obj, out its))
			its.Remove(i);
	}
	
	public static void RemoveiTween(GameObject obj, iTween i)
	{
		if (!isValid || obj == null)
			return;
		
		if (!isLocked)
		{
			List<iTween> its;
			if (objectToiTween.TryGetValue(obj, out its))
				its.Remove(i);
			i.gameObject = null;
		}
		else
		{
			List<iTween> its;
			if (!removeObjectToiTween.TryGetValue(obj, out its))
				removeObjectToiTween.Add(obj, its = new List<iTween>());
			its.Add(i);
			if (addObjectToiTween.TryGetValue(obj, out its))
				its.Remove(i);
		}
	}
	public new static UnityEngine.Coroutine StartCoroutine(IEnumerator i)
	{
		if (!isValid)
			return null;
		
		return (mInstance as MonoBehaviour).StartCoroutine(i);
	}
	public new static void StopCoroutine(IEnumerator i)
	{
		if (!isValid)
			return;
		
		if (mInstance != null)
			(mInstance as MonoBehaviour).StopCoroutine(i);
	}
	void Unlock()
	{
		isLocked = false;
//		foreach (var kv in addObjectToiTween)
//		{
//			var obj = kv.Key;
//			List<iTween> its;
//			if (!objectToiTween.TryGetValue(obj, out its))
//				objectToiTween.Add(obj, its = new List<iTween>());
//			its.AddRange(kv.Value);
//		}
        var ie = addObjectToiTween.GetEnumerator();
        try
        {
            while (ie.MoveNext())
            {
                var kv = ie.Current;
                var obj = kv.Key;
                List<iTween> its;
                if (!objectToiTween.TryGetValue(obj, out its))
                    objectToiTween.Add(obj, its = new List<iTween>());
                its.AddRange(kv.Value);
            }
        }
        finally
        {
            ie.Dispose();
        }


		addObjectToiTween.Clear();
//		foreach (var kv in removeObjectToiTween)
//		{
//			var obj = kv.Key;
//			List<iTween> its;
//			if (objectToiTween.TryGetValue(obj, out its))
//				foreach (var i in kv.Value)
//			{
//				its.Remove(i);
//				i.gameObject = null;
//			}
//		}

        ie = removeObjectToiTween.GetEnumerator();
        try
        {
            while (ie.MoveNext())
            {
                var kv = ie.Current;
                var obj = kv.Key;
                List<iTween> its;
                if (objectToiTween.TryGetValue(obj, out its))
                    for (var i = 0; i < kv.Value.Count; i++)
                {
                    its.Remove(kv.Value[i]);
                    kv.Value[i].gameObject = null;
                }
            }
        }
        finally
        {
            ie.Dispose();
        }

		removeObjectToiTween.Clear();
	}

	List<GameObject> removeObjs = new List<GameObject>();
	void UpdateiTween(UpdateCB cb)
	{
		if (!isValid)
			return;
		
		isLocked = true;
		removeObjs.Clear();

        var ie = objectToiTween.GetEnumerator();
        try
        {
            while (ie.MoveNext())
            {
                var kv = ie.Current;

                if (kv.Key != null)
                {
                    // foreach (var i in kv.Value)
                    for (int i = 0; i < kv.Value.Count; i++)
                    {
                        var v = kv.Value[i];
                        if (v.enabled && !removeObjectToiTween.ContainsKey(v.gameObject))
                            cb(v);
                    }
                }
                if (kv.Key == null || kv.Value.Count == 0)
                {
                    removeObjs.Add(kv.Key);
                    for (var i = 0; i < kv.Value.Count; i++)
                        kv.Value[i].Dispose();
                }
            }
        }
        finally
        {
            ie.Dispose();
        }

//		foreach (var kv in objectToiTween)
//		{
//			if (kv.Key != null)
//			{
//				// foreach (var i in kv.Value)
//				for (int i = 0; i < kv.Value.Count; i++)
//				{
//					var v = kv.Value[i];
//					if (v.enabled && !removeObjectToiTween.ContainsKey(v.gameObject))
//						cb(v);
//				}
//			}
//			if (kv.Key == null || kv.Value.Count == 0)
//			{
//				removeObjs.Add(kv.Key);
//				foreach (var i in kv.Value)
//					i.Dispose();
//			}
//		}

		// foreach(var o in removeObjs)
		for (int i = 0; i < removeObjs.Count; i++)
			objectToiTween.Remove(removeObjs[i]);

		Unlock();
	}
	
	void Update()
	{
		UpdateiTween(i => { i.Update(); });
	}
		
	void LateUpdate()
	{
		UpdateiTween(i => { i.LateUpdate(); });
	}
}