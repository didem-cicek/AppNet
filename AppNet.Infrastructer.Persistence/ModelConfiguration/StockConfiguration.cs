using AppNet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence.ModelConfiguration
{
    public class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder
                .HasMany(s => s.Sales)
                .WithOne(s => s.Stock)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(s => s.Cashes)
                .WithMany(s => s.Stock)
                .OnDelete(DeleteBehavior.Cascade);
            builder
               .HasOne(s => s.Reports)
               .WithMany(s => s.Stock)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
