using AppNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppService
{
    public interface ISalesService
    {
        Sale Add(int StockID, int CustomerID, short ProductPiece, decimal SalePrice, decimal TotalPrice, string SaleDesription, string SaleStatus, string SalePaymentMethod);
        Task<Sale> Update(int SaleID, int StockID, int CustomerID, string CustomerName, short ProductPiece, decimal SalePrice, decimal TotalPrice, string SaleDesription, string SaleStatus, string SalePaymentMethod);
        Task<bool> Remove(int id);
        Task<ICollection<Sale>> GetAll();
    }
}
