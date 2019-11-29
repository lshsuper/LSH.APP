using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSH.APP.Infrastructure.Helpers.Database
{
    public class DapperColumnAttribute : Attribute
    {

        public bool IsKey { get; set; }
        public bool IsPrimi { get}
        public string Name { get; set; }
        public DapperColumnAttribute(string  name)
        {
            Name=name
        }
    }
}
