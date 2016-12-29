using System;
using Swift;
using Nova;
using log4net;
using log4net.Config;

namespace Server
{
    /// <summary>
    /// 服务器日志
    /// </summary>
    public class ServerLogger : Swift.ILog
    {
        static bool inited = false;
        public static void Init(string configXmlFile)
        {
            XmlConfigurator.Configure(new System.IO.FileInfo(configXmlFile));
            inited = true;
        }

        public ServerLogger(Type t)
        {
            if (!inited)
                throw new Exception("should be inited first by ServerLogger.Init");

            log = LogManager.GetLogger("DefaultLogger");
            gmLog = LogManager.GetLogger("GMLogger");
        }

        public ServerLogger(string name)
        {
            if (!inited)
                throw new Exception("should be inited first by ServerLogger.Init");

            log = LogManager.GetLogger("DefaultLogger");
            gmLog = LogManager.GetLogger("GMLogger");
        }

        // gm 操作
        public void LogGM(string str)
        {
            gmLog.Info(str);
        }

        // 信息
        public void Info(string str)
        {
            log.Info(str);
        }

        // 错误
        public void Error(string str)
        {
            log.Error(str);
        }

        // 警告
        public void Warn(string str)
        {
            log.Warn(str);
        }

        // 调试
        public void Debug(string str)
        {
            log.Debug(str);
        }

        log4net.ILog log = null;
        log4net.ILog gmLog = null;
    }
}
