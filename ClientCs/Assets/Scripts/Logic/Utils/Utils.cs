using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Swift;

namespace Nova
{
	// 扩展一些客户端用的方法
	public class Utils
	{
		// 系统内存，按 m 计算
		public static int SystemMemSize
		{
			get
			{
				return SystemInfo.systemMemorySize;
			}
		}

		// 系统显存，按 m 计算
		public static int SystemVMemSize
		{
			get
			{
				return SystemInfo.graphicsMemorySize;
			}
		}

		// 设备信息
		public static string DeviceID
		{
			get
			{
				return SystemInfo.deviceUniqueIdentifier;
			}
		}

		// 设备信息
		public static string DeviceInfo
		{
			get
			{
				return SystemInfo.deviceModel + "," + SystemInfo.graphicsDeviceName + "," + SystemInfo.operatingSystem + "," + SystemInfo.systemMemorySize + "," + SystemInfo.graphicsMemorySize + "," + SystemInfo.deviceUniqueIdentifier;
			}
		}

		public static bool SkipDrama // 跳过序章 及 正义的复仇动画
		{
			get
			{
#if UNITY_ANDROID
				return skipDrama || SystemMemSize < 1.5 * 1024 || SystemVMemSize < 200; // 1.5G 内存，200M 显存才播剧情动画
#else
				return skipDrama;
#endif
			}
			set
			{
				skipDrama = value;
			}
		} static bool skipDrama = false;

		// 跳过指引
		public static bool SkipGuide = false;

		// 挂接指定的两个 GameObject 并重置子对象的 transform
		public static void AddChild(Transform parent, GameObject child)
		{
			AddChild(parent, child.transform);
		}

		// 挂接指定的两个 GameObject 并重置子对象的 transform
		public static void AddChild(GameObject parent, GameObject child)
		{
			AddChild(parent.transform, child);
		}

		// 挂接指定的两个 Transform
		public static void AddChild(Transform parent, Transform child)
		{
			child.SetParent(parent);
			child.localPosition = Vector3.zero;
			child.localScale = Vector3.one;
			child.localRotation = Quaternion.identity;
		}
        // 添加一个新的 Prefab 到指定父类下
        public static GameObject AddChild_Prefab(Transform parent, GameObject prefab)
        {
            if (parent != null && prefab != null) 
            {
                GameObject go = GameObject.Instantiate(prefab) as GameObject;
                go.transform.SetParent(parent, false);
                AddChild(parent, go);
                return go;
            }
            return null;
        }

        public static void AddUIChild(Transform parent, GameObject child)
        {
            // http://docs.unity3d.com/Manual/HOWTO-UICreateFromScripting.html
            child.transform.SetParent(parent, false);
        }

		// 处理所有直接子节点
		public static void ProcessAllChildren(Transform p, Action<GameObject> d)
		{
			for (int i = 0; i < p.childCount; i++)
				d(p.GetChild(i).gameObject);
		}

		// 在指定集合中查找目标的位置索引
		public static int IndexOf<T>(IEnumerable<T> set, T obj) where T : class
		{
			int i = 0;
			foreach (T e in set)
			{
				if (e == obj)
					return i;
				else
					i++;
			}

			return -1;
		}

		// 获取指定 ui 空间的显示尺寸
		public static Rect GetUIRect(GameObject uiObj)
		{
			if (uiObj.GetComponent<Image>() != null)
				return uiObj.GetComponent<Image>().GetPixelAdjustedRect();
			else if (uiObj.GetComponent<RawImage>() != null)
				return uiObj.GetComponent<RawImage>().GetPixelAdjustedRect();
			else
				return new Rect(0, 0, 0, 0);
		}

		// 遍历指定物体及其下所有子节点，指定指定操作
		public static void TravelChildren(GameObject go, Action<GameObject> fun)
		{
			if (go == null || fun == null)
				return;

			List<GameObject> lst = new List<GameObject>();
			lst.Add(go);
			while (lst.Count > 0)
			{
				GameObject[] arr = lst.ToArray();
				lst.Clear ();
				foreach (GameObject obj in arr)
				{
					fun(obj);
					for (int i = 0; i < obj.transform.childCount; i++)
						lst.Add(obj.transform.GetChild(i).gameObject);
				}
			}
		}

		// 拷贝摄像机参数
		public static void CopyCameraParameters(Camera src, Camera dst)
		{
			Transform p = dst.transform.parent;
			Utils.AddChild(src.transform, dst.transform);
			dst.transform.parent = p;

			dst.fieldOfView = src.fieldOfView;
			dst.orthographic = src.orthographic;
			dst.nearClipPlane = src.nearClipPlane;
			dst.farClipPlane = src.farClipPlane;
			dst.aspect = src.aspect;
			dst.depth = src.depth;
		}

		// 遍历给定类表，依次执行给定操作
		public static void Travel<T>(IEnumerable<T> lst, Action<T> fun)
		{
			foreach (T e in lst)
				fun(e);
		}
	}
}
