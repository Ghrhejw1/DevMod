using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validators
{
    public class PasswordValidator : IValidator
    {
        public bool Validate(string validateObject)
        {
            if (string.IsNullOrEmpty(validateObject))
                return false;

            if (validateObject.Length < 8 || validateObject.Length > 20)
               return false;

            bool UpperCase = false;
            bool Digit = false;
            bool SpecialChar = false;

           foreach (char c in validateObject)
            {
                if (char.IsUpper(c))
                   UpperCase = true;
                else if (char.IsDigit(c))
                Digit = true;
                else if ("!@#$%^&*-_".Contains(c))
                    SpecialChar = true;
           }

            return UpperCase && Digit && SpecialChar;
        }
         
    }
}
