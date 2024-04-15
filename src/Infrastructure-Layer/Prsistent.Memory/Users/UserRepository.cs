using Domain_Layer;
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

        public User GetUserById(long id)
        {
            return dbContext.users.FirstOrDefault(i => i.Id == id);
        }

        public List<User> GetUsers()
        {
            return dbContext.users.ToList();
        }

        public bool NotExist(long guid)
        {
            return dbContext.users.Any(u=>u.Id == guid);
        }

        public void SaveEveryThings()
        {
            //
        }

        public void Update(User user)
        {
            var old = GetUserById(user.Id);
            dbContext.users.Remove(old);
            dbContext.users.Add(user);
        }

    }
}
