using System;

namespace CommandPatternSample.Data.Entities
{
    public class Cart : IBaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedDate => DateTime.Now;

        public DateTime ModifiedDate => DateTime.Now;

        public int Quantity { get; set; }

        public CartItem Item { get; set; }
    }
}
