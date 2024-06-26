﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Orders
{
    public class Order
    {
  

        public Order(Guid productId, double price, int count)
        {
            Guard(productId, price, count);
            oId = Guid.NewGuid();   
            ProductId = productId;
            Price = price;
            Count = count;
            Finally = false;
            
        }

        public Guid oId { get;private set; }
        public Guid ProductId { get;private set; }
        public double Price { get; private set; }
        public int Count { get; private set; }
        public bool Finally{ get; private set; }
        public DateTime FinallyDate{ get; private set; }

        public void FinallyOrder() {

            Finally = true;
            FinallyDate = DateTime.Now; 
        }

        private void Guard(Guid productId, double price, int count) { 
            if (productId == Guid.Empty)
            {
                throw new Exception($"{productId} id invalid");
            }
            if (price == 0 || price < 0) {
                throw new Exception($"{price} id invalid");
            }
            if (count <= 0) {
                throw new Exception($"{count} id invalid");
            }
        }
        
          
    }
}
