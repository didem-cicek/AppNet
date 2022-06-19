using AppNet.Domain.Core;
using AppNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.InterFaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> Add(TEntity entity);
        Task<bool> Remove(int id);
        Task<TEntity> GetById(int id);
        IQueryable<TEntity> GetAll();
        //IQueryable<TEntity> GetList(Func<TEntity, bool> expression = null);
        Task<TEntity> Update(int id, TEntity entity);
    }
}
