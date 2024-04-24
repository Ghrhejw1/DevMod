using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validators
{
    public class LoginValidator : IValidator
    {
        public bool Validate(string validateObject)
        {
            
            if (string.IsNullOrEmpty(validateObject))
               return false;

            if (validateObject.Length < 6 || validateObject.Length > 16)
                return false;

            foreach (char c in validateObject)
            {
               if (!char.IsLetter(c) || !char.IsLower(c))
                   return false;
            }

            return true;
            }
        }
    }

}
