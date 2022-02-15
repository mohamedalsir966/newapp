using APIServices.Abstractions;
using Domin;
using Domin.Repositories;
using Domin.Servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIServices
{
    public class ProductService : IProductService
    {
        private readonly IproductRepositories _productRepositories;
        public ProductService(IproductRepositories productRepositories)
        {
            _productRepositories = productRepositories;

        }
        public Task<IList<Product>> ListAsync()
        {
            var c = _productRepositories.ListAsync();
            return c;
        }
    }
}
