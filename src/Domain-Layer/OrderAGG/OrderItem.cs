using Domain_Layer.Shared.Base_Classes;
using Domain_Layer.Shared.Value_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.OrderAGG
{
    public class OrderItem : BaseEntity
    {
        public OrderItem(long oId, long productId, int count, Money price)
        {
            this.oId = oId;
            ProductId = productId;
            Count = count;
            Price = price;
        }

        public long oId { get;private set; }
        public long ProductId { get; private set; }
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
