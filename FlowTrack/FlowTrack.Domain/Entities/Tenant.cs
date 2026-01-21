using FlowTrack.Domain.Enums;
using FlowTrack.Domain.ValueObjects;
using FlowTrack.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowTrack.Domain.Entities
{
    public class Tenant
    {
        public TenantId Id { get; }
        public TenantName Name { get; private set; }
        public TenantType Type { get; }

        public TenantStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }

        private Tenant(TenantId tenantId, TenantName tenantName, TenantType tenantType)
        {
            Id = tenantId;
            Name = tenantName;
            Type = tenantType;
            CreatedAt = DateTime.Now;
            Status = TenantStatus.Active;
        }
        public static Tenant CreateIndividualTenant(TenantName tenantName)
        {
            return new Tenant(TenantId.New(), tenantName, TenantType.Individual);
        }

        public static Tenant CreateOrganizationTenant(TenantName tenantName)
        {
            return new Tenant(TenantId.New(), tenantName, TenantType.Organization);
        }

        public void Rename(TenantName newName)
        {
            Name = newName;
        }

        public void Activate()
        {
            Status = TenantStatus.Active;
        }

        public void Deactivate()
        {
            Status = TenantStatus.Inactive;
        }

        public void Suspend()
        {
            Status = TenantStatus.Suspended;
        }
    }
}
    