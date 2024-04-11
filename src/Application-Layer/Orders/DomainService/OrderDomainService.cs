using Domain_Layer.OrderAGG.Services;
using Domain_Layer.Products.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Orders.DomainService
{
    public class OrderDomainService : IOrderDomainService
    {
        private readonly IProductRepository repository;

        public OrderDomainService(IProductRepository _repository)
        {
            repository = _repository;
        }

        public bool ProductNotExsite(Guid ProductId)
        {
            var P = repository.Exist(ProductId);
            return !P;
        }

    }
}
