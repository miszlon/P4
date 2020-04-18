using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produck_Viewer_Zadanie_Domowe.Models
{
    public class ProductsInBasket
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Ilosc { get; set; }
        public ProductCategory Kategoria { get; set; }

        public ProductsInBasket(string name, decimal price, int ilosc, ProductCategory kategoria)
        {
            Name = name;
            Price = price;
            Ilosc = ilosc;
            Kategoria = kategoria;
        }

        public ProductsInBasket()
        {
        }
    }
}
