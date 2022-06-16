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
        IRepository<Category> categoryRepository;
        public CategoryService()
        {
            categoryRepository = IOCContainer.Resolve<IRepository<Category>>();
        }

        public void Create(string CategoryName)
        {
            Category c = new Category();
            c.CategoryName = CategoryName;
            categoryRepository.Add(c);
        }

        async public Task<ICollection<Category>> GetAll()
        {
            return categoryRepository.GetList().ToList();
        }

        async Task<Category> ICategoryService.Update(int CategoryID, string NewCategoryName)
        {
            Category c = new Category();
            c.CategoryId = CategoryID;
            c.CategoryName = NewCategoryName;

            return await categoryRepository.Update(CategoryID, c);
        }

        async public Task<bool> Remove(int id)
        {
           await categoryRepository.Remove(id);
           return true;
        }

        public IQueryable<Category> FilteredList(string filter)
        {
            return categoryRepository.GetList(c => c.CategoryName.ToLower().Contains(filter.ToLower())).ToList();
        }
    }
}
