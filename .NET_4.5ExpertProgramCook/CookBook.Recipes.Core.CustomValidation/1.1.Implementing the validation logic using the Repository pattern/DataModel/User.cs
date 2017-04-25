using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Recipes.Core.CustomValidation.DataModel
{
    public class User
    {
        public String UserName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String Password { get; set; }
    }
}
