namespace Application_Layer.Products.DTOs
{
    public class EditeProductDTO 
    {
        public EditeProductDTO(long id, string tittle, double price, int count)
        {
            this.id = id;
            Tittle = tittle;
            Price = price;
            Count = count;
        }

        public long id { get; set; }
        public string Tittle { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
    }

}
