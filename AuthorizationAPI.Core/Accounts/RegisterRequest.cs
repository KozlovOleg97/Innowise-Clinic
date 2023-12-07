namespace AuthorizationAPI.Core.Account
{
    public class RegisterRequest
    {
        public string Email { get; set; }
        public string isEmailVerified { get; set; }
        public string ConfirmEmail { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int PhoneNumber { get; set; }
        public string ImagePath { get; set; }
    }
}
