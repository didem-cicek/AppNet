using AppNet.Domain.Entities;
using AppNet.Domain.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppService
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> repository;
        public CustomerService(IRepository<Customer> repository)
        {
            this.repository = repository;
        }
        public Customer Add(string CustomerName, string CustomerPhone, string CustomerEmail, string CustomerAddress, string CustomerShippingAddress, int CustomerTaxNumber, string CustomerTaxOffice, string CustomerDesription)
        {
            Customer customer = new Customer()
            {
                CustomerName = CustomerName,
                CustomerPhone = CustomerPhone,
                CustomerEmail = CustomerEmail,
                CustomerAddress = CustomerAddress,
                CustomerShippingAddress = CustomerShippingAddress,
                CustomerTaxNumber = CustomerTaxNumber,
                CustomerTaxOffice = CustomerTaxOffice,
                CustomerDesription = CustomerDesription,
                CustomerDate = DateTime.Now,
                
            };
            repository.Add(customer);
            return customer;
        }

        public async Task<ICollection<Customer>> GetAll()
        {
            return repository.GetAll().ToList();
        }

        public async Task<bool> Remove(int id)
        {
            await repository.Remove(id);
            return true;
        }

        public async Task<Customer> Update(int CustomerID, string CustomerName, string CustomerPhone, string CustomerEmail, string CustomerAddress, string CustomerShippingAddress, int CustomerTaxNumber, string CustomerTaxOffice, string CustomerDesription)
        {
            Customer customer = new Customer()
            {
                CustomerID = CustomerID,
                CustomerName = CustomerName,
                CustomerPhone = CustomerPhone,
                CustomerEmail = CustomerEmail,
                CustomerAddress = CustomerAddress,
                CustomerShippingAddress = CustomerShippingAddress,
                CustomerTaxNumber = CustomerTaxNumber,
                CustomerTaxOffice = CustomerTaxOffice,
                CustomerDesription = CustomerDesription,
                CustomerModifitedDate= DateTime.Now,

            };
            repository.Update(customer);
            return customer;
        }
    }
}
