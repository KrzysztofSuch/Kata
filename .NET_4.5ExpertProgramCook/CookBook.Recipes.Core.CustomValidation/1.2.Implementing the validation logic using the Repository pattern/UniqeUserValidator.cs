using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookBook.Recipes.Core.CustomValidation.Reposotory;

namespace CookBook.Recipes.Core.CustomValidation._1._2.Implementing_the_validation_logic_using_the_Repository_pattern
{
    public class UniqeUserValidator : ValidationAttribute {
        public IReposotory Reposotory { get; set; }

        public UniqeUserValidator() {
            this.Reposotory = new MockRepository();
        }

        public override bool IsValid(object value) {
            string valueToTest = Convert.ToString(value);
            return this.Reposotory.IsUsernameUniqe(valueToTest);
        }
    }
}
