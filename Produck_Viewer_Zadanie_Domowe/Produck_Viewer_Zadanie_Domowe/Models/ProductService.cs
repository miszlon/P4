using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produck_Viewer_Zadanie_Domowe.Models
{
    public class ProductService
    {
        public IReadOnlyList<Product> Products => new[]
        {
            new Product("Working Hands Hand Cream", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1550084872-51GCsH1dKyL.jpg", "Dry hands are nobody's friend. This hydrating cream, on the other hand, is. Massage it into dry, cracked skin for an instant moisture boost. \"It's a miracle products for the winter,\" says one Amazon reviewer.", 7.29m, ProductCategory.Beauty, "amazon.com"),
            new Product("All-Season Quilted Comforter", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1550162581-51OaOXJEwfL.jpg", "It's what's on the inside that counts: Fill your favorite duvet cover with this quilted microfiber comforter, which is packed with a  hypoallergenic down alternative. It'll keep you warm — but not too warm — all year long.", 26.99m, ProductCategory.Home, "amazon.com"),
            new Product("Silicone Baking Mat", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1550087229-silicone-mat-best-selling-amazon-products-1550087211.jpg", "Forget aluminum foil: These non-stick silicone baking mats cut down on cooking and baking clean-up time, plus you don't waste oil or greasing spray. \"My cookies came out better — crunchy on the outside and soft on the inside,\" says one Amazon reviewer.", 13.99m, ProductCategory.Home, "amazon.com"),
            new Product("Watch Hat Beanie", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1581631464-best-selling-amazon-products-carhart-beanie-1581631436.png", "This classic beanie keeps your head warm and won't fall off. It comes in 24 colors and is a one-size fits all. While reviewers with bigger heads say the hat fits perfectly, other reviewers like the slouch it gives.", 14.99m, ProductCategory.Fashion, "amazon.com"),
            new Product("Indian Healing Clay", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1550873244-51gXDkDm3EL.jpg", "Clay masks, like this Calcium Bentonite Clay version from Aztec Secret, purify your skin from the inside out by clearing even the deepest of pores.", 12.17m, ProductCategory.Beauty, "amazon.com"),
            new Product("Mind & Body Candle", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1550091811-candle-best-selling-amazon-products-1550091790.jpg", "We're all for splurging on self-care (read: candles). But we also think that the best way to care for yourself is to score a good deal without leaving your house. Enter this affordable candle with a 70-hour burn time.", 14.99m, ProductCategory.Home, "amazon.com")
        };
    }
}
