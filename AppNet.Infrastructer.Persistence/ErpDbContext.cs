using AppNet.Domain.Core;
using AppNet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence
{
    public class ErpDbContext : DbContext
    {
        public string dbName { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        private const string filePath = "AppNet-Domain-Entities-DataBase" + ".txt";
        FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        public void LoadDataBase()
        {if (File.Exists(filePath))

            { using (StreamReader reader = new StreamReader(fileStream))
                {
                    while (true)
                    { string satir = reader.ReadLine();
                        string d = satir.Remove(0, 33);
                        int pos = d.IndexOf(",");
                        dbName = d.Substring(0, pos-1);
                        userName = d.Remove(0, dbName.Length + 22);
                        int us = userName.IndexOf(",");
                        userName = userName.Substring(0, us - 1);
                        userPassword = d.Remove(0, dbName.Length + 46);
                        int p = userPassword.IndexOf(",");
                        userPassword = userPassword.Substring(0, p - 1);

                        //userPassword = satir.Trim('","DataBasePassword":"');
                        break;

                        reader.Close(); }
                    fileStream.Close();

                }
            }
        }

    protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            LoadDataBase();
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
            modelBuilder.Entity<Product>()
                        .HasKey(p => p.ProductID);
            modelBuilder.Entity<Category>()
                        .HasKey(p => p.CategoryId);
            modelBuilder.Entity<Customer>()
                        .HasKey(p => p.CustomerID);
            modelBuilder.Entity<Cash>()
                        .HasKey(p => p.CashID);
            modelBuilder.Entity<Log>()
                        .HasKey(p => p.LogID);
            modelBuilder.Entity<Report>()
                        .HasKey(p => p.ReportID);
            modelBuilder.Entity<Sale>()
                        .HasKey(p => p.SaleID);
            modelBuilder.Entity<Stock>()
                        .HasKey(p => p.StockID);
            modelBuilder.Entity<Supplier>()
                        .HasKey(p => p.SupplierID);
            modelBuilder.Entity<User>()
                        .HasKey(p => p.UserID);
            var entityTypes = modelBuilder.Model
            .GetEntityTypes()
            .ToList();
            var foreignKeys = entityTypes
            .SelectMany(e => e.GetForeignKeys().Where(f => f.DeleteBehavior == DeleteBehavior.Cascade));
            foreach (var foreignKey in foreignKeys)
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }

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
