using System;
using System.Collections.Generic;
using Swift;

namespace Nova
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public class UserInfo : SerializableData
    {
        protected override int IntDataCount { get { return (int)UserInfoIntDataPos.Count; } }
        protected override int StrDataCount { get { return (int)UserInfoStrDataPos.Count; } }
        protected override int ULongDataCount { get { return (int)UserInfoULongDataPos.Count; } }
        protected override int ObjDataCount { get { return (int)UserInfoObjDataPos.Count; } }
        protected override int LstDataCount { get { return (int)UserInfoLstDataPos.Count; } }
        protected override int IntLstDataCount { get { return (int)UserInfoIntLstDataPos.Count; } }
        protected override int StrLstDataCount { get { return (int)UserInfoStrLstDataPos.Count; } }
        protected override int ULongLstDataCount { get { return (int)UserInfoULongLstDataPos.Count; } }
        protected override int IntIntDicCount { get { return (int)UserInfoIIDictDataPos.Count; } }
        protected override int StrIntDicCount { get{ return (int)UserInfoSIDictDataPos.Count; } }

        static Func<ISerializable>[] lstCreators = null;
        protected override Func<ISerializable>[] LstDataCreators { get { return lstCreators; } }

        static Func<ISerializable>[] objCreators = null;
        protected override Func<ISerializable>[] ObjDataCreators { get { return objCreators; } } 

        static UserInfo()
        {
            objCreators = new Func<ISerializable>[(int)UserInfoObjDataPos.Count];       
        }

        // 构造器
        public UserInfo() : this(null) { }
        public UserInfo(string userID)
        {
            ID = userID;
        }

        // 同对应的 User.ID
        public string ID
        {
            get
            {
                return strData[(int)UserInfoStrDataPos.ID];
            }
            set
            {
                strData[(int)UserInfoStrDataPos.ID] = value;
            }
        }

		// 用户名称
		public string Name
		{
			get
			{
				return strData[(int)UserInfoStrDataPos.Name];
			}
			set
			{
				strData[(int)UserInfoStrDataPos.Name] = value;
			}
		}

        // 用户密码
        public string Password
        {
            get
            {
                return strData[(int)UserInfoStrDataPos.PWD];
            }
            set
            {
                strData[(int)UserInfoStrDataPos.PWD] = value;
            }
        }


        // 等级
        public int Level
        {
            get { return intData[(int)UserInfoIntDataPos.Level]; }
            set { intData[(int)UserInfoIntDataPos.Level] = value; }
        }

        // 经验
        public int Exp
        {
            get { return intData[(int)UserInfoIntDataPos.Exp]; }
            set { intData[(int)UserInfoIntDataPos.Exp] = value; }
        }

        // VIP等级
        public int VipLevel
        {
            get { return intData[(int)UserInfoIntDataPos.VipLevel]; }
            set { intData[(int)UserInfoIntDataPos.VipLevel] = value; }
        }

		// VIP经验
		public int VipExp
		{
			get { return intData[(int)UserInfoIntDataPos.VipExp]; }
			set { intData[(int)UserInfoIntDataPos.VipExp] = value; }
		}

        // 钻石
        public int Diamond
        {
            get { return intData[(int)UserInfoIntDataPos.Diamond]; }
            set { intData[(int)UserInfoIntDataPos.Diamond] = value; }
        }

		// 绑定钻石
		public int BindDiamond
		{
			get { return intData[(int)UserInfoIntDataPos.BindDiamond]; }
			set { intData[(int)UserInfoIntDataPos.BindDiamond] = value; }
		}
    }
}
