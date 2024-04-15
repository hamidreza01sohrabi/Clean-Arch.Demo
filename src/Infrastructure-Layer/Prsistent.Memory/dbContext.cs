using Domain_Layer;
using Domain_Layer.Orders;
using Domain_Layer.Products;
using Domain_Layer.Shared.Value_Objects;
using Domain_Layer.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.Prsistent.Memory
{
    public class dbContext
    {
        public List<Product> products { get; set; } = new List<Product>() { new Product("tittleFirst", Money.FromTooman(5000), 12) , new Product("tittleSecond", Money.FromTooman(12500), 22)};
        public List<User> users { get; set; }
        public List<Order>  orders { get; set; }

    }
}
