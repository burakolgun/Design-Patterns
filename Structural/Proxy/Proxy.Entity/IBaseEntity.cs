using System;

namespace Proxy.Entity
{
    public interface IBaseEntity
    {
        string Id { get; }
        DateTime? CreatedAt { get; }
        DateTime? ModifiedAt { get; }
        bool IsDeleted { get; }
    }
}