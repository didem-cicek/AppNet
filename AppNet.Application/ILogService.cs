using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppServices
{
    public interface ILogService
    {
        void Create(int ID, string LogName, string LogType);
        IReadOnlyCollection<LogService> GetAll();
    }
}
