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
        Stock Add(string ProductName, string ProductType, decimal PurchaseUnitPrice, decimal StockTotalPrice, int StockPiece, short StockCritical, string SupplierName, int SupplierID, int ProductID);
        Task<Stock> Update(int StockID, string ProductName, string ProductType, decimal PurchaseUnitPrice, decimal StockTotalPrice, int StockPiece, short StockCritical, string SupplierName, int SupplierID, int ProductID);
        Task<bool> Remove(int id);
        Task<ICollection<Stock>> GetAll();
    }
}
