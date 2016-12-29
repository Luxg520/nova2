using System;
using Swift;

namespace Nova
{
    /// <summary>
    /// 时间管理器接口
    /// </summary>
    public interface ITimeMgr
    {
        // 当前服务器时间
        DateTime Now { get; }

        // 当前服务器时间的 ticks
        ulong NowTicks { get; }

        // 从2015年1月1号起所经过的秒数
        ulong SecondsSince2015 { get; }

        DateTime DT2015 { get; }

        // secsSince2015 表达的时间是不是今天
        bool IsToday(ulong secsSince2015, int onClock);

        // secsSince2015 表达的时间到现在，经过了几天
        int GetDays(ulong secsSince2015, int onClock);

        DateTime Secs2DateTime(ulong secsSince2015);
    }
}
