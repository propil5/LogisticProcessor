using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticProcessor.DataAccess.Common
{
    public interface IDao<TEntity>
    {
        IEnumerable<TEntity> Add(TEntity entity);
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> GetById(int id);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
