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
        void Create(string databaseName, string userName, string password);
        Task<ICollection<DataBase>> GetList();
    }
}
