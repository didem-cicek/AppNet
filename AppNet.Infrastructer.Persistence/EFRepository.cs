using AppNet.Domain.Core;
using AppNet.Domain.Entities;
using AppNet.Domain.InterFaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ErpDbContext context;
        public EFRepository(ErpDbContext context) : base()
        {
            this.context = context;
        }
        async Task<TEntity> IRepository<TEntity>.Add(TEntity entity)
        {
                await context.AddAsync(entity);
                await context.SaveChangesAsync();
                return entity;
        }

        public async Task<TEntity> GetById(int id)
        {
            return await context.Set<TEntity>()
                        .AsNoTracking()
                        .FirstOrDefaultAsync(e => e.Id == id);
        }
        async public Task Remove(int id)
        {
            var entity = await GetById(id);
            context.Set<TEntity>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetList()
        {
            return context.Set<TEntity>().AsNoTracking();
        }
        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> where)
        {
            return context.Set<TEntity>().AsNoTracking().Where(where);
        }

        async Task<TEntity> IRepository<TEntity>.Update(int id, TEntity entity)
        {
            context.Set<TEntity>().Update(entity);
            await context.SaveChangesAsync();
            return entity;
        }
    }
}
