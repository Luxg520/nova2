using System;
using System.Collections.Generic;
using Swift;

namespace Server
{
    // 杂项容器（用于存储一些需要在服务器上记录的数据）
    public class MiscContainer : DataContainer<MiscData, int>
    {
        public MiscContainer(IAsyncPersistence<MiscData, int> p)
            : base(p) { }

        public void GetByType(MiscDataType type, Action<MiscData> cb)
        {
            Retrieve((int)type, (data) =>
            {
                if (cb != null)
                    cb(data);
            });
        }
        
        public MiscData GetByType(MiscDataType type)
        {
            return Get((int)type);
        }
    }
}
