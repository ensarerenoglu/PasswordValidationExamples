using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaswordExtensionProject.ValidationMethos
{
    public class PasswordValidation
    {
        public static List<IPasswordValidation> ValidatorList()
        {
            List<IPasswordValidation> validators = new List<IPasswordValidation>();
            validators.Add(new IsDigitPasswordValidation());
            validators.Add(new IsUpperPasswordValidation());
            validators.Add(new IsNotSpacePasswordValidation());
            validators.Add(new IsLowerPasswordValidation());
            validators.Add(new IsLengthValidPasswordValidation());
            return validators;
        }
    }
}
