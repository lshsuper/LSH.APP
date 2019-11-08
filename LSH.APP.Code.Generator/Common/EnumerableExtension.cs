using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSH.Infrastructure.Extensions
{
    /// <summary>
    /// 扩展Linq相关聚合方法
    /// </summary>
    public static class EnumerableExtension
    {
        /// <summary>
        /// 扩展Max（支持非空判断）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <param name="source"></param>
        /// <param name="selector"></param>
        /// <param name="ignoreEmpty"></param>
        /// <returns></returns>
        public static V Max<T, V>(this IEnumerable<T> source, Func<T, V> selector, bool ignoreEmpty)
        {
            if (ignoreEmpty)
            {
                if (source == null || !source.Any()) return default;
                return source.Max(selector);
            }
            return source.Max(selector);

        }
        /// <summary>
        /// 扩展Min（支持非空判断）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <param name="source"></param>
        /// <param name="selector"></param>
        /// <param name="ignoreEmpty"></param>
        /// <returns></returns>
        public static V Min<T, V>(this IEnumerable<T> source, Func<T, V> selector, bool ignoreEmpty)
        {
            if (ignoreEmpty)
            {
                if (source == null || !source.Any()) return default;
                return source.Min(selector);
            }
            return source.Min(selector);

        }
        /// <summary>
        /// 扩展Average（支持非空判断）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="selector"></param>
        /// <param name="ignoreEmpty"></param>
        /// <returns></returns>
        public static double Averagex<T>(this IEnumerable<T> source, Func<T, double> selector, bool ignoreEmpty)
        {
            if (ignoreEmpty)
            {
                if (source == null || !source.Any()) return 0;
                return source.Average(selector);
            }
            return source.Average(selector);

        }

        /// <summary>
        /// foreach带索引的扩展（索引位从1开始）
        /// </summary>
        /// <typeparam name="T">当前元素</typeparam>
        /// <param name="list">集合</param>
        /// <param name="action">lambda执行体</param>
        public static void ForEach<T>(this IEnumerable<T> list, Action<T, int> action)
        {
            int index = 0;
            foreach (var item in list)
            {
                index++;
                action(item, index);

            }
        }
        
    }
}
