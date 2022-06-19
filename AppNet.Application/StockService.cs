using AppNet.Domain.Entities;
using AppNet.Domain.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppService
{
    public class StockService : IStockService
    {
        private readonly IRepository<Stock> repository;
        public StockService(IRepository<Stock> repository)
        {
            this.repository = repository;
        }
        public Stock Add(string ProductName, string ProductType, decimal PurchaseUnitPrice, decimal StockTotalPrice, int StockPiece, short StockCritical, string SupplierName, int SupplierID, int ProductID)
        {
            Stock stock = new Stock()
            {
                ProductName = ProductName,
                ProductType = ProductType,
                PurchaseUnitPrice = PurchaseUnitPrice,
                StockTotalPrice = StockTotalPrice,
                StockPiece = StockPiece,
                SupplierName = SupplierName,
                SupplierID = SupplierID,
                ProductID = ProductID,
                StockDate = DateTime.Now,
            };
            repository.Add(stock);
            return stock;
        }

        public async Task<ICollection<Stock>> GetAll()
        {
            return repository.GetAll().ToList();
        }

        public async Task<bool> Remove(int id)
        {
            await repository.Remove(id);
            return true;
        }

        public async Task<Stock> Update(int StockID, string ProductName, string ProductType, decimal PurchaseUnitPrice, decimal StockTotalPrice, int StockPiece, short StockCritical, string SupplierName, int SupplierID, int ProductID)
        {
            Stock stock = new Stock()
            {
                StockID = StockID,
                ProductName = ProductName,
                ProductType = ProductType,
                PurchaseUnitPrice = PurchaseUnitPrice,
                StockTotalPrice = StockTotalPrice,
                StockPiece = StockPiece,
                SupplierName = SupplierName,
                SupplierID = SupplierID,
                ProductID = ProductID,
                StockModifitedDate = DateTime.Now,
            };
            repository.Update(StockID, stock);
            return stock;
        }
    }
}
