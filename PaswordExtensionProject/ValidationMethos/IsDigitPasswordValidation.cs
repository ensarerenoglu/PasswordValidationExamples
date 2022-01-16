using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaswordExtensionProject.ValidationMethos
{
    public class IsDigitPasswordValidation : IPasswordValidation
    {
        public bool isValid(string str)
        {
            return str.Any(x => char.IsDigit(x));
        }
    }
}
