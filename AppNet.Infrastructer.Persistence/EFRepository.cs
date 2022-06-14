using AppNet.Domain.Core;
using AppNet.Domain.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Infrastructer.Persistence
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ErpDbContext dbContext;
        public EFRepository(ErpDbContext dbContext)
        {
            dbContext = dbContext;
        }
        public async TEntity Add(TEntity entity)
        {
            await dbContext.AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<TEntity> GetList(Func<TEntity, bool> expression = null)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(int id, TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
