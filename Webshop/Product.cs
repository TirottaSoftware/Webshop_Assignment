using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public ProductType Type { get; set; }
        public override string ToString()
        {
            return $"Name: {this.Name}, Type: {this.Type}, Price: {this.Price}, Stock: {this.Stock}";
        }
    }
}
