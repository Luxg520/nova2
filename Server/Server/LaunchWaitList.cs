using System;
using System.Collections;
using System.Collections.Generic;
using Swift;
using Nova;

namespace Server
{
    /// <summary>
    /// 用于搜集等待服务器启动时必要的模块初始化
    /// </summary>
    public class LaunchWaitList : Component
    {
        ServerLogger log = new ServerLogger(typeof(LaunchWaitList));

        public Action Add(string name)
        {
            bool b = false;
            Action a = () => { b = true; };
            Func<bool> c = () => { return b; };
            dict[name] = c;

            return a;
        }

        public event Action OnWaitListFinished = null;

        public void Wait()
        {
            (GetComponent("CoroutineManager") as CoroutineManager).Start(WaitImpl());
        }

        public IEnumerator WaitImpl()
        {
            while (dict.Count > 0)
            {
                foreach (string name in dict.Keys)
                {
                    Func<bool> c = dict[name];
                    if (c())
                    {
                        log.Info("  " + name + " [OK].");
                        dict.Remove(name);
                        break;
                    }
                }

                yield return null;
            }

            if (OnWaitListFinished != null)
                OnWaitListFinished();
        }

        Dictionary<string, Func<bool>> dict = new Dictionary<string, Func<bool>>();
    }
}
