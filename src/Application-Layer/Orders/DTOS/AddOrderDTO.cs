using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Orders.DTOS
{
    public class AddOrderDTO
    {
        public AddOrderDTO(Guid productId, double price, int count, bool @finally, DateTime finallyDate)
        {
            ProductId = productId;
            Price = price;
            Count = count;
            Finally = @finally;
            FinallyDate = finallyDate;
        }

        public Guid ProductId { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public bool Finally { get; set; }
        public DateTime FinallyDate { get; set; }
    }
}
