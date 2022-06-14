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
    public class LogService : ILogService
    {
        IRepository<Log> logRepository;
        public LogService()
        {
            logRepository = IOCContainer.Resolve<IRepository<Log>>();
        }
        public void Create(int ID, string LogName, string LogType)
        {
            Log log = new Log();
            log.LogID = ID;
            log.LogName = LogName;
            log.LogType = LogType;
            logRepository.Add(log);
        }

        public IReadOnlyCollection<LogService> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
