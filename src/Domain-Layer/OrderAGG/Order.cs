using Domain_Layer.OrderAGG;
using Domain_Layer.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Orders
{
    public class Order
    {
  

        public Order()
        {
           
            oId = Guid.NewGuid();  
            Finally = false;
            Items = new List<OrderItem>();           
        }

        public Guid oId { get;private set; }
        public int TottalItems { get;private set; }
        public bool Finally{ get; private set; }
        public DateTime FinallyDate{ get; private set; }
        public ICollection<OrderItem> Items{ get; private set; }


        //public double GetTottalPriceOfItem(long itemId) {
        //    var item = Items.FirstOrDefault(x => x.Id == itemId);
        //    if (item != null)
        //        throw new Exception("item not found");

        //    return item.TottalPrice;
        //}

        //public void PluseCountOfItem(long itemId)
        //{
        //    var item = Items.FirstOrDefault(x => x.Id == itemId);
        //    if (item != null)
        //        throw new Exception("item not found");

           
        //    item.IncreaseCount();
        //}
        //public void MinusCountOfItem(long itemId)
        //{
        //    var item = Items.FirstOrDefault(x => x.Id == itemId);
        //    if (item != null)
        //        throw new Exception("item not found");


        //    item.DecreaseCount();
        //}

        public void AddOrderItem(Guid pid, int count,int price) 
        {
            if (Items.Any(x => x.ProductId == pid))
                throw new Exception("this order was created");

            Items.Add(new OrderItem(this.oId, pid, count, Money.FromTooman(price)));
            TottalItems += count;
        }

        public void RemoveOrderItem(Guid id)
        {
            var item = Items.FirstOrDefault(z=>z.ProductId  == id);
            if (item == null)
                throw new Exception("order item was not found");

            Items.Remove(item);
            TottalItems -= item.Count;    
        }
        public void FinallyOrder() {

            Finally = true;
            FinallyDate = DateTime.Now; 
        }

       
        
          
    }
}
