using AppNet.Domain.Entities;
using AppNet.Domain.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppService
{
    public class ReportService : IReportService
    {
        private readonly IRepository<Report> repository;
        public ReportService(IRepository<Report> repository)
        {
            this.repository = repository;
        }
        public Report Add(string ReportName, int CustomerID, string CustomerName, int StockID, int SalesID, int SupplierID, string SupplierName, int CashID)
        {
            Report report= new Report()
            {
                ReportName = ReportName,
                CustomerID = CustomerID,
                CustomerName = CustomerName,
                StockID = StockID,
                SupplierID = SupplierID,
                SupplierName = SupplierName,
                CashID = CashID,
                ReportDate = DateTime.Now,
            };
            repository.Add(report);
            return report;
        }

        public async Task<ICollection<Report>> GetAll()
        {
            return repository.GetAll().ToList();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Report> Update(int ReportID, string ReportName, int CustomerID, string CustomerName, int StockID, int SalesID, int SupplierID, string SupplierName, int CashID)
        {
            Report report = new Report()
            {
                ReportID = ReportID,
                ReportName = ReportName,
                CustomerID = CustomerID,
                CustomerName = CustomerName,
                StockID = StockID,
                SupplierID = SupplierID,
                SupplierName = SupplierName,
                CashID = CashID,
                ReportModifitedDate = DateTime.Now,
            };
            repository.Update(ReportID, report);
            return report;
        }
    }
}
