using Application_Layer.Orders.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Orders
{
    public interface IOrderService
    {
        void CreateNewOrder(AddOrderDTO command);
        void FinallyOrder(FinallyOrderDTO command);
        OrderDTO GetOrder(Guid id);  
        List<OrderDTO> GetOrders();  
    }
}
