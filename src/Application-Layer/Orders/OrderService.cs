﻿using Application_Layer.Orders.DTOS;
using Domain_Layer.Orders;
using Domain_Layer.Orders.Repository;

namespace Application_Layer.Orders
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository repository;
        public OrderService(IOrderRepository _repository)
        {
            repository= _repository;    
        }


        public void CreateNewOrder(AddOrderDTO command)
        {
            var newOrder = new Order(command.ProductId, command.Price, command.Count);
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

        public OrderDTO GetOrder(Guid id)
        {
           var or= repository.GetOrderById(id);
            return new OrderDTO(or.oId, or.ProductId, or.Price, or.Count, or.Finally, or.FinallyDate);    
        }

        public List<OrderDTO> GetOrders()
        {
            return repository.GetOrders().Select(or => new OrderDTO(or.oId, or.ProductId, or.Price, or.Count, or.Finally, or.FinallyDate)).ToList();
        }
    }
}
