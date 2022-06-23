using AppNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppService
{
    public interface IProductService
    {
        Product Add(int CategoryID, string ProductName, string ProductDesriciption);
        Task<Product> Update(int ProductID, string NewProductName, int NewCategoryID, string NewProductDesriciption);
        Task<bool> Remove(int id);
        Task<ICollection<Product>> GetAll();
        
    }
}
