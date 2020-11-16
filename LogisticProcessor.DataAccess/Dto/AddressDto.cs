using LogisticProcessor.DataAccess.Common;

namespace LogisticProcessor.DataAccess.Models
{
    public class AddressDto : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public string HouseNumber { get; set; }
    }
}