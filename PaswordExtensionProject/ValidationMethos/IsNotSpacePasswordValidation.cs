using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaswordExtensionProject.ValidationMethos
{
    public class IsNotSpacePasswordValidation : IPasswordValidation
    {
        public bool isValid(string str)
        {
            var result = false;
            if (!str.Contains(" "))
            {
                result = true;
            }
           return result;
        }
    }
}
