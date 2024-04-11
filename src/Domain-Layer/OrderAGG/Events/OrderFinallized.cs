using Domain_Layer.Shared.Base_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.OrderAGG.Events
{
    public class OrderFinallized:BaseDomainEvent
    {
        public OrderFinallized(long orderId, long userId)
        {
            OrderId = orderId;
            UserId = userId;
        }

        public long OrderId { get; set; }
        public long UserId { get; set; }
    }
}
