using Domain_Layer.Products;
using Domain_Layer.Products.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.Prsistent.Memory.Products
{
    public class ProductRepository : IProductRepository
    {
        private readonly dbContext dbContext;

        public ProductRepository(dbContext _dbcontext)
        {
            dbContext = _dbcontext  ;
        }

        public void Add(Product product)
        {
            dbContext.products.Add(product);
        }

        public void Delete(Product p)
        {
            dbContext.products.Remove(p);
        }

        public Product GetProductById(Guid id)
        {
            return dbContext.products.FirstOrDefault<Product>(i => i.pId == id);
        }

        public List<Product> GetProducts()
        {
            return dbContext.products;
        }

        public bool NotExist(Guid guid)
        {
            return   dbContext.products.Any(item => item.pId == guid);
        }

        public void SaveEveryThings()
        {
           ///
        }

        public void Update(Product product)
        {
            var old=GetProductById(product.pId);
            dbContext.products.Remove(old);
            dbContext.products.Add(product);

        }
    }
}
