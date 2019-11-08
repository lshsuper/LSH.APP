using LSH.APP.Code.Generator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSH.APP.Code.Generator.Common
{
    public class AppContext
    {
         public static DatabaseInfo DatabaseInfo { get; set; }
         public  static TableInfoExt CurrentTable { get; set; }
    }
}
