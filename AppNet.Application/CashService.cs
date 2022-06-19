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
        public Cash Add(int SaleID, int StockID)
        {
            Cash cash = new Cash()
            {
                SaleID = SaleID,
                StockID = StockID,
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

        public async Task<Cash> Update(int CashID, int SaleID, int StockID)
        {
            Cash cash = new Cash()
            {
                CashID = CashID,
                SaleID = SaleID,
                StockID = StockID,
                CashModifitedDate = DateTime.Now,

            };
            repository.Update(CashID, cash);
            return cash;
        }
    }
}
