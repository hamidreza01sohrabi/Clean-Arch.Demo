using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Users.DTOs
{
    public class UserDTO
    {
        /// public UserDTO() { }
        //public UserDTO(Guid uId, string userName, string email, string phoneNumber)
        //{
        //    this.uId = uId;
        //    UserName = userName;
        //    Email = email;
        //    PhoneNumber = phoneNumber;
        //}

        public Guid uId { get;  set; }
        public string UserName { get;  set; }
        public string Email { get;  set; }
        public string PhoneNumber { get;  set; }
       
    }
}
