using AppNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppService
{
    public interface IReportService
    {
        Report Add(decimal TotalSales, int TotalStock, int TotalCustomer, decimal TotalCash, string CritialStockName, int CritialStok);
        Task<Report> Update(int ReportID, decimal TotalSales, int TotalStock, int TotalCustomer, decimal TotalCash, string CritialStockName, int CritialStok);
        Task<bool> Remove(int id);
        Task<ICollection<Report>> GetAll();
    }
}
