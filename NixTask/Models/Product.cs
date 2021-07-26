using NixTask.Interfaces;
using System.Collections.Generic;

namespace NixTask.Models
{
    public class ProductBase : IMain
    {
        public static int MaxID = 0;
        public static List<Product> Products = new List<Product>();
        public void Delete(int ID)
        {
            foreach (Product product in ProductBase.Products)
                if (product.ID == ID)
                    ProductBase.Products.Remove(product);
        }
    }
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            ID = ProductBase.MaxID++;
            ProductBase.Products.Add(this);
        }
    }
}
