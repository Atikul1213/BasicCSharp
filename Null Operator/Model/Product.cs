using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Operator.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; } = 10;
        public string Unit { get; set; }
        public string  ProductType { get; set; }

        public bool isSell { get; } = true;

        public Product RelatedProduct { get; set; }
    }
}
