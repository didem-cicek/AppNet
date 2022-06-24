using AppNet.Domain.Entities;
using AppNet.Domain.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppService
{
    public class SalesService : ISalesService
    {
        private readonly IRepository<Sale> repository;
        public SalesService(IRepository<Sale> repository)
        {
            this.repository = repository;
        }

        public Sale Add(int StockID, int CustomerID, short ProductPiece, decimal SalePrice, decimal TotalPrice, string SaleDesription, string SaleStatus, string SalePaymentMethod)
        {
            Sale sale = new Sale()
            {
                StockID = StockID,
                CustomerID = CustomerID,
                ProductPiece = ProductPiece,
                SalePrice = SalePrice,
                SaleDesription = SaleDesription,
                SaleStatus = SaleStatus,
                SalePaymentMethod = SalePaymentMethod,
                SaleDate = DateTime.Now,
            };
            repository.Add(sale);
            return sale;
        }

        public async Task<ICollection<Sale>> GetAll()
        {
            return repository.GetAll().ToList();
        }

        public async Task<bool> Remove(int id)
        {
            await repository.Remove(id);
            return true;
        }

        public async Task<Sale> Update(int SaleID, int StockID, int CustomerID, short ProductPiece, decimal SalePrice, decimal TotalPrice, string SaleDesription, string SaleStatus, string SalePaymentMethod)
        {
            Sale sale = new Sale()
            {
                SaleID = SaleID,
                StockID = StockID,
                CustomerID = CustomerID,
                ProductPiece = ProductPiece,
                SalePrice = SalePrice,
                SaleDesription = SaleDesription,
                SaleStatus = SaleStatus,
                SalePaymentMethod = SalePaymentMethod,
                SaleModifitedDate = DateTime.Now,
            };
            repository.Update(SaleID, sale);
            return sale;
        }
    }
}
