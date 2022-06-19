using AppNet.Domain.InterFaces;
using AppNet.Infrastructer.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence
{
    public static class AddBusinessServices
    {
        public static void RegisterPersistenceService(this IServiceCollection services)
        {
            services.AddDbContext<ErpDbContext>(opt =>
            opt.UseSqlServer(DbSettings.Load().ConStr));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
