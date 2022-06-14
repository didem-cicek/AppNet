using AppNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppServices
{
    public interface IUserService
    {
        void Create(int ID, string Name, string UserName, string Password, string UserAuthorization );
        bool Delete(int ID);
        DataBase Update(int ID, string newPassword);
        IReadOnlyCollection<User> GetAll();
    }
}
