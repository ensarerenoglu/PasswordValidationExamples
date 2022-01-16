using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.Education.ExtensionMethods.Interface;

namespace UnluCo.Education.ExtensionMethods.Validations
{
    public class HardPasswordValidator : ICustomPasswordValidator
    {
        public bool isValid(string str)
        {
            var result = false;
            if (str.Any(x => char.IsDigit(x)) 
                && str.Any(x => char.IsUpper(x)) 
                && str.Any(x => char.IsLower(x))
                && str.Length > 6
                && !str.Contains(" "))
            {
                result = true;
            }
            
            return result;
        }
    }
}
