using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticProcessor.Web.Shared.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int Priority { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
    }
}
