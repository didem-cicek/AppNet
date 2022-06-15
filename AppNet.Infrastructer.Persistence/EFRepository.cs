using AppNet.Domain.Core;
using AppNet.Domain.InterFaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        public ErpDbContext context;
        public DbSet<TEntity> dbSet;
        public EFRepository(ErpDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        async Task<TEntity> IRepository<TEntity>.Add(TEntity entity)
        {
                await context.AddAsync(entity);
                await context.SaveChangesAsync();
                return entity;
        }

        Task<TEntity> IRepository<TEntity>.GetById(int id)
        {
            using (var context = new ErpDbContext())
            {
                throw new NotImplementedException();
            }
        }

        Task<ICollection<TEntity>> IRepository<TEntity>.GetList(Func<TEntity, bool> expression)
        {
            using (var context = new ErpDbContext())
            {
                throw new NotImplementedException();
            }
        }

        Task<bool> IRepository<TEntity>.Remove(int id)
        {
            using (var context = new ErpDbContext())
            {
                throw new NotImplementedException();
            }
        }

        Task<TEntity> IRepository<TEntity>.Update(int id, TEntity entity)
        {
            using (var context = new ErpDbContext())
            {
                throw new NotImplementedException();
            }
        }
    }
}
