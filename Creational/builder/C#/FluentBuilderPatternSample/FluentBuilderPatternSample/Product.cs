namespace BuilderPatternSample
{
    public class Product
    {
        public string Id { get; set; }
        public string ProductContentId { get; set; }
        public string Sku{ get; set; }
        public int Quantity { get; set; }
        public Variant Variant { get; set; }
        public Merchant Merchant { get; set; }
        public Price Price { get; set; }
    }
}