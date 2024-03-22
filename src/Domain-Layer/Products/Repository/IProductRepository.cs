using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Products.Repository
{
    public interface IProductRepository
    {
        //  حذف منطقی کالا از بانک + متد های ریپازیتوری در لایه های  بالاتر پیاده سازی میشود و عملیات های ذیل رو پایگاه داده برای شی پروداکت انجام میشود





        //برای ساخت یک شی جدید
        void Add(Product product);







        //برای بروزرسانی اطلاعات اشیا ثبت شده
        void Update(Product product);





        //برای حذف شی از بانک اطلاعاتی
        void Delete(Guid id);






        //برای گرفتن اشیا ثبت شده
        Product GetProductById(Guid id);
        List<Product> GetProducts();








        //برای ثبت و اتمام عملیات ها
        void SaveEveryThings();








        //گرفتن استعلام شی از بانک
        bool NotExist(Guid guid);
    }
}
