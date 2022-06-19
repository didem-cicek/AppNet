using AppNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppService
{
    public interface ICashService
    {
        Cash Add(int SaleID, int StockID);
        Task<Cash> Update(int CashID, int SaleID, int StockID);
        Task<bool> Remove(int id);
        Task<ICollection<Cash>> GetAll();
    }
}
