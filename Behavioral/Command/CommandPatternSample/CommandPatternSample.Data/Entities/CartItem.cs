using System;

namespace CommandPatternSample.Data.Entities
{
    public class CartItem : IBaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int Id { get; set; }

        public DateTime CreatedDate => DateTime.Now;

        public DateTime ModifiedDate => DateTime.Now;
    }
}
