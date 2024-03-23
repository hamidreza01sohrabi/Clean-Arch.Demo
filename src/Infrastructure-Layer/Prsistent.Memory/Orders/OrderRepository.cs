using Domain_Layer.Orders;
using Domain_Layer.Orders.Repository;
using Domain_Layer.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.Prsistent.Memory.Orders
{
    public class OrderRepository : IOrderRepository
    {
        private readonly dbContext dbContext;

        public OrderRepository(dbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public void Add(Order order)
        {
            dbContext.orders.Add(order);    
        }

        public Order GetOrderById(Guid id)
        {
           return dbContext.orders.FirstOrDefault(i=>i.oId == id);
        }

        public List<Order> GetOrders()
        {
            return dbContext.orders.ToList();
        }

        public bool NotExist(Guid guid)
        {
            return dbContext.orders.Any(i=> i.oId == guid);
        }

        public void SaveEveryThings()
        {
            //
        }

        public void Update(Order order)
        {
            var old = GetOrderById(order.oId);
           /// var old = dbContext.orders.FirstOrDefault(i => i.oId == order.oId);
            dbContext.orders.Remove(old);
            dbContext.orders.Add(order);
        }
    }
}
