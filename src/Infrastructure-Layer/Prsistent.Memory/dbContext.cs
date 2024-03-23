using Domain_Layer.Orders;
using Domain_Layer.Products;
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
        public List<Product> products { get; set; }
        public List<User> users { get; set; }
        public List<Order>  orders { get; set; }

    }
}
