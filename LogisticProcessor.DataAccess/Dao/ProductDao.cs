using LogisticProcessor.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticProcessor.DataAccess.Dao
{
    public class ProductDao
    {
        private readonly ApplicationDbContext _context = null;

        public ProductDao(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(ProductDto product)
        {
            _context.AddressDto.Add(address);
            var saveResult = _context.SaveChanges();
            return saveResult == 1;
        }

        public IEnumerable<AddressDto> Get()
        {
            return _context.ProductDto;
        }

        public IEnumerable<ProductDto> GetById(int id)
        {
            return _context.ProductDto.Where(x => x.Id == id);
        }

        public bool Update(ProductDto product)
        {
            var exisitngProduct = _context.ProductDto
                .Where(x => x.Id == product.Id)
                .SingleOrDefault();


            if (exisitngProduct == null)
            {
                return false;
            }
            exisitngProduct. = address.Name;
            exisitngProduct.Surname = address.Surname;
            exisitngProduct.PostCode = address.PostCode;
            exisitngProduct.Street = address.Street;
            exisitngProduct.HouseNumber = address.HouseNumber;
            _context.Update(exisitngProduct);
            var saveResult = _context.SaveChanges();
            return saveResult == 1;
        }

        public bool Delete(int id)
        {
            var deleted = false;
            var product = _context.ProductDto
                .Where(x => x.Id == id)
                .SingleOrDefault();

            if (product != null)
            {
                _context.Remove(product);
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
