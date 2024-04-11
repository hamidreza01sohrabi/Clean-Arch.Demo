using Application_Layer.Orders;
using Application_Layer.Orders.DomainService;
using Application_Layer.Products;
using Application_Layer.Users;
using Contract_Layer;
using Domain_Layer.OrderAGG.Services;
using Domain_Layer.Orders.Repository;
using Domain_Layer.Products.Repository;
using Domain_Layer.Users.Repository;
using Infrastructure_Layer.Prsistent.Memory;
using Infrastructure_Layer.Prsistent.Memory.Orders;
using Infrastructure_Layer.Prsistent.Memory.Products;
using Infrastructure_Layer.Prsistent.Memory.Users;
using Infrastructure_Layer.sendMessage;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config_Layer
{
    public class bootStrapper
    {
        public static void Init(IServiceCollection services)
        {

            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IUserServices, UserServices>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IOrderDomainService, OrderDomainService>();

            services.AddScoped<ISMS,SMS>();

            //carete one instanciation of dbContext class for this Project
            services.AddSingleton<dbContext>();
        }
    }
}
