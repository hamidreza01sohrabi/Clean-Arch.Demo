using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Orders.DTOS
{
    public class AddOrderDTO
    {
        public AddOrderDTO(long userid)
        {
            UserId = userid;
        }

        public long UserId { get; set; }
    }
}
