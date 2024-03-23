namespace Application_Layer.Products.DTOs
{
    public class DeleteProductDTO
    {
        public DeleteProductDTO(Guid id)
        {
            this.id = id;
        }

        public Guid id { get; set; }
       
    }

}
