using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using Swift;
using Nova;

namespace Server
{
    /// <summary>
    /// 控制台对象，监听控制台输入
    /// </summary>
    public class NovaConsole : Component, IFrameDrived
    {
        // 服务器对象
        public Core ServerCore = null;
        public UserContainer UC = null;
        public SessionContainer SC = null;

        ServerLogger log = new ServerLogger(typeof(NovaConsole));

        public void OnTimeElapsed(int te)
        {
            if (func.Count > 0)
            {
                try
                {
                    object r = func[0]();
                    log.Info(r == null ? "[NULL]" : r.ToString());
                }
                catch (Exception ex)
                {
                    log.Error(ex.Message);
                }
                finally
                {
                    func.RemoveAt(0);
                }
            }
        }

        public Action CloseServerFunc = null;
        
        public void Mount(string com)
        {
            Component c = null;
            if (!unmountedComs.TryGetValue(com, out c))
                log.Error(com + " has not been unmounted yet");
            else
            {
                AddComponent(com, c);
                unmountedComs.Remove(com);
                log.Info("Mount " + com + " ok");
            }
        }

        public void Unmount(string com)
        {
            if (unmountedComs.ContainsKey(com))
                log.Error(com + " has already been unmounted");
            else
            {
                Component c = RemoveComponent(com);
                if (c == null)
                    log.Error("can not find component which named: " + com);
                else
                {
                    unmountedComs[com] = c;
                    log.Info("Unmount " + com + " ok");
                }
            }
        }

        public void ProcessInputCommmand(string cmd)
        {
            if (string.IsNullOrEmpty(cmd))
                return;

            log.Info("input command: " + cmd);
            switch (cmd)
            {
                case "close":
                    func.Add(new Func<object>(() => { CloseServerFunc(); return null; }));
                    break;
                case "gc":
                    func.Add(new Func<object>(() => { GC.Collect(2, GCCollectionMode.Forced); return "ok"; }));
                    break;
                case "stat mysql":
                    func.Add(new Func<object>(() => {
                        int totalCount = 0;
                        int abandonCount = 0;
                        Dictionary<string, int> dict = MySqlConnectionPool.Instance.Count(out totalCount, out abandonCount);

                        string r = "\r\ntotal=" + totalCount + "\r\nabandon=" + abandonCount + "\r\n";
                        foreach (string k in dict.Keys)
                            r += "[" + dict[k] + "]:" + k + "\r\n";

                        r += MySqlPersistenceRegister.Instance.Print();
                        return r;
                    }));
                    break;
                case "stat uc":
                    func.Add(new Func<object>(() => {
                        int allCnt = 0;
                        int newCnt = 0;
                        int updateCnt = 0;
                        if (UC != null)
                        {
                            User[] usrArr = UC.GetAll();
                            foreach (User usr in usrArr)
                            {
                                if (usr.Status.NewAdd)
                                    newCnt++;
                                else if (usr.Status.Modified)
                                    updateCnt++;

                                allCnt++;
                            }
                        }

                         return "all=" + allCnt + ", new=" + newCnt + ", updated=" + updateCnt;
                    }));
                    break;
                case "stat online":
                    func.Add(new Func<object>(() => { return SC == null ? "null" : "sc count=" + SC.Count.ToString(); }));
                    break;
                default:
                    if (cmd.StartsWith("dump_user"))
                    {
                        string[] arr = cmd.Split(' ');
                        if (arr.Length != 3)
                        {
                            Console.WriteLine("Usage: dump_user id suffix");
                            return;
                        }
                        string userId = arr[1];
                        func.Add(new Func<object>(() =>
                        {
                            User user = UC.Get(userId);
                            if (user == null || user.Info == null)
                                return "s == null || s.User == null || s.User.Info == null";

                            string suffix = arr[2];

                            WriteBuffer wb = new WriteBuffer();
                            user.Info.Serialize(wb);
                            Directory.CreateDirectory("dump_user");
                            File.WriteAllBytes("dump_user\\" + userId + "_" + suffix + ".dat", wb.Data);
                            return "ok";
                        }));
                    }
                    else if (cmd.StartsWith("unmount com "))
                    {
                        string com = cmd.Substring("unmount com ".Length);
                        func.Add(new Func<object>(() => { Unmount(com); return null; }));
                    }
                    else if (cmd.StartsWith("mount com "))
                    {
                        string com = cmd.Substring("mount com ".Length);
                        func.Add(new Func<object>(() => { Mount(com); return null; }));
                    }
                    else if (cmd.StartsWith("run "))
                    {
                        string f = cmd.Substring("run ".Length);
                        func.Add(new Func<object>(() =>
                        {
                            try
                            {
                                CsScriptShell<ScriptObject> css = GetComponent("CsScriptShell") as CsScriptShell<ScriptObject>;
                                css.RecompileFromFile(f);
                                object r = css.RunScript(f, "fun", ServerCore);
                                return r == null ? "[NULL]" : r.ToString();
                            }
                            catch (Exception ex)
                            {
                                return "NovaConsole Exception: \r\n" + ex.Message;
                            }
                        }));
                    }
                    else
                        Console.WriteLine("unknown command: " + cmd);

                    break;
            }
        }

        List<Func<object>> func = new List<Func<object>>();

        // 暂时卸载的功能组件
        Dictionary<string, Component> unmountedComs = new Dictionary<string, Component>();
    }
}
