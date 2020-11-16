using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticProcessor.Web.Shared.Models
{
    public class ProductDetails : Product
    {
        public double Price { get; set; }
        public int Discount { get; set; }
        public DateTime BBEDate { get; set; }
        public int PriorityType { get; set; }

    }
}
