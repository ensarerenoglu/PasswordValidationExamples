using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaswordExtensionProject.ValidationMethos
{
    public class IsLengthValidPasswordValidation : IPasswordValidation
    {
        public bool isValid(string str)
        {
            if (str.Length >6 )
            {
                return true;
            }
            return false;
        }
    }
}
