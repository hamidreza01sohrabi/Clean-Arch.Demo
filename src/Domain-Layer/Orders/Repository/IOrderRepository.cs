using Domain_Layer.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Orders.Repository
{
    public interface IOrderRepository
    {
        // متد های ریپازیتوری در لایه های  بالاتر پیاده سازی میشود و عملیات های ذیل رو پایگاه داده برای شی اوردر یا سفارش انجام میشود بدون حذف اطلاعات از بانک
      
        void Add(Order order);
        void Update(Order order);
        Order GetOrderById(Guid id);
        List<Order> GetOrders();
        void SaveEveryThings();
    }
}
