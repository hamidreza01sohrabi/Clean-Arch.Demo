using Domain_Layer.Shared.Base_Value_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Shared
{
    public  class PhoneNumber: BaseValueObject
    {
        public PhoneNumber(string tell)
        {
            Guard(tell);
            Tell = tell;
        }

        //میتونستیم یک پیش شماره هم بگیریم
        public string Tell { get; init; }



        private void Guard(string tell) {

            if (string.IsNullOrEmpty(tell) || string.IsNullOrWhiteSpace(tell)) {
                throw new Exception("Value is not found");
            }
            if (tell.Trim().Length == 11)
            {
                throw new Exception("caracter less");
            }
        }
        //public static PhoneNumber addNumber(string tell)
        //{
        //    return new PhoneNumber(tell);
        //}
        public static PhoneNumber addNumberIR(string tell) {

            var finallWord = tell.Remove(0, 1);

            StringBuilder sb = new StringBuilder("+98-");
            sb.Append(finallWord);

            return new PhoneNumber(tell);
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}
