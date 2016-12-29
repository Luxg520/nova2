using System;
using Swift;
using Nova;

namespace Server
{
    /// <summary>
    /// 时钟管理器
    /// </summary>
    public class TimeMgr : ITimeMgr
    {
        public static TimeMgr Inst = new TimeMgr();

        public MiscContainer MC = null;

        public DateTime DT2015 { get { return new DateTime(2015, 1, 1); } }

        bool isGM = false;

        int GMNow = 0;

        // 当前服务器时间
        public DateTime Now
        {
            get
            {
                if (isGM)
                    return DT2015.AddSeconds(GMNow);
                else 
                    return DateTime.Now;
            }
        }

        // 当前服务器时间的 ticks
        public ulong NowTicks
        {
            get
            {
                if (isGM)
                    return (ulong)DT2015.AddSeconds(GMNow).Ticks;
                else 
                    return (ulong)Now.Ticks;
            }
        }

        public ulong SecondsSince2015
        {
            get
            {
                if (isGM)
                    return (ulong)GMNow;
                else 
                    return (ulong) Now.Subtract(DT2015).TotalSeconds;
            }
        }

        // GM时间流逝
        public void GMTimeElapsed()
        {
            GMNow++;
        }

        // 设置GM时间
        public void SetGMTime(bool isGM, int timeSince2015)
        {
            this.isGM = isGM;
            GMNow = timeSince2015;
        }

        public bool IsToday(ulong secsSince2015, int onClock)
        {
            return GetDays(secsSince2015, onClock) == 0;
        }

        public int GetDays(ulong secsSince2015, int onClock)
        {
            DateTime dt = DT2015.AddSeconds(secsSince2015);
            int days = Utils.DaysBetweenTwoDateTime(dt, Now, onClock);
            return days;
        }

        public DateTime Secs2DateTime(ulong secsSince2015)
        {
            return DT2015.AddSeconds(secsSince2015);
        }

        // 获取首次开服时间（这个函数必须是在服务器数据初始化完成后才可使用）
        public DateTime GetOpenGSTime()
        {
            MiscData data = MC.GetByType(MiscDataType.OpenServerTime);
            ulong openGSTime = (ulong)data.GetObj();
            return Secs2DateTime(openGSTime);
        }
    }
}
