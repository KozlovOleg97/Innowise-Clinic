namespace AuthorizationAPI.Core.Accounts
{
    public class UpdatePatientRequest
    {
        public int PatientId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public string? Address { get; set; }
        public string? IdCard { get; set; }
        public string? ImagePath { get; set; }
        public bool HasError { get; set; }
        public string? Error { get; set; }

    }
}
