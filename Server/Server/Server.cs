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
    /// 服务器对象
    /// </summary>
    public class NovaServer : Core
    {
        ServerLogger log = new ServerLogger(typeof(NovaServer));

        // 服务器逻辑真间隔（毫秒）
        public int Interval = 50;

        public NovaServer()
        {
            // 加入默认功能组件
            Add("CoroutineManager", new CoroutineManager());

            CsScriptShell<ScriptObject> css = new CsScriptShell<ScriptObject>();
            DynamicScriptProvider<ScriptObject> dsp = new DynamicScriptProvider<ScriptObject>();

            css.DSP = dsp;
            Add("CsScriptShell", css);

            // 启动等待模块
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

        // 停止服务器
        public void Stop()
        {
            Close();
            running = false;
        }

        #region 保护部分

        // 运行中标记
        bool running = false;

        #endregion
    }
}