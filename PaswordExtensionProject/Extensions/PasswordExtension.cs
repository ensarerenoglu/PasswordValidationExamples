using PaswordExtensionProject.ValidationMethos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaswordExtensionProject.Extensions
{
    public static class PasswordExtension
    {

        public static bool IsPasswordValid(this string str)
        {

            foreach (var item in PasswordValidation.ValidatorList())
            {
                if (!item.isValid(str))
                    return false;
            }
            return true;
        }
    }
}
