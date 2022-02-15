﻿using Domin;
using Domin.Repositories;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPersistence.Reositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepositories
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IList< Category> > ListAsync()
        {
            List<Category> Categorylist = await _context.Categories.ToListAsync();
            return Categorylist;
        }

        public async Task<Category> SaveAsync(Category category)
        {

            _context.Set<Category>().Add(category);
            await _context.SaveChangesAsync();
            return category;

        }
        public async Task AddAsync1(Category category)
        {
            await _context.Categories.AddAsync(category);
        }

        public async Task<Category> FindByIdAsync(int id)
        {
           return await _context.Categories.FindAsync(id);
        }

        public  void UpdateAsyncalsir( Category category)
        {
             _context.Categories.Update(category);
        }

        public void Remove(Category category)
        {
            _context.Categories.Remove(category);
        }
    }

}