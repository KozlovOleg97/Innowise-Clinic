namespace AuthorizationAPI.Core.Accounts
{
    public class UpdateDoctorResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? PhoneNumber { get; set; }
        public string? ImagePath { get; set; }
        public bool HasError { get; set; }
        public string? Error { get; set; }
    }
}
