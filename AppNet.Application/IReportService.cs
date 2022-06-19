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
        Report Add(string ReportName, int CustomerID, string CustomerName, int StockID, int SalesID, int SupplierID, string SupplierName, int CashID);
        Task<Report> Update(int ReportID, string ReportName, int CustomerID, string CustomerName, int StockID, int SalesID, int SupplierID, string SupplierName, int CashID);
        Task<bool> Remove(int id);
        Task<ICollection<Report>> GetAll();
    }
}
