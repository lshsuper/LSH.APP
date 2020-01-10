using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSH.APP.Infrastructure.Extensions
{
    /// <summary>
    /// DataSet扩展
    /// </summary>
    public static class DataSetExtension
    {
        /// <summary>
        /// 过滤
        /// </summary>
        /// <param name="dts"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public static void Remove(this DataTableCollection dts, Func<DataTable, bool> filter)
        {

            HashSet<int> tbIndexs = new HashSet<int>();
            int index = 0;
            foreach (DataTable dt in dts)
            {
                if (!filter(dt)) { tbIndexs.Add(index); }
                index++;
            }
            foreach (int tbIndex in tbIndexs)
            {
                dts.RemoveAt(tbIndex);
            }


        }
        /// <summary>
        /// 获取单个Table
        /// </summary>
        /// <param name="dts"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public static DataTable Find(this DataTableCollection dts, Func<DataTable, bool> filter)
        {
            foreach (DataTable dt in dts)
            {
                if (filter(dt)) { return dt; }
            }
            return null;
        }
        /// <summary>
        /// 获取多个Table
        /// </summary>
        /// <param name="dts"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public static IList<DataTable> Where(this DataTableCollection dts, Func<DataTable, bool> filter)
        {
            List<DataTable> result = new List<DataTable>();
            foreach (DataTable dt in dts)
            {
                if (filter(dt)) { result.Add(dt); }
            }
            return result;
        }
        /// <summary>
        ///清除表名+列名+行值带有的空格
        /// </summary>
        /// <param name="dts"></param>
        public static void Trim(this DataTableCollection dts)
        {
            foreach (DataTable dt in dts)
            {
                //清除表名空格
                dt.TableName = dt.TableName.Trim();

                //清除列名的空格
                foreach (DataColumn column in dt.Columns)
                {
                    column.ColumnName = column.ColumnName.Trim();
                }
                //清除行列值的空格
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        row[column.ColumnName] = row[column.ColumnName].ToString().Trim();
                    }
                }
            }
        }
        /// <summary>
        /// 清空列名的空格
        /// </summary>
        /// <param name="dts"></param>
        public static void TrimColumn(this DataTableCollection dts)
        {
            foreach (DataTable dt in dts)
            {
                //清除列名的空格
                foreach (DataColumn column in dt.Columns)
                {
                    column.ColumnName = column.ColumnName.Trim();
                }
            }
        }


    }
}
