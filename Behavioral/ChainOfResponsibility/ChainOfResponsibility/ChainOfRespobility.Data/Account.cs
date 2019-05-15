using ChainOfRespobility.Data.Enums;
using System;

namespace ChainOfRespobility.Data
{
    public class Account : IBaseEntity
    {
        public Guid Id => Guid.NewGuid();

        public DateTime CreatedAt => DateTime.Now;

        public DateTime ModifiedAt => DateTime.Now;

        public string FirstName{ get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public BankCreditRequestEnum BankCreditRequestEnum { get; set; }
    }
}
