using Domain_Layer.ProductAGG;
using Domain_Layer.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Products
{
    public class Product
    {
        public Product(string tittle, Money price, int count)
        {
            Guard(tittle, count);
            pId =Guid.NewGuid();
            Tittle = tittle;
            Price = price;
            Count = count;
            images = new List<ProductImage>();
        }

        public Guid pId { get;private set; }
        public string Tittle { get; private set; }
        public Money Price { get; private set; }
        public int Count { get; private set; }
        public int TottalImage { get; private set; }
        public ICollection<ProductImage> images { get; private set; }




        public void AddImage(string ImgName) {
           
            images.Add(new ProductImage(ImgName, pId));
            TottalImage += images.Count;
        }
        public void RemoveImage(long id) { 

            var img=images.FirstOrDefault(i=>i.Id == id);
            if (img == null)
                throw new Exception("image not found");
            images.Remove(img); 
        }

        public void Edite(string tittle, Money price, int count)
        {
            Guard(tittle, count);
            Tittle = tittle;
            Price = price;
            Count = count;
        }
        private void Guard(string tittle, int count)
        {

            if (string.IsNullOrWhiteSpace(tittle))
            {
                throw new Exception("tittle is null");
            }
            if (count < 0)
            {

                throw new Exception("count is invalid");
            }
        }
        
    }
}
