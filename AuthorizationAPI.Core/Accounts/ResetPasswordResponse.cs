namespace AuthorizationAPI.Core.Accounts
{
    public class ResetPasswordResponse
    {
        public bool HasError { get; set; }
        public string? Error { get; set; }
    }
}
