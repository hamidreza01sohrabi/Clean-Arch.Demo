using Domain_Layer.Shared.Base_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.ProductAGG
{
    public class ProductImage : BaseEntity
    {
        public ProductImage(string imageName, long pid)
        {
            ImageName = imageName;
            pId = pid;
        }

        public string ImageName{ get;private set; }
        public long pId { get;private set; }

        private void Guard(string imgName, long pid) {

            if (string.IsNullOrEmpty(imgName))
            {
                throw new Exception("image name cant be null");
            }
            if (pid == null)
            {
                throw new Exception("productId is invalid");
            }
        }
    }
}
