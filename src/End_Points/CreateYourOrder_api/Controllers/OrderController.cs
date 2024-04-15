using Application_Layer.Orders;
using Application_Layer.Orders.DTOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Schema;

namespace CreateYourOrder_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {


        private readonly IOrderService orderService;

        public OrderController(IOrderService _orderService)
        {
            orderService = _orderService;
        }




        [Route("/AddinO")]
        [HttpPost]
        public string AddingNewOrder(AddOrderDTO add) { 
            orderService.CreateNewOrder(add);
            return "";
        }

        [Route("/FinallyO")]
        [HttpPost]
        public string FinallyOrder(FinallyOrderDTO finallyOrder) { 
        
            orderService.FinallyOrder(finallyOrder);
            return "";
        }


        [Route("/GettingOneO")]
        [HttpGet]
        public OrderDTO GettingOneOrder(long guid)
        {

            return orderService.GetOrder(guid);
        }


        [Route("/GetOs")]
        [HttpGet]
        public List<OrderDTO> GetOrders()
        {

            return orderService.GetOrders();
        }
    }
}
