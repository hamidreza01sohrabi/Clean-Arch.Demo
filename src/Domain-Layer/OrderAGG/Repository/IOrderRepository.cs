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
      
        //برای ساخت یک شی جدید
        void Add(Order order);



        //برای بروزرسانی اطلاعات اشیا ثبت شده
        void Update(Order order);


        

        //برای گرفتن اشیا ثبت شده
        Order GetOrderById(long id);
        List<Order> GetOrders();



        
        //برای ثبت و اتمام عملیات ها
        void SaveEveryThings();



        //گرفتن استعلام شی از بانک
        bool NotExist(long guid);
    }
}
