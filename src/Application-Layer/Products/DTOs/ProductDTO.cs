using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Products.DTOs
{
    public class ProductDTO
    {
        public ProductDTO() { }

        public Guid pId { get;  set; }
        public string Tittle { get;  set; }
        public double Price { get;  set; }
        public int Count { get;  set; }
    }

}
