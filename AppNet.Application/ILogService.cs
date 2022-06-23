using AppNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppServices
{
    public interface ILogService
    {
        Log Add(string LogName, string LogType);
        Task<ICollection<Log>> GetAll();
    }
}
