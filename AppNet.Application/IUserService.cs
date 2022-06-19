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
        User Add(string Name, string UserName, string Password, string UserAuthorization);
        Task<User> Update(int ID, string Name, string UserName, string Password, string UserAuthorization);
        Task<bool> Remove(int id);
        Task<ICollection<User>> GetAll();
    }
}
