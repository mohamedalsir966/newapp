using Domin;
using Domin.Repositories;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPersistence.Reositories
{
    public class ProductRepository : BaseRepository, IproductRepositories
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<IList<Product>> ListAsync()
        {
            var Productslist = await _context.Products.ToListAsync();
            return Productslist;
        }
    }
}
