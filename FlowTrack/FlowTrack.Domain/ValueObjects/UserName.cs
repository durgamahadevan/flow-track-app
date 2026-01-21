using FlowTrack.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowTrack.Domain.ValueObjects
{
    public sealed record UserName
    {
        public string Value { get; }

        private UserName(string value)
        {
            Value = value;
        }

        public static UserName Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new DomainException("UserName cannot be empty");
            value = value.Trim();
            if (value.Length < 2 || value.Length > 100) throw new DomainException("Invalid length of UserName");
            return new UserName(value);
        }

        public override string ToString() => Value.ToString();
        
    }
}
