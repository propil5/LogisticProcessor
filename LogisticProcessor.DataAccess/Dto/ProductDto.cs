using System;
using System.ComponentModel.DataAnnotations.Schema;
using LogisticProcessor.DataAccess.Common;

namespace LogisticProcessor.DataAccess.Models
{
    public class ProductDto : BaseEntity
    {
        public string Name { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int Priority { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        [ForeignKey("Pallet")]
        public int PalletId { get; set; }
        public PalletDto Pallet { get; set; }
    }
}
