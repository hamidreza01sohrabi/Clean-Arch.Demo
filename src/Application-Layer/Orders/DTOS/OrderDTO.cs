namespace Application_Layer.Orders.DTOS
{
    public class OrderDTO
    {
        public OrderDTO(long oId)
        {
            this.oId = oId;
        }
        public OrderDTO()
        {
            
        }
        public long oId { get; set; }
        
    }
}
