using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSH.APP.Infrastructure.Helpers.Database
{
   public class DapperTableAttribute:Attribute
    {
        public string Name { get; set; }
        public DapperTableAttribute(string  name)
        {
            Name = name;
        }
    }
}
