using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSH.APP.Infrastructure.Helpers.Database.Repository
{
    public class DapperRepository<T> : IRepository<T> where T : class, new()
    {
        public int Count()
        {
            Type t = typeof(T);
            var attr=t.GetCustomAttributes(false).FirstOrDefault(f=>f.GetType()==typeof(DapperTableAttribute)) as DapperTableAttribute;
            string sql = $"select count(1) from {attr.Name}";
            
            return null;
        }

        public T Find(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Query()
        {
            throw new NotImplementedException();
        }
    }
}
