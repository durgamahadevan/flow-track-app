using FlowTrack.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowTrack.Domain.ValueObjects
{
    public sealed record TenantName
    {
        public string Value {  get; }

        private TenantName(string TenantName) 
        {
            Value = TenantName;
        }

        public static TenantName Create(string value) 
        {
            if (string.IsNullOrWhiteSpace(value)) throw new DomainException("TenantName cannot be empty.");
            if (value.Length < 2 || value.Length > 100) throw new DomainException("TenantName length is invalid.");
            return new TenantName(value.Trim());
        }

        public override string ToString() => Value.ToString();
        
    }
}
