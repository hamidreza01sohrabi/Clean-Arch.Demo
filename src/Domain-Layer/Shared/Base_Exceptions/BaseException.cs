using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Shared.Base_Exceptions
{
    public class BaseException:Exception
    {
        public BaseException()
        {
            
        }
        public BaseException(string Message):base(Message) 
        {
            
        }
    }
}
