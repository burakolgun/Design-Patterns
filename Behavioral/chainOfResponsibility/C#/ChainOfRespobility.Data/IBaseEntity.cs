using System;

namespace ChainOfRespobility.Data
{
    public interface IBaseEntity
    {
        Guid Id { get; }

        DateTime CreatedAt { get; }

        DateTime ModifiedAt { get; }

    }
}
