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
        void Add(Product product);  
        void Update(Product product);
        void Delete(Guid id);

        Product GetProductById(Guid id);
        List<Product> GetProducts();
        void SaveEveryThings();
    }
}
