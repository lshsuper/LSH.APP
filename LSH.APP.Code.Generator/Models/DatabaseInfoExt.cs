using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSH.APP.Code.Generator.Models
{
  public  class DatabaseInfoExt
    {
           public   string DatabaseName { get; set; }

           public IEnumerable<TableInfo> TableInfos { get; set; }
    }
}
