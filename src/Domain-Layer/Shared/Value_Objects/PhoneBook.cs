using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Shared.Value_Objects
{
    public class PhoneBook
    {
        public PhoneBook(PhoneNumber moblie, PhoneNumber fax)
        {
            Moblie = moblie;
            Fax = fax;
        }

        public PhoneNumber Moblie { get; init; }
        public PhoneNumber Fax { get; init; }
    }
}
