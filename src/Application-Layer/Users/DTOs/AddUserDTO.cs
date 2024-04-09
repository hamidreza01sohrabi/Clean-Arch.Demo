namespace Application_Layer.Users.DTOs
{
    public class AddUserDTO {
        public AddUserDTO(string userName, string email, string phoneNumber, string faxnumber)
        {
            UserName = userName;
            Email = email;
            MobileNumber = phoneNumber;
            FaxNumber = faxnumber;
        }

        public string UserName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string FaxNumber { get; set; }

    }
}
