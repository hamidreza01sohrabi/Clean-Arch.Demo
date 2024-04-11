using Domain_Layer.Shared.Base_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.UserAGG.Events
{
    public class UserRegistered:BaseDomainEvent
    {
        public UserRegistered(long userId, string email)
        {
            UserId = userId;
            Email = email;
        }

        public long UserId { get;private set; }
        public string Email { get; private set; }
    }
}
