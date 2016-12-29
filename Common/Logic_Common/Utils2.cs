using System;
using System.Collections;
using System.Collections.Generic;
using Swift;

namespace Nova
{
	public class Utils2 : Swift.Utils1
	{
		// 冒泡排序，升序
		public static void OrderBy<T>(T[] data, Func<T, T, bool> lessOrEqual)
		{
			for (int i = 0; i < data.Length; i++)
			{
				T a = data[i];
				for (int j = i + 1; j < data.Length; j++)
				{
					T b = data[j];
					if (!lessOrEqual(a, b))
					{
						data[i] = b;
						data[j] = a;
					}
				}
			}
		}

        // 获取随机数，区间为 [min, max)
        public static int Random(int min, int max)
        {
            return r.Next(min, max);
        }


		// 从一个数组中随机一个，数组中装的是每一个元素的概率
		// 返回索引
		// 比如 RandomOne([80, 15, 4, 1]);
		// 80% 返回 0
		// 15% 返回 1
		// 4% 返回 2
		// 1% 返回 3
		public static int RandomOne(int[] arr)
		{
			return RandomOne(arr.Length, (i) => arr[i]);
		}
		public static int RandomOne(int L, Func<int, int> funGetProbability)
		{
			int sum = 0;
			
			// 先把掉落组里的数值全部加起来，一会做随机
			for (int i = 0; i < L; i++)
				sum += funGetProbability(i);
			
			int res = Utils.Random(0, sum);
			int r = 0;
			for (int i = 0; i < L; i++)
			{
				r += funGetProbability(i);
				if (res < r)
					return i;
			}

			// 不会走到这里！
            throw new Exception("Shouldn't reach here");
		}

        // 对列表中元素逐项转换
        public static void DownConvertList<T1, T2>(IEnumerable<T1> lst1, List<T2> lst2) where T2 : T1
        {
            lst2.Clear();
            foreach (T1 d in lst1)
                lst2.Add((T2)d);
        }

        // 对字典中元素逐项转换
        public static void DownConvertDict<T1, T2, T3>(Dictionary<T1, T2> dict1, Dictionary<T1, T3> dict2) where T3 : T2
        {
            dict2.Clear();
            foreach (KeyValuePair<T1, T2> d in dict1)
                dict2[d.Key] = (T3)d.Value;
        }

        // 对列表中元素逐项转换
        public static void UpConvertList<T1, T2>(IEnumerable<T1> lst1, List<T2> lst2) where T1 : T2
        {
            lst2.Clear();
            foreach (T1 d in lst1)
                lst2.Add(d);
        }

        // 对字典中元素逐项转换
        public static void UpConvertDict<T1, T2, T3>(Dictionary<T1, T2> dict1, Dictionary<T1, T3> dict2) where T2 : T3
        {
            dict2.Clear();
            foreach (KeyValuePair<T1, T2> d in dict1)
                dict2[d.Key] = d.Value;
        }

        // 保证给定列表的最小尺寸，不足部分用指定默认值填充
        public static void MakeSureListMinSize<T>(List<T> lst, int minSize, T dv)
        {
            while (lst.Count < minSize)
                lst.Add(dv);
        }

        /// <summary>
        /// 货币最大位数
        /// </summary>
        public const int MaxCount = 5;
        /// <summary>
        /// 将钱的数量转换成XXXX万格式 （如果数量大于最大显示长度maxCount,那么将以XXX万赖显示）
        /// </summary>
        /// <param name="money">钱的数量</param>
        /// <param name="maxCount">最大显示长度位数</param>
        public static string FormatMoney(int money, int maxCount = MaxCount)
        {
            if (money.ToString().Length > maxCount)
            {
                return string.Format("{0}万", money / 10000);
            }
            else
                return money.ToString();
        }

        // 在给定列表中选取所有满足条件的对象
        public static T[] SelectAll<T>(IEnumerable<T> list, Func<T, bool> f)
        {
            List<T> allSel = new List<T>();
            foreach (T d in list)
            {
                if (f(d))
                    allSel.Add(d);
            }

            return allSel.ToArray();
        }
        
        // 保留1位小数(兼容JS)
//        public static string Reserve1Decimal(float f)
//        {
//            return string.Format("{0}.{1}", (int)f, (((int)(f * 10)) % 10));
//        }
        // 保留2位小数(兼容JS)
        public static string Reserve2Decimal(float f)
        {
            return string.Format("{0}.{1}", (int)f, (((int)(f * 100)) % 100).ToString().PadRight(2, '0'));
        }

        // 在给定列表中，选取第一个满足条件的对象
        public static T SelectFirst<T>(IEnumerable<T> list, Func<T, bool> f)
        {
            foreach (T d in list)
            {
                if (f(d))
                    return d;
            }
            
            return default(T);
        }
        
        // 在给定列表中选取第一个满足条件的对象的位置
        public static int FindFirstPos<T>(IEnumerable<T> list, Func<T, bool> f)
        {
            int i = 0;
            foreach (T v in list)
            {
                if (f(v))
                    return i;
                else
                    i++;
            }
            
            return -1;
        }
        
        // 寻找第一个空位置
        public static int FindFirstNullPos<T>(IEnumerable<T> list)
        {
            return FindFirstPos(list, (T v) => { return v == null; });
        }
        
        
        // 在给定的列表中数满足条件的项目个数
        public static int CountNoNull<T>(IEnumerable<T> list)
        {
            return Count(list, (T v) => { return v != null; });
        }
        
        // 在给定的列表中数满足条件的项目个数
        public static int Count<T>(IEnumerable<T> list, Func<T, bool> f)
        {
            int n = 0;
            foreach (T d in list)
            {
                if (f(d))
                    n++;
            }
            
            return n;
        }
	}
}
