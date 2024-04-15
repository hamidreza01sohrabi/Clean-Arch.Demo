namespace Application_Layer.Orders.DTOS
{
    public class FinallyOrderDTO
    {
        public FinallyOrderDTO(long oId)
        {
            this.oId = oId;
        }

        public long oId { get; set; }
       
    }
}
