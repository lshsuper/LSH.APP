﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSH.APP.Code.Generator.Models
{
   public class TableColumnInfo
    {
        public   string ColumnComment { get; set; }
        public   string DataType { get; set; }
        public   string ColumnName { get; set; }

        public   string DefaultValue { get; set; }
        public  string ColumnType { get; set; }
        public  bool IsPrimary { get; set; }

        public  bool IsNullAble { get; set; }
    }
}
