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
        IRepository<User> userRepository;
        public UserService()
        {
            userRepository = IOCContainer.Resolve<IRepository<User>>();
        }
        public void Create(int ID, string Name, string UserName, string Password, string UserAuthorization)
        {
            User u = new User();
            u.UserID = ID;
            u.Name = Name;
            u.UserName = UserName;
            u.Password = Password;
            u.UserAuthorization = UserAuthorization;
            userRepository.Add(u);
        }

        public bool Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public DataBase Update(int ID, string newPassword)
        {
            throw new NotImplementedException();
        }
    }
}
