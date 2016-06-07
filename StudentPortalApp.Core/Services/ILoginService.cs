namespace StudentPortalApp.Core.Services
{
    public interface ILoginService
    {
        bool AuthenticateUser(string username, string password);
    }
}