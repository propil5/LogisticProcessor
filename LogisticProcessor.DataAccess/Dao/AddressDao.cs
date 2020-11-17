using LogisticProcessor.DataAccess.Common;
using LogisticProcessor.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticProcessor.DataAccess.Dao
{
    public class AddressDao : IDao<AddressDto>
    {
        private ApplicationDbContext _context = null;

        public AddressDao()
        {
            ResetContext();
        }

        private void ResetContext()
        {
            _context = new ApplicationDbContext().CreateDbContext(null);
        }

        public IEnumerable<AddressDto> Get(int? id = null)
        {
            throw new NotImplementedException();
        }

        void IDao<AddressDto>.Delete(AddressDto entity)
        {
            throw new NotImplementedException();
        }

        AddressDto IDao<AddressDto>.Save(AddressDto entity)
        {
            throw new NotImplementedException();
        }

        void IDao<AddressDto>.SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
