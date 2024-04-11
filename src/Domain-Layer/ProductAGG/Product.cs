using Domain_Layer.ProductAGG;
using Domain_Layer.Shared.Base_Classes;
using Domain_Layer.Shared.Domain_Exceptios;
using Domain_Layer.Shared.Value_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Products
{
    public class Product : AggregateRoot
    {
        public Product(string tittle, Money price, int count)
        {
            Guard(tittle, count);
            Tittle = tittle;
            Price = price;
            Count = count;
            images = new List<ProductImage>();
        }

        public string Tittle { get; private set; }
        public Money Price { get; private set; }
        public int Count { get; private set; }
        public int TottalImage { get; private set; }
        public ICollection<ProductImage> images { get; private set; }




        public void AddImage(string ImgName) {
           
            images.Add(new ProductImage(ImgName, Id));
            TottalImage += images.Count;
        }
        public void RemoveImage(long id) { 

            var img=images.FirstOrDefault(i=>i.Id == id);
            if (img == null)
                throw new DomainNotFoundData("product not found to add image");

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

            DomainInvalidArgumentException.CheckInvalidStringArgs(tittle);
           
            DomainInvalidArgumentException.CheckInvalidIntegerArgs(count);
        }
        
    }
}
