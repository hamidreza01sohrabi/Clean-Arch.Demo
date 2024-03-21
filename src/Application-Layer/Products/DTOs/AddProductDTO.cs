namespace Application_Layer.Products.DTOs
{
    public class AddProductDTO
    {
        public AddProductDTO(string tittle, double price, int count)
        {
            Tittle = tittle;
            Price = price;
            Count = count;
        }

        public string Tittle { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
    }

}
