using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newapp.Domin.Repositories
{
    public interface IproductRepositories
    {
        Task<IList<Product>> ListAsync();
    }
}
