using System.Collections.Generic;
using System.Linq;

namespace Lab5
{
    public class UserRepository : IUserRepository
    {
        private IDictionary<string, User> users;

        public UserRepository(IEnumerable<User> users)
        {
            this.users = users.ToDictionary(x => x.UserName, y => y);
        }

        public bool CheckPassword(string userName, string password)
        {
            if (users.ContainsKey(userName))
            {
                var user = users[userName];
                return user.Password == password;
            }

            return false;
        }
    }
}
