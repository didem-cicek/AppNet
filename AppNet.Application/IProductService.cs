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
        void Create(int CategoryID, string ProductName, string ProductDesriciption);
        Task<bool> Remove(int id);
        Product Update(int ProductID, string ProductName, string ProductDesriciption);
        IReadOnlyCollection<Product> GetAll();
    }
}
