using Domin;
using Domin.Servises.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIServices.Abstractions
{
    public interface IcategoryServices
    {
        Task<IList<Category>> ListAsync();
        Task<Category> SaveAsync(Category category);
        Task<Category> FindByIdAsync(int id);
        Task<SaveCategoryResponse1> UpdateAsync(int id,Category category);
        Task<SaveCategoryResponse1> DeleteAsync(int id);
    }
}
