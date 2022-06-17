using AppNet.AppService;
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
    public class ApplicationServiceSettings
    {
        public static void RegisterAllService()
        {
            IOCContainer.Register<IDatabaseService>(() => new DataBaseService());
            IOCContainer.Register<IUserService>(() => new UserService());
            IOCContainer.Register<ILogService>(() => new LogService());
            IOCContainer.Register<IUserService>(() => new UserService());
            IOCContainer.Register<ICategoryService>(() => new CategoryService());
            IOCContainer.Register<IProductService>(() => new ProductService());
            IOCContainer.Register<IRepository<DataBase>>(() => new EFRepository<DataBase>(new AppNet.Infrastructer.Persistence.ErpDbContext()));
            IOCContainer.Register<IRepository<Log>>(() => new EFRepository<Log>(new AppNet.Infrastructer.Persistence.ErpDbContext()));
            IOCContainer.Register<IRepository<User>>(() => new EFRepository<User>(new AppNet.Infrastructer.Persistence.ErpDbContext()));
            IOCContainer.Register<IRepository<Category>>(() => new EFRepository<Category>(new AppNet.Infrastructer.Persistence.ErpDbContext()));
            IOCContainer.Register<IRepository<Product>>(() => new EFRepository<Product>(new AppNet.Infrastructer.Persistence.ErpDbContext()));
        }
    }
}
