using Application_Layer.Orders;
using Application_Layer.Users;
using Application_Layer.Users.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CreateYourOrder_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserServices userServices;

        public UserController(IUserServices _userServices)
        {
            userServices = _userServices;
        }

        [Route("/AddinU")]
        [HttpPost]
        public string AddinNewUser(AddUserDTO userDTO) {

            userServices.CreateNewUser(userDTO);
            return "OK, crewate a New User is done";
        }

        [Route("/EditingU")]
        [HttpPut]
        public string EditingOldUser(EditeUserDTO editeUser) {
            
            userServices.EditUser(editeUser);
            return "OK, edite old user is done";
        }

        [Route("/DeletingU")]
        [HttpDelete]
        public string DeletingUser(DeleteUserDTO deleteUser) {
            userServices.DeleteUser(deleteUser);
            return "OK, deleting exist user is done";
        }


        [Route("/GetOneUser")]
        [HttpGet]
        public UserDTO GettingOneUser(Guid guid) { 
            
            return  userServices.GetUserById(guid);
        }

        [Route("/GetUsers")]
        [HttpGet]
        public List<UserDTO> GetUsers()
        {

            return userServices.GetAllUser();
        }
    }
}
