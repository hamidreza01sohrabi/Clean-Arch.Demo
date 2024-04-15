namespace Application_Layer.Orders.DTOS
{
    public class OrderDTO
    {
        public OrderDTO(long oId, long userId)
        {
            this.oId = oId;
            UserId = userId;
        }
        public OrderDTO()
        {
            
        }
        public long oId { get; set; }
        public long UserId { get; set; }
        
    }
}
