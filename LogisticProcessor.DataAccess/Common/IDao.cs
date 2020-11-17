using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticProcessor.DataAccess.Common
{
    public interface IDao<TEntity>
    {
        IEnumerable<TEntity> Get(int? id = null);
        TEntity Save(TEntity entity);
        void Delete(TEntity entity);
        void SaveChanges();
    }
}
