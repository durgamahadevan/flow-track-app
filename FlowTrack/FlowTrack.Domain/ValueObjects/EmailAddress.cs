using FlowTrack.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowTrack.Domain.ValueObjects
{
    public sealed record EmailAddress
    {
        public string Value {  get; }

        private EmailAddress(string value)
        {
            Value = value;
        }

        public static EmailAddress Create(string value)
        {
            if (string.IsNullOrEmpty(value)) throw new DomainException("EmailAddress cannot be empty");
            value = value.Trim().ToLowerInvariant();
            if (!value.Contains("@")) throw new DomainException("Invalid EmailAddress provided");
            return new EmailAddress(value);
        }

        public override string ToString() => Value.ToString();
        
    }
}
