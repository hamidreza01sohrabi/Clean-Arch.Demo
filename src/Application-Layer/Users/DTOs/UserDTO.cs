using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Users.DTOs
{
    public class UserDTO
    {
        public UserDTO()
        {
            
        }

        public UserDTO(long uId, string userName, string email, string mobileNumber, string faxNumber)
        {
            this.uId = uId;
            UserName = userName;
            Email = email;
            MobileNumber = mobileNumber;
            FaxNumber = faxNumber;
        }

        public long uId { get;  set; }
        public string UserName { get;  set; }
        public string Email { get;  set; }
        public string MobileNumber { get; set; }
        public string FaxNumber { get; set; }

    }
}
