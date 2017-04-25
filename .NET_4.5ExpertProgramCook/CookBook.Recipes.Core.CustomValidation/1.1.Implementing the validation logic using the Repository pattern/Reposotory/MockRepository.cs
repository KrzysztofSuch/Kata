using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookBook.Recipes.Core.CustomValidation.DataModel;

namespace CookBook.Recipes.Core.CustomValidation.Reposotory
{
    public class MockRepository : IReposotory {
        private static List<User> _users;

        public MockRepository() {
            _users = new List<User>();
            _users.Add(new User(){UserName = "Chris", DateOfBirth = new DateTime(1988,1,22), Password = "pass"});
            _users.Add(new User(){UserName = "Ann", DateOfBirth = new DateTime(1986,7,17), Password = "pass2"});
        }

        public void AddUser(User user) {
            _users.Add(user);
        }
        public bool IsUsernameUniqe(string name) {
            bool exists = _users.Exists(u => u.UserName == name);
            return !exists;
        }
    }
}
