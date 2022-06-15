using AppNet.Infrastructer.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Application
{
    public class ErpContext : IErpContext
    {
        public Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity> Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity> Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<TEntity> Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
