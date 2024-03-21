using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Products
{
    public class Product
    {
        public Product(string tittle, double price, int count)
        {
            Guard(tittle, price, count);
            pId =Guid.NewGuid();
            Tittle = tittle;
            Price = price;
            Count = count;
        }

        public Guid pId { get;private set; }
        public string Tittle { get; private set; }
        public double Price { get; private set; }
        public int Count { get; private set; }




        public void Edite(string tittle, double price, int count)
        {
            Guard(tittle, price, count);
            Tittle = tittle;
            Price = price;
            Count = count;
        }
        private void Guard(string tittle, double price, int count)
        {

            if (string.IsNullOrWhiteSpace(tittle))
            {
                throw new Exception("tittle is null");
            }
            if (price < 0)
            {

                throw new Exception("price is invalid");
            }
            if (count < 0)
            {

                throw new Exception("count is invalid");
            }
        }
        
    }
}
