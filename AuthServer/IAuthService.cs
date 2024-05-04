namespace AuthServer
{
    public interface IAuthService
    {
        Task<string> GenerateJwtTokenAsync(User user);
       
    }
}
