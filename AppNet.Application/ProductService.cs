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
        private readonly IRepository<Product> repository;
        public ProductService(IRepository<Product> repository)
        {
            this.repository = repository;
        }
        public Product Add(int CategoryID, string ProductName, string ProductDesriciption)
        {
            Product product = new Product()
            {
                CategoryID = CategoryID,
                ProductName = ProductName,
                ProductDesriciption = ProductDesriciption,
                ProductDate = DateTime.Now,
            };
            repository.Add(product);
            return product;
        }

        async public Task<bool> Remove(int id)
        {
            await repository.Remove(id);
            return true;
        }

        async Task<ICollection<Product>> IProductService.GetAll()
        {
            return repository.GetAll().ToList();
        }

        async Task<Product> IProductService.Update(int ProductID, string NewProductName, int NewCategoryID, string NewProductDesriciption)
        {
            Product product = new Product()
            {
                ProductID = ProductID,
                ProductName = NewProductName,
                ProductDesriciption = NewProductDesriciption,
                CategoryID = NewCategoryID,
                ProductModifitedDate = DateTime.Now,
            };
            repository.Update(product.ProductID,product);
            return product;
        }
    }
}
