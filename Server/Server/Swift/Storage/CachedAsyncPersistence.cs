/*
 * creator(s): chenm
 * reviser(s): chenm
 */

using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading;
using Swift;

namespace Swift
{
    /// <summary>
    /// 带缓存的异步持久化器
    /// </summary>
    public abstract class CachedAsyncPersistence<T, IDType, BT> : IAsyncPersistence<T, IDType>
        where T : DataItem<IDType>
        where BT : class
    {
        #region 内部定义辅助类型

        /// <summary>
        /// 操作类型
        /// </summary>
        public enum OperationType
        {
            Add,
            Update,
            Delete,
            Load,
            LoadAll,
            LoadAllID,
        }

        /// <summary>
        /// 操作类型与操作数据的封装
        /// </summary>
        public class Operation
        {
            public OperationType op;
            public IDType id;
            public T d;
            public BT buff;
            public BT[] buffArr;
            public IDType[] idArr;
            public Action<T> cb;
            public Action<T[]> arrcb;
            public Action<IDType[]> arrcb_id;
            public volatile bool completed;
            public string cd = null;
            public int tryCount; // 重试次数

            public Operation(OperationType opType, IDType dataID, T data, BT buffer, BT[] bufferArr, Action<T> callback, Action<T[]> arrayCallback, Action<IDType[]> arrayCallback_id, string whereClause)
            {
                op = opType;
                id = dataID;
                d = data;
                buff = buffer;
                buffArr = bufferArr;
                cb = callback;
                arrcb = arrayCallback;
                arrcb_id = arrayCallback_id;
                completed = false;
                cd = whereClause;
                tryCount = 0;
            }
        }

        #endregion

        // 构造器，需指明数据映射对象
        public CachedAsyncPersistence(Func<T, BT> data2BuffHandler, Func<BT, T> buff2DataHandler)
        {
            hd2b = data2BuffHandler;
            hb2d = buff2DataHandler;
        }

        // 保存新增的数据
        public void AddNew(T it)
        {
            ops.Enqueue(new Operation(OperationType.Add, it.ID, it, hd2b(it), null, null, null, null, null));
        }

        // 保存数据
        public void Save(T it)
        {
            ops.Enqueue(new Operation(OperationType.Update, it.ID, it, hd2b(it), null, null, null, null, null));
        }

        // 载入指定 id 对应的数据项
        public void Load(IDType id, Action<T> cb)
        {
            ops.Enqueue(new Operation(OperationType.Load, id, null, null, null, cb, null, null, null));
        }

        // 载入磁盘上所有数据
        public void LoadAll(Action<T[]> arrcb, string whereClause)
        {
            ops.Enqueue(new Operation(OperationType.LoadAll, default(IDType), null, null, null, null, arrcb, null, whereClause));
        }

        // 载入磁盘上所有数据
        public void LoadAllID(Action<IDType[]> arrcb_id, string whereClause)
        {
            ops.Enqueue(new Operation(OperationType.LoadAllID, default(IDType), null, null, null, null, null, arrcb_id, whereClause));
        }

        // 删除指定 id 对应数据
        public void Delete(IDType id)
        {
            ops.Enqueue(new Operation(OperationType.Delete, id, null, null, null, null, null, null, null));
        }

        #region 这部分功能一般是各种工具在用，游戏逻辑不应该使用

        // 同步载入指定 id 对应的数据项
        public T LoadSyn(IDType id)
        {
            return hb2d(LoadImpl(id));
        }

        // 同步载入指定 id 对应的数据项
        public T[] LoadAllSyn(string whereClause)
        {
            List<T> lst = new List<T>();
            BT[] buffArr = LoadAllImpl(whereClause);
            foreach (BT buff in buffArr)
                lst.Add(hb2d(buff));

            return lst.ToArray();
        }

        #endregion

        // 处理所有等待的回调
        public virtual void ProcessPendingCallback()
        {
            if (opsCompleted.Count == 0)
                return;

            Operation op = null;
            while (opsCompleted.TryDequeue(out op))
            {
                if (!op.completed)
                    throw new Exception("op is not completed yet");

                if (op.cb != null)
                    op.cb(hb2d(op.buff));

                if (op.arrcb != null)
                {
                    T[] itArr = null;
                    if (op.buffArr != null)
                    {
                        itArr = new T[op.buffArr.Length];
                        for (int i = 0; i < op.buffArr.Length; i++)
                            itArr[i] = hb2d(op.buffArr[i]);
                    }

                    op.arrcb(itArr);
                }

                if (op.arrcb_id != null)
                    op.arrcb_id(op.idArr);
            }
        }

        // 启动异步存储
        public virtual void Start()
        {
            if (t == null)
                t = new Thread(WorkThread);

            running = true;
            t.Start();
        }

        // 停止启动异步存储
        public virtual void Stop()
        {
            running = false;

            ProcessPendingCallback();
            if (t != null)
                t.Join();
        }

        //// 移除最近的一个数据库操作
        //public virtual object RemoveCurrentOp()
        //{
        //    Operation op = null;
        //    ops.TryDequeue(out op);
        //    return op;
        //}

        #region 需要继承实现的部分

        // 将缓冲同步落地保存
        protected abstract void AddImpl(IDType id, T d, BT buff);

        // 将缓冲同步落地保存
        protected abstract void UpdateImpl(IDType id, T d, BT buff);

        // 同步删除指定 id 的数据
        protected abstract void DeleteImpl(IDType id);

        // 同步加载指定 id 的数据
        protected abstract BT LoadImpl(IDType id);

        // 同步加载所有数据
        protected abstract BT[] LoadAllImpl(string whereClause);

        // 同步加载所有数据的ID
        protected abstract IDType[] LoadAllIDImpl(string whereClause);

        #endregion

        #region 保护部分

        // 数据映射工具
        public Func<T, BT> hd2b = null;
        public Func<BT, T> hb2d = null;

        // 待执行的操作
        public ConcurrentQueue<Operation> ops = new ConcurrentQueue<Operation>();
        public ConcurrentQueue<Operation> opsCompleted = new ConcurrentQueue<Operation>();

        // 存储线程
        public Thread t = null;

        // 是否在工作中
        protected volatile bool running = false;

        public int OperationQueueLength
        {
            get
            {
                return ops.Count;
            }
        }

        public bool Prepared()
        {
            return ops.Count != 0;
        }

        public bool WorkOneStep()
        {
            return Prepared() ? ProcessAll() : false;
        }

        // 工作线程
        protected virtual void WorkThread()
        {
            while (running)
            {
                try
                {
                    if (!WorkOneStep())
                        Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("CachedAsyncPersistence thread exception: " + ex.Message);
                }
            }

            try
            {
                // 退出之前要处理完所有等待中的操作
                ProcessAll();
            }
            catch(Exception ex)
            {
                Console.WriteLine("CachedAsyncPersistence thread exception: " + ex.Message);
            }
        }

        // 处理所有等待中的操作
        public bool ProcessAll()
        {
            bool nothingProcessed = true;
            Operation op = null;
            while (ops.TryPeek(out op))
            {
                if (op.completed)
                    throw new Exception("op is already completed");
                else if (op.tryCount++ >= 10) // 最多重试 10 次，不行就扔了
                {
                    ops.TryDequeue(out op);
                    throw new Exception("op can not be completed");
                }

                switch (op.op)
                {
                    case OperationType.Add:
                        AddImpl(op.id, op.d, op.buff);
                        break;
                    case OperationType.Update:
                        UpdateImpl(op.id, op.d, op.buff);
                        break;
                    case OperationType.Delete:
                        DeleteImpl(op.id);
                        break;
                    case OperationType.Load:
                        op.buff = LoadImpl(op.id);
                        break;
                    case OperationType.LoadAll:
                        op.buffArr = LoadAllImpl(op.cd);
                        break;
                    case OperationType.LoadAllID:
                        op.idArr = LoadAllIDImpl(op.cd);
                        break;
                }

                op.completed = true;
                nothingProcessed = false;
                opsCompleted.Enqueue(op);
                ops.TryDequeue(out op);
            }

            return !nothingProcessed;
        }

        #endregion
    }
}
