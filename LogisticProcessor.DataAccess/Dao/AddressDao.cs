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
        private readonly ApplicationDbContext _context = null;

        public AddressDao(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<AddressDto> Get()
        {
            return _context.AddressDto;
        }

        public IEnumerable<AddressDto> GetById(int id)
        {
            return _context.AddressDto.Where(x => x.Id == id);
        }

        void  Delete(AddressDto entity)
        {
            throw new NotImplementedException();
        }

        AddressDto Save(AddressDto entity)
        {
            throw new NotImplementedException();
        }

        void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
