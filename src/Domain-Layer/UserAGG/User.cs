using Domain_Layer.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer
{
    public class User
    {
        public User(string userName, string email, PhoneBook phoneBook)
        {
            Guard(userName, email);
            uId =Guid.NewGuid();
            UserName = userName;
            Email = email;
            PhoneBook = phoneBook;
            DeleteStatus = false;
        }

        public Guid uId{ get;private set; }
        public string  UserName{ get;private set; }
        public string  Email{ get;private set; }
        public PhoneBook PhoneBook { get;private set; }
        public bool DeleteStatus{ get;private set; }
        public DateTime DeleteDate{ get;private set; }


        //User Will Be Hidden From getAll Methode
        public void userDLT() {
            DeleteStatus = true;
            DeleteDate = DateTime.Now;
        }


        public void Edite(string userName, string email, PhoneBook phoneBook) {
            UserName = userName;
            Email = email;
            PhoneBook = phoneBook;
        }

        private void Guard(string userName, string email) {

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(email)) {
                throw new Exception("arguments are invalid");
            }
        }
    }
}
