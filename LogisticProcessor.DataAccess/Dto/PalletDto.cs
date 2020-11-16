using LogisticProcessor.DataAccess.Common;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogisticProcessor.DataAccess.Models
{
    public class PalletDto : BaseEntity
    {
        [ForeignKey ("Owner")]
        public int? OwnerId { get; set; }
        public CompanyDto Owner { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DispacheTime { get; set; }
    }
}