namespace Application_Layer.Users.DTOs
{
    public class AddUserDTO {
        public AddUserDTO(string userName, string email, string phoneNumber)
        {
            UserName = userName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }
}
