using System;

namespace BuilderPatternSample
{
    public class BasketBuilder : IBasketBuilder, IProductPriceBuilder, IProductMerchantBuilder, IProductVariantBuilder
    {
        private readonly Basket _basket = new Basket()
        {
            Product = new Product()
            {
                Id = Guid.NewGuid().ToString("D"),
                Quantity = 5,
                ProductContentId = Guid.NewGuid().ToString("D"),
                Sku = Guid.NewGuid().ToString("N")
            }
        };

        public BasketBuilder UsePrice()
        {

            _basket.Product.Price = new Price()
            {
                DiscountedPrice = 10.52m,
                MarketPrice = 100.86m,
                OriginalPrice = 120.842m,
                TaxRate = 18
            };
            return this;
        }

        public BasketBuilder UseMerchant()
        {
            _basket.Product.Merchant = new Merchant()
            {
                Id = Guid.NewGuid().ToString("D"),
                Address = "Test Address",
                Email = "test@asd.com",
                Tax = "352100"
            };

            return this;
        }

        public BasketBuilder UseVariant()
        {
            _basket.Product.Variant = new Variant()
            {
                Color = "Test",
                Gender = "Male",
                Size = "45"
            };

            return this;
        }

        public Basket Build() => _basket;
    }
}