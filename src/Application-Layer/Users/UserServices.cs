using Application_Layer.Users.DTOs;
using Domain_Layer.Users;
using Domain_Layer.Users.Repository;

namespace Application_Layer.Users
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository repository;
        public UserServices(IUserRepository _repository)
        {
            repository = _repository;
        }

        public void CreateNewUser(AddUserDTO command)
        {
            var user = new User(command.UserName, command.Email, command.PhoneNumber);
            repository.Add(user);
            repository.SaveEveryThings();
        }

        public void DeleteUser(DeleteUserDTO guid)
        {
            var oldUser = repository.GetUserById(guid.uId);
            oldUser.userDLT();
            repository.Update(oldUser);
            repository.SaveEveryThings();
        }

        public void EditUser(EditeUserDTO command)
        {
            var u = repository.GetUserById(command.uId);
            u.Edite(command.UserName, command.Email, command.PhoneNumber);
            repository.Update(u);
            repository.SaveEveryThings();
        }

        public List<UserDTO> GetAllUser()
        {
            return repository.GetUsers().Select(U => new UserDTO() { UserName = U.UserName, Email = U.Email, PhoneNumber = U.PhoneNumber }).ToList();
        }

        public UserDTO GetUserById(Guid guid)
        {
            var x = repository.GetUserById(guid);
            return new UserDTO() { UserName = x.UserName, Email = x.Email, PhoneNumber = x.PhoneNumber };
        }
    }
}
