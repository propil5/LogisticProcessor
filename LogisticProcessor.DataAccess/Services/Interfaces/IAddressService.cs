using LogisticProcessor.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticProcessor.DataAccess.Services.Interfaces
{
    public interface IAddressService
    {
        bool Add(AddressDto address);
        IEnumerable<AddressDto> Get();
        IEnumerable<AddressDto> GetById(int id);
        bool Update(AddressDto address);
        bool Delete(int id);

    }
}
