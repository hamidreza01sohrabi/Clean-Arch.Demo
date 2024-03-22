using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Users.Repository
{
    public interface IUserRepository
    {

        //   متد های ریپازیتوری در لایه های  بالاتر پیاده سازی میشود و عملیات های ذیل رو پایگاه داده برای شی یوزر انجام میشود بدون حذف منطقی از بانک

        
        
        
        //برای ساخت یک شی جدید
        void Add(User user);



        //برای بروزرسانی اطلاعات اشیا ثبت شده
        void Update(User user);



        //برای گرفتن اشیا ثبت شده
        User GetUserById(Guid id);
        List<User> GetUsers();



        //برای ثبت و اتمام عملیات ها
        void SaveEveryThings();



        //گرفتن استعلام شی از بانک
        bool NotExist(Guid guid);
        
    }
}
