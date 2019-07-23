using System;

namespace Proxy.Entity
{
    public class User : IBaseEntity
    {
        public string Id { get; set; }
        public DateTime? CreatedAt => DateTime.Now;
        public DateTime? ModifiedAt { get; set; }
        public bool IsDeleted => false;
        public int Age { get; set; }
        public string Address { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
