namespace Lab5
{
    public class Task1
    {
        public IUserManager CreateUserManager(ILogger logger, IUserRepository userRepository)
        {
            return new UserManager(logger, userRepository);
        }
    }

    public class UserManager : IUserManager
    {
        private readonly ILogger logger;
        private readonly IUserRepository userRepository;

        public UserManager(ILogger logger, IUserRepository userRepository)
        {
            this.logger = logger;
            this.userRepository = userRepository;
        }
    }
}