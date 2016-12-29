using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swift;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerLogger.Init(args[0]);

            NovaServer srv = new NovaServer();
            CsScriptShell<ScriptObject> css = srv.Get<CsScriptShell<ScriptObject>>();
            css.DSP.AddNamespace("Nova");
            css.DSP.AddNamespace("Server");
            css.DSP.AddAssembly(System.Reflection.Assembly.GetExecutingAssembly().Location);

            css.DSP.AddNamespace("MySql");
            css.DSP.AddNamespace("MySql.Data");
            css.DSP.AddNamespace("MySql.Data.MySqlClient");
            css.DSP.AddAssembly(System.Reflection.Assembly.GetAssembly(typeof(MySql.Data.MySqlClient.MySqlConnection)).Location);

            css.DSP.AddNamespace("System.Data");
            css.DSP.AddAssembly(System.Reflection.Assembly.GetAssembly(typeof(System.Data.IDbConnection)).Location);

            // 执行启动脚本
            for (int i = 1; i < args.Length; i++)
                css.RunScript(args[i], "init", srv);

            srv.Start();
        }
    }
}
