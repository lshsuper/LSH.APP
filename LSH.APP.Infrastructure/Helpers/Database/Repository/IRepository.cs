using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSH.APP.Infrastructure.Helpers.Database.Repository
{

    public interface IRepository<T> where T:class,new()
    {
        T Find(int id);
        IEnumerable<T>Query();
        int Count();

    }
}
