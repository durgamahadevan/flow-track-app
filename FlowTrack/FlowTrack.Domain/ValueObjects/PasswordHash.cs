using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowTrack.Domain.Exceptions;

namespace FlowTrack.Domain.ValueObjects
{
    public sealed record PasswordHash
    {
        public string Value {  get; }

        private PasswordHash(string value)
        {
            Value = value;
        }

        public static PasswordHash FromHash(string hash)
        {
            if (string.IsNullOrWhiteSpace(hash)) throw new DomainException("Password hash cannot be empty");
            return new PasswordHash(hash);
        }
    }
}
