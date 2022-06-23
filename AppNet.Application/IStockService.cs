using AppNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppService
{
    public interface IStockService
    {
        Stock Add(string ProductType, decimal PurchaseUnitPrice, decimal StockTotalPrice, int StockPiece, short StockCritical, int SupplierID, int ProductID);
        Task<Stock> Update(int StockID, string ProductType, decimal PurchaseUnitPrice, decimal StockTotalPrice, int StockPiece, short StockCritical, int SupplierID, int ProductID);
        Task<bool> Remove(int id);
        Task<ICollection<Stock>> GetAll();
    }
}
