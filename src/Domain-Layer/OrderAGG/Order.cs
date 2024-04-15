using Domain_Layer.OrderAGG;
using Domain_Layer.OrderAGG.Events;
using Domain_Layer.OrderAGG.Services;
using Domain_Layer.Shared.Base_Classes;
using Domain_Layer.Shared.Domain_Exceptios;
using Domain_Layer.Shared.Value_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Orders
{
    public class Order:AggregateRoot
    {
  

        public Order(long userid)
        {
            UserId= userid;
            Finally = false;
            Items = new List<OrderItem>();           
        }

        public int TottalItems { get;private set; }
        public long UserId{ get; private set; }
        public bool Finally{ get; private set; }
        public DateTime FinallyDate{ get; private set; }
        public ICollection<OrderItem> Items{ get; private set; }



        public void AddOrderItem(long pid, int count, double price, IOrderDomainService service)
        {
            
            if (service.ProductNotExsite(pid))
                throw new DomainNotFoundDataException("product not found to create orderItem");

            if (Items.Any(x => x.ProductId == pid))
                throw new DomainRepetitiveOperationException();

            Items.Add(new OrderItem(Id, pid, count, Money.FromTooman(price)));
            TottalItems += count;
        }

        public void RemoveOrderItem(long id)
        {
            var item = Items.FirstOrDefault(z => z.ProductId == id);
            if (item == null)
                throw new DomainNotFoundDataException("order item was not found");

            Items.Remove(item);
            TottalItems -= item.Count;
        }
        public void FinallyOrder()
        {

            Finally = true;
            FinallyDate = DateTime.Now;
            AddDomainEvent(new OrderFinallized(Id, UserId));
        }















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



    }
}
