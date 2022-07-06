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
        public Stock Add(decimal PurchaseUnitPrice, decimal StockTotalPrice, int StockPiece, short StockCritical, string color, string size, int SupplierID, int ProductID)
        {
            Stock stock = new Stock()
            {
                SupplierID = SupplierID,
                ProductID = ProductID,
                PurchaseUnitPrice = PurchaseUnitPrice,
                StockTotalPrice = StockTotalPrice,
                StockPiece = StockPiece,
                StockCritical = StockCritical,
                Color = color,
                Size = size,
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

        public async Task<Stock> Update(int StockID, decimal PurchaseUnitPrice, decimal StockTotalPrice, int StockPiece, short StockCritical, string color, string size, int SupplierID, int ProductID)
        {
            Stock stock = new Stock()
            {
                StockID = StockID,
                SupplierID = SupplierID,
                ProductID = ProductID,
                PurchaseUnitPrice = PurchaseUnitPrice,
                StockTotalPrice = StockTotalPrice,
                StockPiece = StockPiece,
                StockCritical = StockCritical,
                Color=color,
                Size = size,
                StockModifitedDate = DateTime.Now,
            };
            repository.Update(stock);
            return stock;
        }
    }
}
