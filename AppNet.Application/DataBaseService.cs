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
        IRepository<DataBase> databaseRepository;
        public DataBaseService()
        {
            databaseRepository = IOCContainer.Resolve<IRepository<DataBase>>();
        }
        public void Create(string databaseName, string userName, string password)
        {
            DataBase dataBase = new DataBase();
            dataBase.DataBaseName = databaseName;
            dataBase.DataBaseUserName = userName;
            dataBase.DataBasePassword = password;
            databaseRepository.Add(dataBase);
        }

        async public Task<ICollection<DataBase>> GetList()
        {
            return databaseRepository.GetList().ToList();
        }
    }
}
