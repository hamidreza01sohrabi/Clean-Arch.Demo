using Domain_Layer.Shared.Base_Classes;
using Domain_Layer.Shared.Value_Objects;
using Domain_Layer.UserAGG.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer
{
    public class User : AggregateRoot
    {
        public User(string userName, string email, PhoneBook phoneBook)
        {
            Guard(userName, email);
            UserName = userName;
            Email = email;
            PhoneBook = phoneBook;
            DeleteStatus = false;
        }
        public string  UserName{ get;private set; }
        public string  Email{ get;private set; }
        public PhoneBook PhoneBook { get;private set; }
        public bool DeleteStatus{ get;private set; }
        public DateTime DeleteDate{ get;private set; }

        public static User Register(string e) {
           
            var U = new User("", e, null);

            U.AddDomainEvent(new UserRegistered(U.Id, e));

            return U;   
        }

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
