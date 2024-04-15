using Application_Layer.Orders;
using Application_Layer.Orders.DTOS;
using Application_Layer.Users;
using Application_Layer.Users.DTOs;
using Contract_Layer;
using Domain_Layer;
using Domain_Layer.Orders;
using Domain_Layer.Orders.Repository;
using Domain_Layer.Users.Repository;
using FluentAssertions;
using NSubstitute;
using System.Runtime.CompilerServices;
namespace ApplicationLayer.Test
{
    public class OrderServiceTest
    {
     
        private readonly OrderService orderService;
        private readonly IOrderRepository repository;
        private readonly ISMS SMS;
        public OrderServiceTest()
        {
            repository = Substitute.For<IOrderRepository>(); 
            SMS = Substitute.For<ISMS>(); 
            orderService = new OrderService(repository, SMS);
        }

        [Fact]
        public void create_new_Order_service() {

            //arrange
            var orderToadd = new AddOrderDTO(1);

            //act
            orderService.CreateNewOrder(orderToadd);    
            //assert

            repository.Received(1).SaveEveryThings();   
        }
        [Fact]
        public void finally_Order_service()
        {
            //arrange
            repository.GetOrderById(Arg.Any<long>()).Returns(new Order(1));
            var orderToFinally = new FinallyOrderDTO(1);
            //act
            orderService.FinallyOrder(orderToFinally);
            //assert

            repository.Received(1).SaveEveryThings();
            SMS.Received(1).Send(Arg.Any<MessageInfo>());
        }

        [Fact]
        public void get_Order_by_id_service()
        {

            //arrang
             repository.GetOrderById(Arg.Any<long>()).Returns(new Order(4));
            var orderToFind = new OrderDTO(1,4);

            //act
            var res = orderService.GetOrder(orderToFind.oId);

            //assert
            res.UserId.Should().Be(4);
        }


        [Fact]
        public void get_Orders_service()
        {

            //arrang
            repository.GetOrders().Returns(new List<Order>() { new Order(1), new Order(20)});

            //act
            var res = orderService.GetOrders();

            //assert
            res.Should().HaveCount(2);
        }

    }
}