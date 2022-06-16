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
    public class ProductService : IProductService
    {
        IRepository<Product> productRepository;
        public ProductService()
        {
            productRepository = IOCContainer.Resolve<IRepository<Product>>();
        }

        public void Create(int CategoryID, string ProductName, string ProductDesriciption)
        {
            Product p = new Product();
            p.CategoryID = CategoryID;
            p.ProductName = ProductName;
            p.ProductDesriciption = ProductDesriciption;
            productRepository.Add(p);
        }

        public IReadOnlyCollection<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        async public Task<bool> Remove(int id)
        {
            await productRepository.Remove(id);
            return true;
        }

        public Product Update(int ProductID, string ProductName, string ProductDesriciption)
        {
            throw new NotImplementedException();
        }
    }
}
