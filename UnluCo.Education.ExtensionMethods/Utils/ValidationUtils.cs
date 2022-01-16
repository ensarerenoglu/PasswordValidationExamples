using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.Education.ExtensionMethods.Extension;

namespace UnluCo.Education.ExtensionMethods.Utils
{
    public class ValidationUtils
    {
        
        public static bool ValidatePassword(string str)
        {
            return str.IsValidPassword(ValidatorsEnum.Hard);
        }
    }
}
