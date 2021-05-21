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
        public Product()
        {

        }
        public Product(string name, double price, int stock, ProductType type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
            this.Stock = stock;
        }
        public override string ToString()
        {
            return $"Name: {this.Name}, Type: {this.Type}, Price: {this.Price}, Stock: {this.Stock}";
        }
    }
}
