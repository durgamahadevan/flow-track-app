using FlowTrack.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowTrack.Domain.ValueObjects
{
    public sealed record TenantId
    {
        public Guid Value { get; }

        private TenantId(Guid id)
        {
            Value = id;
        }

        public static TenantId New() => new TenantId(Guid.NewGuid());

        public static TenantId From(Guid guid)
        {
            if (guid == Guid.Empty) throw new DomainException("TenantId cannot be empty.");
            return new TenantId(guid);
        }

        public override string ToString() => Value.ToString();

    }
}
