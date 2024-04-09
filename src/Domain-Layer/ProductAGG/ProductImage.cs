using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.ProductAGG
{
    public class ProductImage
    {
        public ProductImage(string imageName, Guid pid)
        {
            ImageName = imageName;
            pId = pid;
        }

        public long Id { get; set; }
        public string ImageName{ get; set; }
        public Guid pId { get; set; }

        private void Guard(string imgName, Guid pid) {

            if (string.IsNullOrEmpty(imgName))
            {
                throw new Exception("image name cant be null");
            }
            if (pid == Guid.Empty)
            {
                throw new Exception("productId is invalid");
            }
        }
    }
}
