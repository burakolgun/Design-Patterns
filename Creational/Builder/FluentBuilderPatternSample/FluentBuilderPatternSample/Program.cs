using System;

namespace BuilderPatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Basket basket = new BasketBuilder()
                .UseMerchant()
                .UsePrice()
                .UseVariant()
                .Build();

            Console.WriteLine("---- Info ----");
            Console.WriteLine($"{basket.Product.Id} - {basket.Product.ProductContentId} - {basket.Product.Quantity} - {basket.Product.Sku}");

            Console.WriteLine("---- Merchant ----");
            Console.WriteLine($"{basket.Product.Merchant.Id} - {basket.Product.Merchant.Address}");


            Console.WriteLine("---- Price ----");
            Console.WriteLine($"{basket.Product.Price.OriginalPrice} - {basket.Product.Price.MarketPrice} - {basket.Product.Price.DiscountedPrice}");

            Console.WriteLine("---- Variant ----");
            Console.WriteLine($"{basket.Product.Variant.Color} - {basket.Product.Variant.Gender} - {basket.Product.Variant.Size}\n\n");

            Console.Write("--- Enter key to exit ---\n");
            Console.Read();

        }
    }
}
