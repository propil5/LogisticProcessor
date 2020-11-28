using LogisticProcessor.DataAccess.Common;
using LogisticProcessor.DataAccess.Services.Interfaces;
using LogisticProcessor.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogisticProcessor.DataAccess.Services
{
    public class AddressService : IAddressService
    {
        private readonly ApplicationDbContext _context = null;

        public AddressService(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(AddressDto address)
        {
            _context.AddressDto.Add(address);
            var saveResult = _context.SaveChanges();
            return saveResult == 1;
        }

        public IEnumerable<AddressDto> Get()
        {
            return _context.AddressDto;
        }

        public IEnumerable<AddressDto> GetById(int id)
        {
            return _context.AddressDto.Where(x => x.Id == id);
        }

        public bool Update(AddressDto address)
        {
            var exisitngAddress = _context.AddressDto
                .Where(x => x.Id == address.Id)
                .SingleOrDefault();


            if (exisitngAddress == null)
            {
                return false;
            }
            exisitngAddress.Name = address.Name;
            exisitngAddress.Surname = address.Surname;
            exisitngAddress.PostCode = address.PostCode;
            exisitngAddress.Street = address.Street;
            exisitngAddress.HouseNumber = address.HouseNumber;
            _context.Update(exisitngAddress);
            var saveResult = _context.SaveChanges();
            return saveResult == 1;
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
