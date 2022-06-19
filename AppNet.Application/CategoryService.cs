using AppNet.Domain.Entities;
using AppNet.Domain.InterFaces;
using AppNet.Infrastructer.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppService
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> repository;
        public CategoryService(IRepository<Category> repository)
        {
            this.repository = repository;
        }


        async public Task<ICollection<Category>> GetAll()
        {
            return repository.GetAll().ToList();
        }

        async Task<Category> ICategoryService.Update(int CategoryID, string NewCategoryName)
        {
            Category category = new Category()
            {
                CategoryId = CategoryID,
                CategoryName = NewCategoryName,
                CategoryModifitedDate = DateTime.Now,
            };
            repository.Update(category.CategoryId,category);
            return category;
        }

        async public Task<bool> Remove(int id)
        {
           await repository.Remove(id);
           return true;
        }

        public Category Add(string name)
        {
            Category category = new Category()
            {
                CategoryName = name,
                CategoryDate= DateTime.Now,
            };
            repository.Add(category);
            return category;
        }
    }
}
