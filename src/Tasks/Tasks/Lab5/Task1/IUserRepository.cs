namespace Lab5
{
    public interface IUserRepository
    {
        bool CheckPassword(string userName, string password);
    }
}
