using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Swift
{
    /// <summary>
    /// 核心类
    /// </summary>
    public class Core
    {
        // 构造器，添加默认组件
        public Core()
        {
        }

        // 添加组件对象
        public void Add(string name, Component c)
        {
            cc.Add(name, c);
        }

        // 添加组件对象
        public void Add(Component c)
        {
            cc.Add(c);
        }

        // 根据类型获取组件对象
        public T Get<T>() where T : class
        {
            return cc.Get<T>();
        }

        // 根据类型获取组件对象集合
        public T[] Gets<T>() where T:class
        {
            Component[] arr = cc.All;
            List<T> lst2 = new List<T>();
            for (int i = 0; i < arr.Length; i++)
            {
                Component c = arr[i];
                if (c is T)
                    lst2.Add(c as T);
            }
            return lst2.ToArray();
        }

        // 获取给定名称的组件
        public T GetByName<T>(string name) where T : class
        {
            Component c = cc.GetByName(name);
            if (c is T)
                return c as T;

            return null;
        }

        // 根据名称获取组件对象
        public Component GetByName(string name)
        {
            return cc.GetByName(name);
        }

        // 移除指定组件
        public void Remove(string name)
        {
            Component[] arr = cc.All;
            for (int i = 0; i < arr.Length; i++)
            {
                Component c = arr[i];
                if (c.Name == name)
                {
                    cc.Remove(name);
                    return;
                }
            }
        }

        // 运行一帧逻辑
        public virtual void RunOneFrame(int timeElapsed)
        {
//             PerformanceCounter counter = Get<PerformanceCounter>();
//             bool counterEnabled = counter != null;
// 
//             if (counterEnabled)
//             {
//                 counter.Clear();
//                 counter.StartTag("FrameTotal");
//             }

            Component[] arr = cc.All;
            for (int i = 0; i < arr.Length; i++)
            {
                Component c = arr[i];
//                 if (counterEnabled)
//                     counter.StartTag(c.Name);

                if (c is IFrameDrived)
                    (c as IFrameDrived).OnTimeElapsed(timeElapsed);

//                 if (counterEnabled)
//                     counter.EndTag(c.Name);
            }

//             if (counterEnabled)
//                 counter.EndTag("FrameTotal");
        }

        // 停止所有组件功能
        public virtual void Close()
        {
            Component[] arr = cc.All;
            for (int i = 0; i < arr.Length; i++)
                arr[i].Close();
        }

        public Component[] All
        {
            get
            {
                return cc.All;
            }
        }

        #region 保护部分

        // 组件容器
        protected ComponentContainer cc = new ComponentContainer();

        #endregion
    }
}
