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

        public Product GetProductById(long id)
        {
            return dbContext.products.FirstOrDefault<Product>(i => i.Id == id);
        }

        public List<Product> GetProducts()
        {
            return dbContext.products;
        }

        public bool Exist(long guid)
        {
            return  dbContext.products.Any(item => item.Id == guid);
        }

        public void SaveEveryThings()
        {
           ///
        }

        public void Update(Product product)
        {
            var old=GetProductById(product.Id);
            dbContext.products.Remove(old);
            dbContext.products.Add(product);

        }
    }
}
