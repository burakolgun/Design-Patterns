using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPatternSample.Data.Entities
{
    public interface IBaseEntity
    {
        int Id { get; }

        DateTime CreatedDate { get; }

        DateTime ModifiedDate { get; }
    }
}
