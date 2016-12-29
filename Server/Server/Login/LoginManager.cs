using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Swift;
using Nova;

namespace Server
{
    // 登陆方式
    public enum LoginType
    {
        Simple,
        Reconnected,
    }

    /// <summary>
    /// 登录管理器
    /// </summary>
    public class LoginManager : Component
    {
        // 注册时回调
        public Action<User> RegisterCallBack = null;

        // 用户容器
        public UserContainer UC
        {
            get;
            set;
        }

        // 会话容器
        public SessionContainer SC
        {
            get;
            set;
        }

        // 客户端对应的消息处理模块名
        public string ClientComponentName
        {
            get;
            set;
        }

        // 随机名字
        public RndNameGenerator RNG
        {
            get;
            set;
        }

        // 用户数据发送给客户端之前
        // 可以修改 userInfo 数据，回调里先调用谁是不确定的
        public event Action<User, LoginType> BeforeUserLogin = null;
        // 用户数据发送给客户端之后
        // 可以额外给客户端发送数据(使用 NetUtils.Send)
        public event Action<User, LoginType> AfterUserLogin = null;

        const string forbidChars = "@<>'\"#%$?=+-*:;[]{}^/\\\r\n ";

        // 用户名是否有效
        public void IsNameValid(string name, Action<ReasonEnums> cb)
        {
            // 不能为空串
            if (string.IsNullOrEmpty(name))
            {
                cb(ReasonEnums.Login_NoName);
                return;
            }

            int L = Utils.NameLength(name);

            // 最多6个汉字
            if (L < 4)
            {
                cb(ReasonEnums.Login_NameTooShort);
                return;
            }
            else if (L > 12)
            {
                cb(ReasonEnums.Login_NameTooLong);
                return;
            }

            // 不能有特殊字符
            foreach (char c in forbidChars)
            {
                if (name.IndexOf(c) >= 0)
                {
                    cb(ReasonEnums.Login_NameHaveSp);
                    return;
                }
            }
            
            // 不得含有敏感词
            //if (WF.NameHasSensitiveWord(name))
            //{
            //    cb(ReasonEnums.Login_NameInvalid);
            //    return;
            //}

            // 最后检查重名
            UC.GetByName(name, (User usr) =>
            {
                if (usr != null)
                    cb(ReasonEnums.Login_NameExists);
                else
                    cb(ReasonEnums.Ok);
            });
        }

        // 随机名字，如果随机的名字重复超过5次则直接以BB形式随机
        public void RandomName(IWriteableBuffer buff, Action buff_end, int times = 0)
        {
            string name;
            // 超过五次直接随机BB形式的名字
            if (times == RNG.RandomNameTimes)
            {
                name = RNG.RndName_BB();
                buff.Write(name);
                buff_end();
                return;
            }
            else
                name = RNG.RndName_AB();
            times++;
            // 检查重名
            UC.GetByName(name, (User usr) =>
            {
                if (usr != null)
                {
                    RandomName(buff, buff_end, times);
                }
                else
                {
                    buff.Write(name);
                    buff_end();
                }
            });
        }

        /// <summary>
        /// 登录逻辑
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="uid">用户ID </param>
        /// <param name="name">名字，当...........TODO</param>
        /// <param name="sex"></param>
        /// <param name="callback"></param>
        public void Login(Connection conn, 
                            string uid, 
                            string name,
                            string pwd,
                            LoginType type,
                            IWriteableBuffer buff, 
                            Action buff_end)
        {
            // 登录 ip
            string loginIP = conn.GetIP();

            UC.Retrieve(uid, (User usr) =>
            {
                Session s;
                // 已有用户
                if (usr != null)
                {
                    // 检查是否已经在线，若在线，需要踢掉
                    s = SC.GetByID(uid);
                    if (s != null)
                    {
                        KickUser(s, "login in other place");
                        s = null;
                    }

                    // 检查密码
                    {
                        if (usr.Info.Password == null || usr.Info.Password == "")
                            usr.Info.Password = pwd;
                        else if (usr.Info.Password != pwd)
                        {
                            buff.Write((int)ReasonEnums.InvalidIDOrPWD);
                            buff_end();
                            return;
                        }
                    }

                    // 执行登录过程
                    DoLoginImpl(usr, conn, type, buff, buff_end);
                }
                else
                {
                    // 用户尚未存在

                    // 检查名称合法性
                    IsNameValid(name, (r) =>
                    {
                        if (r != ReasonEnums.Ok)
                        {
                            // 必须指定名字
                            // 客户端收到 Login_NoName 之后，显示随机名字界面
                            buff.Write((int)r);
                            buff_end();
                            return;
                        }
                        else
                        {
                            ////---- 二次检查，或许还有更正确的方式？
                            if (UC.Exists(uid))
                                return;
                            
                            // 创建新用户对象
                            UserInfo info = new UserInfo(uid);
                            InitUserInfo(info, name);
                            info.Password = pwd;
                            usr = new User(info);
                            UC.AddNew(usr);

                            // 注册用户回调
                            if (null != RegisterCallBack)
                                RegisterCallBack(usr);

                            // 执行登录过程
                            DoLoginImpl(usr, conn, type, buff, buff_end);

                            return;
                        }
                    });                    
                }
            });
        }

        // 执行登录过程
        public void DoLoginImpl(User usr, Connection conn, LoginType type, IWriteableBuffer buff, Action buff_end)
        {
            // 将用户加入会话
            Session s = new Session();
            s.User = usr;
            s.Conn = conn;
            conn.Tag = s;
            SC.Add(s);

            // 登录 ip
            string loginIP = conn.GetIP();

            // 记录登录时间
            // BeforeUserLogin 回调里会用到这个时间，不能放到 BeforeUserLogin 里去设置这个时间
            usr.Update();

            // 回调 1
            if (BeforeUserLogin != null)
                BeforeUserLogin(usr, type);

            // 发送给客户端
            buff.Write((int)ReasonEnums.Ok);

            // UserInfo
            // TODO
            // usr.Info.Serialize(buff);

            // 时间信息
            // 这个数据最好是紧跟着 userInfo 过去，而不是额外的 NetUtils.Send
            DateTime dt2015 = new DateTime(2015, 1, 1);
            TimeSpan span = TimeMgr.Inst.Now.Subtract(dt2015);
            int S = (int)span.TotalSeconds;
            buff.Write(S);

            // 登录设置通信密钥
            byte[] code = Encoding.ASCII.GetBytes(TimeMgr.Inst.NowTicks.ToString());
            buff.Write(code.Length);
            buff.Write(code);

            // 真正发送数据
            buff_end();

            // 密钥生效
            conn.EncryptCode = code;
            conn.DecryptCode = code;

            // 回调 2
            if (AfterUserLogin != null)
                AfterUserLogin(usr, type);
        }

        // 踢掉用户
        public void KickUser(Session s, string reason)
        {
            // 移除会话，并发送踢掉用户的消息
            SC.Remove(s);
            NetUtils.Send("Kickout", ClientComponentName, (IWriteableBuffer buff) =>
            {
                buff.Write(reason);
            }, s.Conn);

            // 因为需要等消息发送出去，所以等待一帧后关闭连接，如果一帧内没发完，也不管了
            (GetComponent("CoroutineManager") as CoroutineManager).Start(CloseConnection(s.Conn));
        }

        #region 保护部分

        // 等待一帧后关闭指定连接
        IEnumerator CloseConnection(Connection conn)
        {
            yield return new FrameWaiter(1);
            conn.Close();
        }

        // 刚创建用户数据时，初始化一下
        void InitUserInfo(UserInfo info, string name)
        {
            // 玩家初始化为一级
            info.Level = 1;

            // 默认名字为空串，表示接下来要指定名字
            info.Name = name;
        }


        #endregion
    }
}
