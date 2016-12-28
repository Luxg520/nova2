using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Swift
{
    /// <summary>
    /// 组件接口
    /// </summary>
    public class Component_Logic
    {
        // 组件对象名
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Func<string, Component_Logic> FuncGetComponent = null;
		public Component_Logic GetComponent(string str)
		{
			return FuncGetComponent (str);
		}

        public Func<string, Component_Logic> FuncRemoveComponent = null;
        public Component_Logic RemoveComponent(string str)
        {
            return FuncRemoveComponent(str);
        }

        public Action<string, Component_Logic> FuncAddComponent = null;
        public void AddComponent(string str, Component_Logic com)
        {
            FuncAddComponent(str, com);
        }

        // 本对象被加入容器
        public virtual void OnAdded()
        {
        }

        // 本对象被移出容器
        public virtual void OnRemoved()
        {
        }

        // 关闭组件对象
        public virtual void Close()
        {
        }

		// 清理（客户端回登录界面会调用）
		public virtual void Clear()
		{

		}

        #region 保护部分

        // 组件对象名称
        protected string name = null;

        #endregion
    }
}
