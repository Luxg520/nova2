using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Swift
{
    /// <summary>
    /// 提供一些动态特性的功能
    /// </summary>
    public class Dynamic : DynamicIOS
    {
        // 获取指定名称的类型对象
        public static Type GetTypeByTypeName(string typeName)
        {
            Assembly asm = GetAssemblyByType(typeName);
            return asm.GetType(typeName);
        }

        // 创建给定类型的一个实例对象
        public static object CreateByType(Type type)
        {
            return type.Assembly.CreateInstance(type.FullName);
        }

        // 创建给定类型名称的一个实例对象
        public static object CreateByTypeName(string typeName)
        {
            Assembly asm = GetAssemblyByType(typeName);
            if (asm != null)
                return asm.CreateInstance(typeName);
            else
                return null;
        }
    }
}
