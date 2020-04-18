using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produck_Viewer_Zadanie_Domowe.Models
{
    public enum ProductCategory
    {
        Fashion,
        Beauty,
        Home
    }

    public class Product
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ProductCategory Category { get; set; }
        public string Source { get; set; }

        public Product(string name, string imageUrl, string description, decimal price, ProductCategory category, string source)
        {
            Name = name;
            ImageUrl = imageUrl;
            Description = description;
            Price = price;
            Category = category;
            Source = source;
        }

    }
}
