using System;
using System.Collections.Generic;
using System.Text;
using Nova;
using Swift;

namespace Server
{
    public class DataPersistence<T, IDType> : Component, IFrameDrived where T : DataItem<IDType>
    {
        // 持久化器
        IAsyncPersistence<T, IDType> p = null;

        // 构造器，需要给定持久化器
        public DataPersistence(IAsyncPersistence<T, IDType> persistence)
        {
            p = persistence;
        }

        public virtual void Start()
        {
            p.Start();
        }

        public override void Close()
        {
            p.Stop();
        }

        public virtual void OnTimeElapsed(int te)
        {
            p.ProcessPendingCallback();
        }

        // 加载数据
        public void Load(IDType id, Action<T> cb)
        {
            p.Load(id, (T it) =>
            {
                if (cb != null)
                    cb(it);
            });
        }

        // 新增数据
        public virtual void AddNew(T it)
        {
            p.AddNew(it);
        }

        // 删除数据
        public virtual void Delete(IDType id)
        {
            p.Delete(id);
        }

        // 保存数据
        public virtual void Save(T it)
        {
            p.Save(it);
        }

        // 载入磁盘上所有数据
        public virtual void LoadAll(Action<T[]> arrcb, string whereClouse)
        {
            p.LoadAll((T[] itArr) =>
            {
                if (null == itArr)
                {
                    arrcb(null);
                    return;
                }
                if (arrcb != null)
                    arrcb(itArr);
            }, whereClouse);
        }

    }
}
