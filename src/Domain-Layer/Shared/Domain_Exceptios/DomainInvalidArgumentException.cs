using Domain_Layer.Shared.Base_Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Shared.Domain_Exceptios
{
    public class DomainInvalidArgumentException:BaseException
    {
        public DomainInvalidArgumentException():base("Argument Is In Invalid State")
        {
            
        }
        public DomainInvalidArgumentException(string Message):base(Message) 
        {
            
        }
        public static void CheckInvalidStringArgs(string value) {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Trim().Length != 11)
                throw new DomainInvalidArgumentException($"{value} is in invalid state");
        }

        public static void CheckInvalidIntegerArgs(double value)
        {

            if (value <= 0)
                throw new DomainInvalidArgumentException();
        }
        public static void CheckInvalidIntegerArgs(int value) {

            if (value <= 0)
                throw new DomainInvalidArgumentException();
        }
    }
}
