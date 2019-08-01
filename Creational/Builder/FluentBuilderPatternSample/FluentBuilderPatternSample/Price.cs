namespace BuilderPatternSample
{
    public class Price
    {
        public decimal OriginalPrice { get; set; }
        public decimal DiscountedPrice { get; set; }
        public decimal MarketPrice { get; set; }
        public int TaxRate { get; set; }
    }
}