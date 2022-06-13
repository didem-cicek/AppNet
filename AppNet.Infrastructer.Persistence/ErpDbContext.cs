using AppNet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence
{
    public class ErpDbContext : DbContext
    {
        public string dbName { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.EnableDetailedErrors();
            if (!optionbuilder.IsConfigured)
            {
                var DbConnection = "Server =.; Initial Catalog = " + dbName + "; User ID = " + userName + "; Password = " + userPassword + ";";
                optionbuilder.UseSqlServer(DbConnection.ToString());

            }
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet <Sale> Sales { get; set; }
        public DbSet<Cash> Cashs { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Report> Reports { get; set; }
         
        
    }
}
