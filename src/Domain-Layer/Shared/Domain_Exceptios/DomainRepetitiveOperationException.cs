using Domain_Layer.Shared.Base_Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Shared.Domain_Exceptios
{
    public class DomainReviewArgumentException:BaseException
    {
        public DomainReviewArgumentException() : base("Repetitive Operation")
        {
            
        }
        public DomainReviewArgumentException(string message):base(message) 
        {
            
        }
    }
}
