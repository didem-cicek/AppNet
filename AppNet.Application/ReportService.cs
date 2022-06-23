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

        public Report Add(decimal TotalSales, int TotalStock, int TotalCustomer, decimal TotalCash, string CritialStockName, int CritialStok)
        {
            Report report = new Report()
            {
                TotalSales = TotalSales,
                TotalStock = TotalStock,
                TotalCustomer = TotalCustomer,
                TotalCash = TotalCash,
                CritialStockName = CritialStockName,
                CritialStok = CritialStok,
                ReportDate = DateTime.Now,
            };
            repository.Add(report);
            return report;
        }

        public async Task<ICollection<Report>> GetAll()
        {
            return repository.GetAll().ToList();
        }

        public async Task<bool> Remove(int id)
        {
            await repository.Remove(id);
            return true;
        }

        public async Task<Report> Update(int ReportID, decimal TotalSales, int TotalStock, int TotalCustomer, decimal TotalCash, string CritialStockName, int CritialStok)
        {
            Report report = new Report()
            {
                ReportID = ReportID,
                TotalSales = TotalSales,
                TotalStock = TotalStock,
                TotalCustomer = TotalCustomer,
                TotalCash = TotalCash,
                CritialStockName = CritialStockName,
                CritialStok = CritialStok,
                ReportModifitedDate = DateTime.Now,
            };
            repository.Update(ReportID, report);
            return report;
        }
    }
}
