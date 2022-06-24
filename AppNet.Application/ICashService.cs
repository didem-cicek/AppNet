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
        Cash Add(decimal Debt, decimal Receivable, decimal TotalCash);
        Task<Cash> Update(int CashID, decimal Debt, decimal Receivable, decimal TotalCash);
        Task<bool> Remove(int id);
        Task<ICollection<Cash>> GetAll();
    }
}
