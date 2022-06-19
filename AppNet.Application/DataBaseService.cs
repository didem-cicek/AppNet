using AppNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppNet.Infrastructer.Persistence;
using AppNet.Domain.InterFaces;

namespace AppNet.AppServices
{
    public class DataBaseService : IDatabaseService
    {
        private readonly IRepository<DataBase> repository;
        public DataBaseService(IRepository<DataBase> repository)
        {
            this.repository = repository;
        }

        public DataBase Add(string databaseName, string userName, string password)
        {
            DataBase db = new DataBase()
            {
                DataBaseName = databaseName,
                DataBaseUserName = userName,
                DataBasePassword = password
            };
            repository.Add(db);
            return db;
        }

        async public Task<ICollection<DataBase>> GetList()
        {
            return repository.GetAll().ToList();
        }
    }
}
