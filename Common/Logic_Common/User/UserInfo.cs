using System;
using System.Collections.Generic;
using Swift;

namespace Nova
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public class UserInfo
    {
        static UserInfo()
        {
    
        }

        // 构造器
        public UserInfo() : this(null) { }
        public UserInfo(string userID)
        {
            ID = userID;
        }

        // 同对应的 User.ID
        public string ID;

		// 用户名称
		public string Name;

        // 用户密码
        public string Password;


        // 等级
        public int Level;

        // 经验
        public int Exp;

        // VIP等级
        public int VipLevel;

		// VIP经验
		public int VipExp;

        // 钻石
        public int Diamond;

		// 绑定钻石
		public int BindDiamond;
    }
}
