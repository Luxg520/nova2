using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using Swift;

namespace Swift
{
    /// <summary>
    /// 数据容器，对外提供数据逻辑，给各个功能模块，内部完成存储功能。对于 DataContainer 来说，会假设所有数据项的 id
    /// 都在内存中，而数据内容可能被卸载
    /// </summary>
    public class DataContainer<T, IDType> : Component, IFrameDrived where T : DataItem<IDType>
    {
        // 构造器，需要给定持久化器
        public DataContainer(IAsyncPersistence<T, IDType> persistence)
        {
            p = persistence;
        }

        // 启动异步存储
        public void Start()
        {
            p.Start();
        }

        // 停止启动异步存储
        public override void Close()
        {
            ProcessAll();
            p.Stop();
        }

        // 手动清理所有可卸载的缓存内容
        public virtual void ClearAllCache()
        { 
            T[] arr = data.Values.ToArray();
            foreach (T v in arr)
            {
                if (!v.Status.Modified && !v.Status.NewAdd)
                    data.Remove(v.ID);
            }
        }

        // 新增数据
        public void AddNew(T it)
        {
            if (Exists(it.ID))
                throw new Exception(it.ID + " already exists in data container");

            data[it.ID] = it;
            it.Status.NewAdd = true;
            it.Status.Modified = false;
        }

        // 删除数据
        public void Delete(IDType id)
        {
            if (data.ContainsKey(id))
                data.Remove(id);

            if (p != null)
                p.Delete(id);
        }

        // 如果内存中有数据，就从内存中取，否则尝试加载一个，并放入容器
        public void Retrieve(IDType id, Action<T> cb)
        {
            T it = Get(id);
            if (it != null)
            {
                // 可能是正在等待删除的
                if (cb != null)
                    cb(it);
            }
            else
            {
                Load(id, (T d) =>
                {
                    if (d != null)
                        data[d.ID] = d;

                    if (cb != null)
                        cb(d);
                });
            }
        }

        // 如果内存中有数据，就从内存中取，否则尝试加载一个，并放入容器
        public void Retrieve(IEnumerable<IDType> ids, Action<T[]> cb)
        {
            List<IDType> idLst = new List<IDType>();
            idLst.AddRange(ids);

            if (idLst.Count == 0)
            {
                cb(new T[] { });
                return;
            }

            T[] dArr = new T[idLst.Count];
            int cnt = 0;
            for (int i = 0; i < dArr.Length; i++)
            {
                int n = i;
                Retrieve(idLst[n], (T d) =>
                {
                    dArr[n] = d;
                    cnt++;

                    if (cnt == dArr.Length)
                        cb(dArr);
                });
            }
        }

        // 如果内存中有数据，就从内存中取，否则尝试加载一个，并放入容器
        public void Retrieve(Action<T[]> cb, params IDType[] ids)
        {
            Retrieve(ids, cb);
        }

        // 载入磁盘上所有数据
        public void LoadAll(Action<T[]> arrcb, string whereClouse)
        {
            p.LoadAll((T[] itArr) =>
            {
                if (null == itArr)
                {
                    arrcb(null);
                    return;
                }
                for (int i = 0; i < itArr.Length; i++)
                {
                    IDType id = itArr[i].ID;
                    if (!data.ContainsKey(id))
                        data[id] = itArr[i];
                    else
                        itArr[i] = data[id];
                }
                if (arrcb != null)
                    arrcb(itArr);

            }, whereClouse);
        }

        // 载入磁盘上所有数据
        public void LoadAllID(Action<IDType[]> arrcb, string whereClouse)
        {
            p.LoadAllID((IDType[] itArr) =>
            {
                if (arrcb != null)
                    arrcb(itArr);
            }, whereClouse);
        }

        // 判断是否存在指定 id 的数据项
        public bool Exists(IDType id)
        {
            return data.ContainsKey(id);
        }

        // 自动保存间隔（毫秒，默认 30000，即 30 秒），0 表示永远不进行自动存储
        public int Interval
        {
            get { return interval; }
            set { interval = value; }
        }

        // 完成自动保存及推动回调等逻辑
        public void OnTimeElapsed(int te)
        {
            // 推动所有等待的回调操作
            p.ProcessPendingCallback();

            if (interval == 0)
                return;

            elapsed += te;
            if (elapsed >= interval)
            {
                while (elapsed >= interval)
                    elapsed -= interval;

                ProcessAll();
            }
        }

        // 获取内存中所有缓存的数据
        public virtual T[] GetAll()
        {
            return data.Values.ToArray();
        }

        // 从内存中获取指定 id 的数据
        public virtual T Get(IDType id)
        {
            if (id == null || !data.ContainsKey(id))
                return null;

            return data[id];
        }

        // 序列化器
        public IAsyncPersistence<T, IDType> Persistence
        {
            get { return p; }
        }

        #region 保护部分

        // 根据 ID 从磁盘载入指定数据项，并不放入容器
        protected virtual void Load(IDType id, Action<T> cb)
        {
            p.Load(id, (T it) =>
            {
                if (cb != null)
                    cb(it);
            });
        }

        // 处理所有等待的操作
        void ProcessAll()
        {
            // 尝试保存所有数据并刷新数据状态
            T[] arr = null;
            if (data.Count == 0)
                return;
            else
                arr = data.Values.ToArray();

            // 将需要修改的数据都扔给持久化器进行操作
            foreach (T it in arr)
            {
                if (it.Status.NewAdd)
                    p.AddNew(it);
                else if (it.Status.Modified)
                    p.Save(it);

                it.Status.NewAdd = false;
                it.Status.Modified = false;
            }
        }

        // 所有数据项
        Dictionary<IDType, T> data = new Dictionary<IDType, T>();

        // 持久化器
        IAsyncPersistence<T, IDType> p = null;

        // 自动保存间隔
        int interval = 30000;

        // 自动保存间隔累计时间
        int elapsed = 0;

        #endregion
    }
}
