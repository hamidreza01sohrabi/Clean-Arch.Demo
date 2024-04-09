using Application_Layer.Users.DTOs;
using Domain_Layer.Shared;
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
            var user = new User(command.UserName, command.Email, new PhoneBook(new PhoneNumber(command.MobileNumber),new PhoneNumber(command.FaxNumber)));
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
            u.Edite(command.UserName, command.Email, new PhoneBook(new PhoneNumber(command.MobileNumber), new PhoneNumber(command.FaxNumber)));
            repository.Update(u);
            repository.SaveEveryThings();
        }

        public List<UserDTO> GetAllUser()
        {
            return repository.GetUsers().Select(U => new UserDTO() { UserName = U.UserName, Email = U.Email, MobileNumber = U.PhoneBook.Moblie.Tell, FaxNumber = U.PhoneBook.Fax.Tell }).ToList();
        }

        public UserDTO GetUserById(Guid guid)
        {
            var x = repository.GetUserById(guid);
            return new UserDTO() { UserName = x.UserName, Email = x.Email, MobileNumber = x.PhoneBook.Moblie.Tell, FaxNumber = x.PhoneBook.Fax.Tell };
        }
    }
}
