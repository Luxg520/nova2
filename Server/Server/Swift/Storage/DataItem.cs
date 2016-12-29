using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swift;

namespace Swift
{
    /// <summary>
    /// 数据项状态
    /// </summary>
    public class PersistenceStatus
    {
        public bool NewAdd = false;
        public bool Modified = false;
        public int Version = 0;
    }

    /// <summary>
    /// 数据项，放入数据容器进行管理
    /// </summary>
    public abstract class DataItem<IDType>
    {
        // 构造器
        public DataItem(IDType dataID)
        {
            id = dataID;
        }

        // 数据 id
        // 无参构造和 ID set 访问器只应该出现在子类的序列化/反序列化过程中
        public DataItem() {}
        public virtual IDType ID
        {
            get
            {
                return id;
            }
            protected set
            {
                id = value;
            }
        } IDType id = default(IDType);

        // 通知数据更新
        public void Update()
        {
            Status.Modified = true;
        }

        // 数据持久化状态
        public PersistenceStatus Status = new PersistenceStatus();
    }
}
