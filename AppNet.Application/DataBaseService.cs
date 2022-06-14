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
        public void Create(int ID, string databaseName, string userName, string password)
        {
            DataBase dataBase = new DataBase();
            dataBase.DataBaseID = ID;
            dataBase.DataBaseName = databaseName;
            dataBase.DataBaseUserName = userName;
            dataBase.DataBasePassword = password;
            databaseRepository.Add(dataBase);
        }

        public bool Delete(int databaseID)
        {
            return databaseRepository.Remove(databaseID);
        }

        public IReadOnlyCollection<DataBase> GetAll()
        {
            return databaseRepository.GetList().ToList().AsReadOnly();
        }

        public DataBase Update(int databaseID, string newDataBaseName, string newUserName, string newPassword)
        {
            DataBase dataBase = new DataBase();
            dataBase.DataBaseID = databaseID;
            dataBase.DataBaseName = newDataBaseName;
            dataBase.DataBaseUserName = newUserName;
            dataBase.DataBasePassword = newPassword;
            return databaseRepository.Update(databaseID, dataBase);
        }

    }
}
