using FlowTrack.Domain.Enums;
using FlowTrack.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FlowTrack.Domain.Entities
{
    public class User
    {
        public UserId Id { get; }

        public TenantId TenantId { get; }
        public UserName UserName { get; }

        public PasswordHash PasswordHash { get; private set; }
        public UserStatus Status { get; private set; }

        public EmailAddress Email { get; private set; }

        public DateTime CreatedAt { get; set; }

        private User(UserId userId, 
            TenantId tenantId, 
            UserName userName, 
            PasswordHash passwordHash,
            EmailAddress email, 
            UserStatus status,
            DateTime createdAt)
        {
            Id = userId;
            TenantId = tenantId;
            UserName = userName;
            PasswordHash = passwordHash;
            Email = email;
            Status = status;
            CreatedAt = createdAt;
        }

        public static User Create(TenantId tenantId, UserName userName, EmailAddress email, PasswordHash passwordHash)
        {
            return new User(UserId.New(), tenantId, userName, passwordHash, email, UserStatus.Active, DateTime.Now);
        }

        public void ChangeEmail(EmailAddress email) 
        {
            Email = email;
        }

        public void ChangePassword(PasswordHash passwordHash)
        { 
            PasswordHash = passwordHash;
        }

        public void Disable()
        {
            Status = UserStatus.Disabled;
        }

        public void Activate()
        {
            Status = UserStatus.Active;
        }
    }
}
