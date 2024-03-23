using Domain_Layer.Products;
using Domain_Layer.Users;
using Domain_Layer.Users.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.Prsistent.Memory.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly dbContext dbContext;
        public UserRepository(dbContext _dbContext)
        {
            dbContext = _dbContext; 
        }
        public void Add(User user)
        {
           dbContext.users.Add(user);   
        }

        public User GetUserById(Guid id)
        {
            return dbContext.users.FirstOrDefault(i => i.uId == id);
        }

        public List<User> GetUsers()
        {
            return dbContext.users.ToList();
        }

        public bool NotExist(Guid guid)
        {
            return dbContext.users.Any(u=>u.uId == guid);
        }

        public void SaveEveryThings()
        {
            //
        }

        public void Update(User user)
        {
            var old = GetUserById(user.uId);
            dbContext.users.Remove(old);
            dbContext.users.Add(user);
        }
    }
}
