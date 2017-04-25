using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookBook.Recipes.Core.CustomValidation.DataModel;

namespace CookBook.Recipes.Core.CustomValidation.Reposotory
{
    public interface IReposotory {
        void AddUser(User user);
        Boolean IsUsernameUniqe(string name);
    }
}
