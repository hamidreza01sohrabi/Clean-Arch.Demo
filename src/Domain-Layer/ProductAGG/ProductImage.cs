using Domain_Layer.Shared.Base_Classes;
using Domain_Layer.Shared.Domain_Exceptios;
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
            Guard(imageName, pid);
            ImageName = imageName;
            pId = pid;
        }

        public string ImageName{ get;private set; }
        public long pId { get;private set; }

        private void Guard(string imgName, long pid) {

            DomainNullArgumentException.CheckNullArgs(imgName);
        }
    }
}
