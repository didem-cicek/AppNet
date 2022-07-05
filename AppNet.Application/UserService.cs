using AppNet.Domain.Entities;
using AppNet.Domain.InterFaces;
using AppNet.Infrastructer.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppServices
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> repository;
        public UserService(IRepository<User> repository)
        {
            this.repository = repository;
        }

        public User Add(string Name, string UserName, string Password, string UserAuthorization)
        {
            User user = new User()
            {
                Name = Name,
                UserName = UserName,
                Password = Password,
                UserAuthorization = UserAuthorization,
                UserDate = DateTime.Now,
            };
            repository.Add(user);
            return user;
        }


        public async Task<bool> Remove(int id)
        {
            await repository.Remove(id);
            return true;
        }

        public async Task<User> Update(int ID, string Name, string UserName, string Password, string UserAuthorization)
        {
            User user = new User()
            {
                UserID = ID,
                Name = Name,
                UserName = UserName,
                Password = Password,
                UserAuthorization = UserAuthorization,
                UserModifitedDate = DateTime.Now
            };
            repository.Update(user);
            return user;
        }

        async Task<ICollection<User>> IUserService.GetAll()
        {
            return repository.GetAll().ToList();
        }
    }
}
