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

        void Add(User user);

        void Update(User user);
        User GetById(Guid id);
        List<User> GetUsers();
        void SaveEveryThings();
    }
}
