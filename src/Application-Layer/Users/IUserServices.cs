using Application_Layer.Products.DTOs;
using Application_Layer.Users.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Users
{
    public interface IUserServices
    {

        // useCase For User Entity
        void CreateNewUser(AddUserDTO command);
        void EditUser(EditeUserDTO command);
        void DeleteUser(DeleteUserDTO guid);
        UserDTO GetUserById(long guid);
        List<UserDTO> GetAllUser();
    }
}
