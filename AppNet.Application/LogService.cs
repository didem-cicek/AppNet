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
        private readonly IRepository<Log> repository;
        public LogService(IRepository<Log> repository)
        {
            this.repository = repository;
        }
        public Log Add(int ID, string LogName, string LogType)
        {
            Log log = new Log()
            {
                LogID = ID,
                LogName = LogName,
                LogType = LogType,
                LogDate = DateTime.Now,
            };
            repository.Add(log);
            return log;
        }

        async Task<ICollection<Log>> ILogService.GetAll()
        {
            return repository.GetAll().ToList();
        }
    }
}
