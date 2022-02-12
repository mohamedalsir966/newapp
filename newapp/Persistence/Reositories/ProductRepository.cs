using newapp.Domin;
using newapp.Domin.Repositories;
using newapp.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newapp.Persistence.Reositories
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
