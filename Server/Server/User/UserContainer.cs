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
    /// 用户数据容器
    /// </summary>
    public class UserContainer : DataContainer<User, string>
    {
        public UserContainer(IAsyncPersistence<User, string> p)
            : base(p)
        {
        }

        // 通过名称获取用户信息,精确匹配
        public void GetByName(string name, Action<User> callback)
        {
            LoadAll((User[] userArr) =>
            {
                if (userArr == null || userArr.Length == 0)
                    callback(null);
                else
                    callback(userArr[0]);
            }, "where Name='" + name + "'");
        }

        // 通过名称获取用户信息,模糊匹配
        public void GetBySubName(string name, Action<User[]> callback)
        {
            LoadAll((User[] userArr) =>
            {
                if (userArr == null || userArr.Length == 0)
                    callback(null);
                else
                    callback(userArr);
            }, "where Name like '%" + name + "%'");
        }

        // 通过ID获取用户信息
        public void GetByID(string _id,Action<User> callback)
        {
            Retrieve(_id, (User user)=>
            {
                callback(user);
            });
        }

        // 通过BindingID获取用户
        public void GetByBindingID(string binding_id, Action<User[]> cb)
        {
            LoadAll((User[] users) =>
            {
                if (users == null || users.Length == 0)
                    cb(null);
                else
                    cb(users);
            }, "where BindingID = '" + binding_id + "'");
        }
    }
}
