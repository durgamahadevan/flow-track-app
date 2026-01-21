using FlowTrack.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowTrack.Domain.ValueObjects
{
    public sealed record UserId
    {
        public Guid Value { get; }
        private UserId(Guid value)
        {
            Value = value;
        }

        public static UserId New() => new UserId(Guid.NewGuid());

        public static UserId From(Guid value)
        {
            if (value == Guid.Empty) throw new DomainException("UserId cannot be empty");
            return new UserId(value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
