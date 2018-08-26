using Lab5;
using System.Collections.Generic;

namespace Tasks.Lab5.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>
            {
                new User { UserName = "First", Password = "password"},
                new User { UserName = "Second", Password = "password"},
                new User { UserName = "Third", Password = "password"},
            };

            var userRepository = new UserRepository(users);
            var logger = new ConsoleLogger(); // todo: implement
            var manager = new UserManager(logger, userRepository); // todo: implement

            manager.Login("First", "password");
            manager.Logout("First");
        }
    }
}
