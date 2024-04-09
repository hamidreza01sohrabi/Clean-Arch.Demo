using Domain_Layer.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.OrderAGG
{
    public class OrderItem
    {
        public OrderItem(Guid oId, Guid productId, int count, Money price)
        {
            this.oId = oId;
            ProductId = productId;
            Count = count;
            Price = price;
        }

        public long Id { get;private set; }
        public Guid oId { get;private set; }
        public Guid ProductId { get; private set; }
        public int Count { get; private set; }
        public Money Price { get; private set; }

        //public double TottalPrice { 
        //    get {
        //        return this.Count * this.Price.RialValue;
        //    }  
        //}

        //public void IncreaseCount() {
        
        //    this.Count += 1;
        //}

        //public void DecreaseCount()
        //{

        //    this.Count -= 1;
        //}
    }
}
