using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swift;
using Nova;

namespace Server
{
    public class PeriodMgr : Component, IFrameDrived
    {
        // 一秒调一次
        public Action RunPerSecond = null;
        // 凌晨5点调
        public Action RunOn5OClock = null;
        // 凌晨0点调
        public Action RunOn0OClock = null;
        // 周日23:59:59调用
        public Action RunOnSunDayEnd = null;

        int ms1 = 0;
        int ms2 = 0;
        int ms3 = 0;
        int ms4 = 0;

        DateTime last5OClock;
        DateTime lastSunday;
        DateTime last0OClock;
        
        public void OnTimeElapsed(int te)
        {
            if (te < 0)
                te = 0;

            ms1 += te;
            if (ms1 >= 1000)
            {
                ms1 -= 1000;
                if (RunPerSecond != null)
                    RunPerSecond();

                TimeMgr.Inst.GMTimeElapsed();
            }

            ms2 += te;
            if (ms2 >= 800)
            {
                ms2 -= 800;

                DateTime dt = TimeMgr.Inst.Now;
                if ((dt.Year != last5OClock.Year ||
                    dt.Month != last5OClock.Month ||
                    dt.Day != last5OClock.Day) &&
                    dt.Hour == 5 &&
                    dt.Minute == 0 &&
                    dt.Second == 0)
                {
                    if (RunOn5OClock != null)
                        RunOn5OClock();
                    last5OClock = dt;
                    Console.WriteLine(dt);
                }
            }

            ms3 += te;
            if (ms3 >= 800)
            {
                ms3 -= 800;

                DateTime dt = TimeMgr.Inst.Now;
                if ((dt.Year != lastSunday.Year ||
                    dt.Month != lastSunday.Month ||
                    dt.Day != lastSunday.Day) &&
                    dt.DayOfWeek == System.DayOfWeek.Monday &&
                    dt.Hour == 0 &&
                    dt.Minute == 0 &&
                    dt.Second == 0)
                {
                    if (RunOnSunDayEnd != null)
                        RunOnSunDayEnd();
                    lastSunday = dt;
                    Console.WriteLine(dt);
                }
            }

            ms4 += te;
            if (ms4 >= 800)
            {
                ms4 -= 800;

                DateTime dt = TimeMgr.Inst.Now;
                if ((dt.Year != last0OClock.Year ||
                    dt.Month != last0OClock.Month ||
                    dt.Day != last0OClock.Day) &&
                    dt.Hour == 0 &&
                    dt.Minute == 0 &&
                    dt.Second == 0)
                {
                    if (RunOn0OClock != null)
                        RunOn0OClock();
                    last0OClock = dt;
                    Console.WriteLine(dt);
                }
            }
        }
    }
}
