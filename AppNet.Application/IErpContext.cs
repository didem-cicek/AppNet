using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Application
{
    public interface IErpContext
    {
        EntityEntry<TEntity> Add(TEntity entity);
        EntityEntry<TEntity> Delete(TEntity entity);
        EntityEntry<TEntity> Update(TEntity entity);
        EntityEntry<TEntity> Add(TEntity entity);
    }
}
