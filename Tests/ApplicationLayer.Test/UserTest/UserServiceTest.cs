using Application_Layer.Orders.DTOS;
using Application_Layer.Orders;
using Application_Layer.Users;
using Application_Layer.Users.DTOs;
using Domain_Layer;
using Domain_Layer.Orders;
using Domain_Layer.Shared.Value_Objects;
using Domain_Layer.Users.Repository;
using FluentAssertions;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Test.UserTest
{
    public class UserServiceTest
    {
        private readonly UserServices userServices;
        private readonly IUserRepository userRepository;
        public UserServiceTest()
        {
            userRepository = NSubstitute.Substitute.For<IUserRepository>();
            userServices = new UserServices(userRepository);
        }
        
        [Fact]
        public void create_new_user_service()
        {
            //Arrange
            var User = new AddUserDTO("un", "e", "11111111111", "22222222222");
            //act
            userServices.CreateNewUser(User);

            //assert
            userRepository.Received(1).SaveEveryThings();   
        }
        [Fact]
        public void Delete_old_user_service()
        {
            //Arrange
            userRepository.GetUserById(1).Returns(new User("usernamesh","Emailesh",new PhoneBook(new PhoneNumber("00000000000"), new PhoneNumber("00000000555")))); 
            var UserToDelete = new DeleteUserDTO() { uId = 1};
            //act
            userServices.DeleteUser(UserToDelete);

            //assert
            userRepository.Received(1).SaveEveryThings();
        }

        [Fact]
        public void Edite_old_user_service()
        {
            //Arrange
            userRepository.GetUserById(Arg.Any<long>()).Returns(new User("usernamesh", "Emailesh", new PhoneBook(new PhoneNumber("00000000000"), new PhoneNumber("00000000555"))));
            var UserToEdite = new EditeUserDTO(11, "x", "email", "25865233332", "00000000000");
            //act
            userServices.EditUser(UserToEdite);

            //assert
            userRepository.Received(1).SaveEveryThings();
        }

        [Fact]
        public void get_user_by_id_service()
        {

            //arrang
            userRepository.GetUserById(Arg.Any<long>()).Returns(new User("usernamesh", "Emailesh", new PhoneBook(new PhoneNumber("00000000000"), new PhoneNumber("00000000555"))));
           
            //act
             var u = userServices.GetUserById(1);

            //assert
            u.Email.Should().Be("Emailesh");
        }


        [Fact]
        public void get_users_service()
        {
            //arrang
            userRepository.GetUsers().Returns(new List<User>() {
                new User("usernamesh", "Emailesh", new PhoneBook(new PhoneNumber("00000000000"), new PhoneNumber("00000000555"))),
                new User("unamesh", "Email", new PhoneBook(new PhoneNumber("00012000000"), new PhoneNumber("84020000555")))
            });

            //act
            var lst = userServices.GetAllUser();
            
            //assert
            lst.Should().HaveCount(2);
        }





    }
    }
