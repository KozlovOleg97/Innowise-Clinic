namespace AuthorizationAPI.Core.Accounts
{
    public class UpdateDoctorRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Phone { get; set; }
        public string? ImagePath { get; set; }
        public IFormFile? File { get; set; }
        public bool HasError { get; set; }
        public string? Error { get; set; }
        public string? UserName { get; set; }
    }
}
