using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nova
{
    /// <summary>
    /// 各种原因代码
    /// </summary>
    public enum ReasonEnums
    {
        Ok,   // 成功
        Failed, // 失败
		TimeExpired, // 超时
		Disconnected, // 连接中断
        Login_NoName,
        Login_NameTooShort,
        Login_NameTooLong,
        Login_NameHaveSp,
        Login_NameInvalid,
        Login_NameExists,
        InvalidIDOrPWD,
        Unknown,                // 未知原因
    }
}