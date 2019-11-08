using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSH.APP.Code.Generator.Common
{

    /// <summary>
    /// 数据库类别
    /// </summary>
    public enum DatabaseTypeEnum
    {
        /// <summary>
        /// mysql
        /// </summary>
        [Description("Mysql数据库")]
        Mysql = 0,
        /// <summary>
        /// SqlServer数据库
        /// </summary>
        [Description("SqlServer数据库")]
        SqlServer=1,
        
    }
}
