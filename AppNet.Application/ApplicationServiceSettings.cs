using AppNet.Application;
using AppNet.Domain.Entities;
using AppNet.Domain.InterFaces;
using AppNet.Infrastructer.Logging;
using AppNet.Infrastructer.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppServices
{
    public class ApplicationServiceSettings
    {
        public static void RegisterAllService()
        {
            IOCContainer.Register<IDatabaseService>(() => new DataBaseService());
            IOCContainer.Register<IUserService>(() => new UserService());
            IOCContainer.Register<ILogService>(() => new LogService());
            IOCContainer.Register<IRepository<DataBase>>(() => new TextFileRepository<DataBase>());
            IOCContainer.Register<IRepository<Log>>(() => new TextFileRepository<Log>());
            IOCContainer.Register<IRepository<User>>(() => new EFRepository<User>(ErpContext));
            IOCContainer.Register<ErpContext>(() => new ErpContext());




        }
    }
}
