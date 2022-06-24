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
        public ErpDbContext(DbContextOptions opt) : base(opt)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {

            //optionbuilder.EnableDetailedErrors();
            //if (!optionbuilder.IsConfigured)
            //{
            //    //if (!string.IsNullOrEmpty(dbName)) { 
            //    //var DbConnection = "Server =.; Initial Catalog = " + dbName + "; User ID = " + userName + "; Password = " + userPassword + ";";
            //    //optionbuilder.UseSqlServer(DbConnection.ToString());


            //    //}
            optionbuilder.UseSqlServer(DbSettings.Load().ConStr);
            //}

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Stock>()
            //.HasMany(c => c.Cashes)
            //.WithOne(s => s.Stock)
            //.HasForeignKey(c => c.StockID)
            //.OnDelete(DeleteBehavior.Cascade);
            
            //modelBuilder.Entity<Cash>()
            // .HasOne(c => c.Stock)
            //.WithMany(s => s.Cashes)
            //.HasForeignKey(c => c.StockID)
            //.OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Sale>()
            .HasOne(c => c.Customer)
           .WithMany(s => s.Sales)
           .HasForeignKey(c => c.CustomerID)
           .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<Customer>()
            .HasMany(c => c.Sales)
           .WithOne(s => s.Customer)
           .HasForeignKey(c => c.CustomerID)
           .OnDelete(DeleteBehavior.NoAction);
   

           // modelBuilder.Entity<Sale>()
           //.HasMany(c => c.Reports)
           //.WithOne(s => s.Sale)
           //.HasForeignKey(c => c.SalesID)
           //.OnDelete(DeleteBehavior.Cascade);

           // modelBuilder.Entity<Report>()
           //.HasOne(c => c.Sale)
           //.WithMany(s => s.Reports)
           //.HasForeignKey(c => c.SalesID)
           //.OnDelete(DeleteBehavior.NoAction);

           // modelBuilder.Entity<Stock>()
           //.HasMany(c => c.Reports)
           //.WithOne(s => s.Stock)
           //.HasForeignKey(c => c.StockID)
           //.OnDelete(DeleteBehavior.Cascade);

           // modelBuilder.Entity<Report>()
           //.HasOne(c => c.Stock)
           //.WithMany(s => s.Reports)
           //.HasForeignKey(c => c.StockID)
           //.OnDelete(DeleteBehavior.NoAction);

           // modelBuilder.Entity<Supplier>()
           //.HasMany(c => c.Reports)
           //.WithOne(s => s.Supplier)
           //.HasForeignKey(c => c.SupplierID)
           //.OnDelete(DeleteBehavior.Cascade);

           // modelBuilder.Entity<Report>()
           //.HasOne(c => c.Supplier)
           //.WithMany(s => s.Reports)
           //.HasForeignKey(c => c.SupplierID)
           //.OnDelete(DeleteBehavior.NoAction);

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
            modelBuilder.Entity<DataBase>()
                        .HasKey(p => p.DataBaseID);
            modelBuilder.Entity<Log>()
                        .HasKey(p => p.LogID);
            modelBuilder.Entity<Notifications>()
                        .HasKey(p => p.NotificationsID);
            //var entityTypes = modelBuilder.Model
            //.GetEntityTypes()
            //.ToList();
            //var foreignKeys = entityTypes
            //.SelectMany(e => e.GetForeignKeys().Where(f => f.DeleteBehavior == DeleteBehavior.Cascade));
            //foreach (var foreignKey in foreignKeys)
            //{
            //    foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            //}

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
        public DbSet<DataBase> DataBases { get; set; }
        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<Log> Logs { get; set; }

    }
}
