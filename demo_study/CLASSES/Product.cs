using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_study.CLASSES
{
    public class Product
    {
        public string Article { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public decimal Cost { get; set; }
        public int DiscountAmount { get; set; }
        public string Manufacturer { get; set; }
        public string Supplier { get; set; }
        public string Category { get; set; }
        public int CurrentDiscount { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
    }
}
