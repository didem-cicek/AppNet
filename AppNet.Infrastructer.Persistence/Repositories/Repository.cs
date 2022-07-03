using AppNet.Domain.Core;
using AppNet.Domain.Entities;
using AppNet.Domain.InterFaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ErpDbContext context;
        public Repository(ErpDbContext context)
        {
            this.context = context;
        }
        public async Task<TEntity> Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
            return entity;
        }

        public IQueryable<TEntity> GetAll()
        {
            return context.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> GetById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public async Task<bool> Remove(int id)
        {
            var entity = context.Set<TEntity>().Find(id);
             if (entity == null)
             return false;

            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
            return true;
        }

        public async Task<TEntity> Update(int id, TEntity entity)
        {           
            
            try
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
            return entity;
        }
        //public async Task<TEntity> Filter(int id, TEntity entity)
        //{
        //    context.Set<TEntity>().Find(id, entity);
        //    return entity;
        //}
    }
}
