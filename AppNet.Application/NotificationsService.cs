using AppNet.Domain.Entities;
using AppNet.Domain.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppService
{
    public class NotificationsService : INotificationsService
    {
        private readonly IRepository<Notifications> repository;
        public NotificationsService(IRepository<Notifications> repository)
        {
            this.repository = repository;
        }
        public Notifications Add(string NotificationsName)
        {
            Notifications n = new Notifications()
            {
                NotificationsName = NotificationsName
            };
            repository.Add(n);
            return n;
        }

        public async Task<ICollection<Notifications>> GetAll()
        {
            return repository.GetAll().ToList();
        }

        async public Task<bool> Remove(int id)
        {
            await repository.Remove(id);
            return true;
        }
    }
}
