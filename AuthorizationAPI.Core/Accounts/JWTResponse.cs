namespace AuthorizationAPI.Core.Account
{
    public class JWTResponse
    {
        public bool HasError { get; set; }
        public string? Error { get; set; }
    }
}
