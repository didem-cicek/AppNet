using AppNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppService
{
    public interface ICategoryService
    {
        void Create(string CategoryName);
        Task<Category> Update(int CategoryID, string NewCategoryName);
        Task<bool> Remove(int id);
        Task<ICollection<Category>> GetAll();
        Task<ICollection<Category>> FilteredList(string filter);
    }
}
