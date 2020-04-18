using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produck_Viewer_Zadanie_Domowe.Models
{
    public class ProductsOnSale
    {
        public string Name { get; set; }
        public decimal Promocja { get; set; }
        public int IloscWyaganaDoPromocji { get; set; }

        public ProductsOnSale(string name, decimal promocja, int iloscWymaganaDoPromocji)
        {
            Name = name;
            Promocja = promocja;
            IloscWyaganaDoPromocji = iloscWymaganaDoPromocji;
        }
        public static IReadOnlyList<ProductsOnSale> ProductOnSale => new[]
        {
            new ProductsOnSale("Silicone Baking Mat", 0.10m, 2),
            new ProductsOnSale("Mind & Body Candle", 0.15m, 3)
        };
    }
}
