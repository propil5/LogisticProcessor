using LogisticProcessor.DataAccess.Common;
using LogisticProcessor.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public bool Delete(int id)
        {
            var deleted = false;
            var employee = _context.AddressDto
                .Where(x => x.Id == id)
                .SingleOrDefault();

            if (employee != null)
            {
                _context.Remove(employee);
                deleted = true;
            }
            else
            {
                deleted = false;
            }

            var saveResult = _context.SaveChanges();
            return saveResult == 1 && deleted == true;
        }
    }
}
