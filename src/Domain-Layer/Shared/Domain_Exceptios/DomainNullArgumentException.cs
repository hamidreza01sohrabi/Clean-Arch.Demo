using Domain_Layer.Shared.Base_Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Domain_Layer.Shared.Domain_Exceptios
{
    public class DomainNullArgumentException:BaseException
    {
        public DomainNullArgumentException()
        {
            
        }
        public DomainNullArgumentException(string Message):base(Message) 
        {
            
        }

        public static void CheckNullArgs(string message) { 
        
            if (string.IsNullOrEmpty(message) || string.IsNullOrWhiteSpace(message)) 
                throw new DomainNullArgumentException(message);
            
        }
    }

}
