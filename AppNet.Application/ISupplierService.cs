using AppNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppService
{
    public interface ISupplierService
    {
        Supplier Add(string SupplierName, string SupplierPhone, string SupplierAddress, int SupplierTaxNumber,string SupplierTaxName, decimal SupplierDebt, decimal SupplierReceivable);
        Task<Supplier> Update(int SupplierID, string SupplierName, string SupplierPhone, string SupplierAddress, int SupplierTaxNumber, string SupplierTaxName, decimal SupplierDebt, decimal SupplierReceivable);
        Task<bool> Remove(int id);
        Task<ICollection<Supplier>> GetAll();
    }
}
