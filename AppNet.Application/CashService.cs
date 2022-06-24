using AppNet.Domain.Entities;
using AppNet.Domain.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppService
{
    public class CashService : ICashService
    {
        private readonly IRepository<Cash> repository;
        public CashService(IRepository<Cash> repository)
        {
            this.repository = repository;
        }
        public Cash Add(decimal Debt, decimal Receivable, decimal TotalCash)
        {
            Cash cash = new Cash()
            {
                Debt = Debt,
                Receivable = Receivable,
                TotalCash = TotalCash,
                CashDate = DateTime.Now,

            };
            repository.Add(cash);
            return cash;
        }

        public async Task<ICollection<Cash>> GetAll()
        {
            return repository.GetAll().ToList();
        }

        public async Task<bool> Remove(int id)
        {
            await repository.Remove(id);
            return true;
        }

        public async Task<Cash> Update(int CashID, decimal Debt, decimal Receivable, decimal TotalCash)
        {
            Cash cash = new Cash()
            {
                CashID = CashID,
                Debt = Debt,
                Receivable = Receivable,
                TotalCash =TotalCash,
                CashModifitedDate = DateTime.Now,

            };
            repository.Update(CashID, cash);
            return cash;
        }
    }
}
