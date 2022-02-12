using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newapp.Domin.Servises
{
    public interface IProductService
    {
        Task<IList<Product>> ListAsync();
    }
}
