using System;
using System.Collections.Generic;
using System.Threading;
using Swift;
using Nova;

namespace Server
{
    public static class NovaServerConfigHelper
    {
        public static Dictionary<string, int> IntValues = new Dictionary<string, int>();
        public static Dictionary<string, string> StringValues = new Dictionary<string, string>();
        public static Dictionary<string, float> FloatValues = new Dictionary<string, float>();
    }

    
    /// <summary>
    /// ����������
    /// </summary>
    public class NovaServer : Core
    {
        ServerLogger log = new ServerLogger(typeof(NovaServer));

        // �������߼����������룩
        public int Interval = 50;

        public NovaServer()
        {
            // ����Ĭ�Ϲ������
            Add("CoroutineManager", new CoroutineManager());

            CsScriptShell<ScriptObject> css = new CsScriptShell<ScriptObject>();
            DynamicScriptProvider<ScriptObject> dsp = new DynamicScriptProvider<ScriptObject>();

            css.DSP = dsp;
            Add("CsScriptShell", css);

            // �����ȴ�ģ��
            LaunchWaitList lwl = new LaunchWaitList();
            Add("LaunchWaitList", lwl);
        }

        public void Start()
        {
            running = true;
            long t = Utils.Now;

            log.Info("server starting ...");
            Get<LaunchWaitList>().Wait();

            while (running)
            {
                long now = Utils.Now;
                int dt = (int)(now - t);

                try
                {
                    RunOneFrame(dt);
                }
                catch (Exception ex)
                {
                    log.Error("\r\n==========\r\n" + ex.Message + "\r\n==========\r\n" + ex.StackTrace + "\r\n==========\r\n");
                }

                t = now;

                // sleep according to interval
                int sleepTime = Interval > dt ? Interval - dt : 0;
                Thread.Sleep(sleepTime);
            }

            log.Info("server stopped.");
        }

        // ֹͣ������
        public void Stop()
        {
            Close();
            running = false;
        }

        #region ��������

        // �����б��
        bool running = false;

        #endregion
    }
}