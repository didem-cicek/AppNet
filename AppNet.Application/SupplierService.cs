using AppNet.AppService;
using AppNet.Domain.Entities;
using AppNet.Domain.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppService
{
    public class SupplierService : ISupplierService
    {
        private readonly IRepository<Supplier> repository;
        public SupplierService(IRepository<Supplier> repository)
        {
            this.repository = repository;
        }
        public Supplier Add(string SupplierName, string SupplierPhone, string SupplierAddress, int SupplierTaxNumber, string SupplierTaxName, decimal SupplierDebt, decimal SupplierReceivable)
        {
            Supplier supplier = new Supplier()
            {
                SupplierName = SupplierName,
                SupplierPhone = SupplierPhone,
                SupplierAddress = SupplierAddress,
                SupplierTaxNumber = SupplierTaxNumber,
                SupplierTaxName = SupplierTaxName,
                SupplierDebt = SupplierDebt,
                SupplierReceivable = SupplierReceivable,
                SupplierDate = DateTime.Now,
                SupplierModifitedDate = DateTime.Now,

            };
            repository.Add(supplier);
            return supplier;
        }

        public async Task<ICollection<Supplier>> GetAll()
        {
            return repository.GetAll().ToList();
        }

        public async Task<bool> Remove(int id)
        {
            await repository.Remove(id);
            return true;
        }

        public async Task<Supplier> Update(int SupplierID, string SupplierName, string SupplierPhone, string SupplierAddress, int SupplierTaxNumber, string SupplierTaxName, decimal SupplierDebt, decimal SupplierReceivable)
        {
            Supplier supplier = new Supplier()
            {
                SupplierID = SupplierID,
                SupplierName = SupplierName,
                SupplierPhone = SupplierPhone,
                SupplierAddress = SupplierAddress,
                SupplierTaxNumber = SupplierTaxNumber,
                SupplierTaxName = SupplierTaxName,
                SupplierDebt = SupplierDebt,
                SupplierReceivable = SupplierReceivable,
                SupplierModifitedDate = DateTime.Now,

            };
            repository.Update(supplier);
            return supplier;
        }
    }
}
