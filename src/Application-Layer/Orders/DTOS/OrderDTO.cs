namespace Application_Layer.Orders.DTOS
{
    public class OrderDTO
    {
        public OrderDTO(Guid oId, Guid productId, double price, int count, bool @finally, DateTime finallyDate)
        {
            this.oId = oId;
            ProductId = productId;
            Price = price;
            Count = count;
            Finally = @finally;
            FinallyDate = finallyDate;
        }

        public Guid oId { get; set; }
        public Guid ProductId { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public bool Finally { get; set; }
        public DateTime FinallyDate { get; set; }
    }
}
