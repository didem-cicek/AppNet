using AppNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppServices
{
    public interface IDatabaseService
    {
        void Create(int ID, string databaseName, string userName, string password);
        bool Delete(int databaseID);
        DataBase Update(int databaseID, string newDataBaseName, string newUserName, string newPassword);
        IReadOnlyCollection<DataBase> GetAll();
    }
}
