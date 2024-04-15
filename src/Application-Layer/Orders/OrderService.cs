using Application_Layer.Orders.DomainService;
using Application_Layer.Orders.DTOS;
using Domain_Layer.OrderAGG.Services;
using Domain_Layer.Orders;
using Domain_Layer.Orders.Repository;
using Domain_Layer.Shared.Value_Objects;

namespace Application_Layer.Orders
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository repository;
      ///  private readonly IOrderDomainService service;
        public OrderService(IOrderRepository _repository, IOrderDomainService _service)
        {
            repository= _repository;
           /// service = _service;
        }

        //public void CreateNewOrder(AddOrderDTO command)
        //{
        //    var newOrder = new Order();
        //    newOrder.AddOrderItem(command.ProductId, command.Count, Money.FromTooman(command.Price));
        //    repository.Add(newOrder);
        //    repository.SaveEveryThings();
        //}
        public void CreateNewOrder(AddOrderDTO command)
        {
            var newOrder = new Order(command.UserId, command.ProductId);
         ////////   newOrder.AddOrderItem(command.ProductId, command.Count, command.Price, service);
            repository.Add(newOrder);
            repository.SaveEveryThings();
        }

        public void FinallyOrder(FinallyOrderDTO command)
        {
            var order = repository.GetOrderById(command.oId);
            order.FinallyOrder();
            repository.Update(order);
            repository.SaveEveryThings();

        }

        public OrderDTO GetOrder(long id)
        {
            Order o = repository.GetOrderById(id);
            return new OrderDTO(o.Id);
        }

    

        public List<OrderDTO> GetOrders()
        {
            return repository.GetOrders().Select(or => new OrderDTO() {

                oId = or.Id
            }).ToList();
        }
    }
}
