using System;
using System.Collections;
using System.Collections.Generic;
using Swift;
using Nova;

namespace Server
{
    public class PingManager : Component
    {
        public SessionContainer SC = null;

        public LoginManager LgMgr = null;

        // 在线检查时间间隔（秒）
        public ulong CheckInterval = 2;

        // 超时时间（秒）
        public ulong ExpiredTime = 10;

        // 在协程中做超时检查
        bool running = false;
        public IEnumerator CheckImpl()
        {
            running = true;
            while (running)
            {
                ulong checkPoint = TimeMgr.Inst.SecondsSince2015 - ExpiredTime;

                Session[] ss = SC.All;
                for (int i = 0; i < ss.Length && running; i++)
                {
                    Session s = ss[i];
                    if (s.LastPingTime < checkPoint)
                        LgMgr.KickUser(s, "time out");

                    yield return null;
                }

                yield return new TimeWaiter((int)(CheckInterval * 1000));
            }

            yield return null;
        }

        // 开启 ping 检测
        public void Start()
        {
            ((CoroutineManager)GetComponent("CoroutineManager")).Start(CheckImpl());
        }

        // 服务器关闭时，停止工作协程
        public override void Close()
        {
            running = false;
        }

        // 登记 ping 消息
        public void OnPing(User usr, LoginType type)
        {
            Session s = SC.GetByID(usr.ID);
            s.LastPingTime = TimeMgr.Inst.SecondsSince2015;
        }
    }
}
