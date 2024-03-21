using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Users
{
    public class User
    {
        public User(string userName, string email, string phoneNumber)
        {
            Guard(userName, email, phoneNumber);
            uId =Guid.NewGuid();
            UserName = userName;
            Email = email;
            PhoneNumber = phoneNumber;
            DeleteStatus = false;
        }

        public Guid uId{ get;private set; }
        public string  UserName{ get;private set; }
        public string  Email{ get;private set; }
        public string  PhoneNumber{ get;private set; }
        public bool DeleteStatus{ get;private set; }
        public DateTime DeleteDate{ get;private set; }


        //User Will Be Hidden From getAll Methode
        public void userDLT() {
            DeleteStatus = true;
            DeleteDate = DateTime.Now;
        }


        public void Edite(string userName, string email, string phoneNumber) {
            UserName = userName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        private void Guard(string userName, string email, string phoneNumber) {

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber)) {
                throw new Exception("arguments are invalid");
            }
        }
    }
}
