using AppNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppService
{
    public interface ICustomerService
    {
        Customer Add(string CustomerName, string CustomerPhone, string CustomerEmail, string CustomerAddress, string CustomerShippingAddress, int CustomerTaxNumber, string CustomerTaxOffice, string CustomerDesription, decimal CustomerDebt, decimal CustomerReceivable);
        Task<Customer> Update(int CustomerID, string CustomerName, string CustomerPhone, string CustomerEmail, string CustomerAddress, string CustomerShippingAddress, int CustomerTaxNumber, string CustomerTaxOffice, string CustomerDesription, decimal CustomerDebt, decimal CustomerReceivable);
        Task<bool> Remove(int id);
        Task<ICollection<Customer>> GetAll();
    }
}
