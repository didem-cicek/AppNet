using AppNet.AppServices;
using AppNet.Infrastructer.Persistence;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.AppService
{
    public static class ApplicationService
    {
        public static void RegisterBusinessServices(this IServiceCollection service)
        {
            service.RegisterPersistenceService();
            service.AddScoped<ICategoryService, CategoryService>();
            service.AddScoped<IProductService, ProductService>();
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<ILogService, LogService>();
            service.AddScoped<IDatabaseService, DataBaseService>();
            service.AddScoped<ICustomerService, CustomerService>();
            service.AddScoped<ISalesService, SalesService>();
            service.AddScoped<IReportService, ReportService>();
            service.AddScoped<ICashService, CashService>();
            service.AddScoped<IStockService, StockService>();
            service.AddScoped<ISupplierService, SupplierService>();
            service.AddScoped<ILogService, LogService>();
            service.AddScoped<ICashService, CashService>();
            service.AddScoped<INotificationsService, NotificationsService>();
        }
    }
}
