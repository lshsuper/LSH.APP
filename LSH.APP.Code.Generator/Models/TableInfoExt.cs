using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSH.APP.Code.Generator.Models
{
    public class TableInfoExt
    {
        public TableInfo TableInfo { get; set; }
        public IEnumerable<TableColumnInfo> TableColumnInfos { get; set; }

    }
}
