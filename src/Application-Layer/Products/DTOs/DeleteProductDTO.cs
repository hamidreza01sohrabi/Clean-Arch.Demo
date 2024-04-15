namespace Application_Layer.Products.DTOs
{
    public class DeleteProductDTO
    {
        public DeleteProductDTO(long id)
        {
            this.id = id;
        }

        public long id { get; set; }
       
    }

}
