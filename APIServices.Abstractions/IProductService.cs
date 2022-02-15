using Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIServices.Abstractions
{
    public interface IProductService
    {
        Task<IList<Product>> ListAsync();
    }
}
