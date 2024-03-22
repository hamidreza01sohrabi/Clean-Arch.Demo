namespace Application_Layer.Users.DTOs
{
    public class EditeUserDTO
    {
        public EditeUserDTO() { }
        //public EditeUserDTO(Guid uId, string userName, string email, string phoneNumber)
        //{
        //    this.uId = uId;
        //    UserName = userName;
        //    Email = email;
        //    PhoneNumber = phoneNumber;
        //}

        public Guid uId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }
}
