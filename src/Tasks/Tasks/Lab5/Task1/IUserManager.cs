namespace Lab5
{
    public interface IUserManager
    {
        void Login(string userName, string password);
        void Logout(string userName);
    }
}
