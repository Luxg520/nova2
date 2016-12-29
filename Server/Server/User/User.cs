using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swift;
using Nova;

namespace Server
{
    /// <summary>
    /// 会话对象
    /// </summary>
    public class User : DataItem<string>
    {
        public User(UserInfo usrInfo)
            : base(usrInfo.ID)
        {
            info = usrInfo;
        }

        // 用户信息
        public UserInfo Info
        {
            get
            {
                return info;
            }
        }

        #region 保护部分

        // 用户信息
        UserInfo info = null;

        #endregion
    }
}
