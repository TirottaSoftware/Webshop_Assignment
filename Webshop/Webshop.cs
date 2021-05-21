using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    public class Webshop
    {
        private List<Product> products;

        public delegate void AddProductEventHandler(object src, ProductEventArgs args);
        public event AddProductEventHandler ProductAdded;

        public Webshop()
        {
            this.products = new List<Product>();
        }
        public void AddProduct(string name, double price, ProductType type, int stock)
        {
            //Check duplicate names
            if (this.products.Any(x=>x.Name == name))
            {
                throw new ArgumentException($"product {name} already in the list");
            }
            Product p = new Product() { Name = name, Price = price, Type = type, Stock = stock };
            this.products.Add(p);

            if (ProductAdded != null)
            {
                ProductAdded(this, new ProductEventArgs() { Product = p });
            }
        }
        public void UpdateProduct(Product oldProduct, Product newProduct)
        {
            //TODO: Implement UpdateProduct functionality
        }
        public List<Product> GetProducts() => this.products.ToList();
    }
}
