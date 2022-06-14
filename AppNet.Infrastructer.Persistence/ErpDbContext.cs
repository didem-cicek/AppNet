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
        {if(File.Exists(filePath))
            
            {using (StreamReader reader = new StreamReader(fileStream))
            {
                while (true)
                { string satir = reader.ReadLine();
                    dbName = satir;
                    if(satir== "DataBaseName")
                        {
                            dbName = satir.Remove(3,0);
                        }
                    if(satir=="DataBaseUserName")
                        {
                            userName = satir.Remove(3,0);
                        }
                    if(satir== "DataBasePassword")
                        {
                            userPassword = satir.Remove(3,0);
                        }
                    if (satir == null) break; }
                    reader.Close(); }
                    fileStream.Close();
        
                 }
        }

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
