using AppNet.Domain.Entities;
using AppNet.Domain.InterFaces;
using AppNet.Infrastructer.Persistence;
using Microsoft.EntityFrameworkCore;
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
        User Update(int ID, string newPassword);
        IReadOnlyCollection<User> GetAll();
    }
}
