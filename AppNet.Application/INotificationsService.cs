using AppNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppService
{
    public interface INotificationsService
    {
        Notifications Add(string NotificationsName);
        Task<ICollection<Notifications>> GetAll();
        Task<bool> Remove(int id);
    }
}
