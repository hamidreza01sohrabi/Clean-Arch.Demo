using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Shared.Base_Classes
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreationDate =new DateTime();
        }

        public long Id { get; set; }
        public DateTime CreationDate { get; }
    }
}
