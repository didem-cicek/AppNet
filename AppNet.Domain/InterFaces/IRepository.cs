using AppNet.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.InterFaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity Add(TEntity entity);
        bool Remove(int id);
        TEntity GetById(int id);
        ICollection<TEntity> GetList(Func<TEntity, bool> expression = null);
        TEntity Update(int id, TEntity entity);
    }
}
