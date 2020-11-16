using LogisticProcessor.DataAccess.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogisticProcessor.DataAccess.Models
{
    public class CompanyDto : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public AddressDto Address { get; set; }
    }
}