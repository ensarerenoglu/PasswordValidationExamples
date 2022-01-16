using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.Education.ExtensionMethods.Interface;
using UnluCo.Education.ExtensionMethods.Validations;

namespace UnluCo.Education.ExtensionMethods.Factory
{
    public class ValidatorFactory
    {
        public ICustomPasswordValidator FactoryMethod(ValidatorsEnum validatorsEnum)
        {
            ICustomPasswordValidator validator = null;
            switch (validatorsEnum)
            {
                case ValidatorsEnum.Easy:
                    validator = new EasyPasswordValidator();
                    return validator;
                    
                case ValidatorsEnum.Hard:
                    validator = new HardPasswordValidator();
                    return validator;
                    
            }
            throw new InvalidOperationException("Type is invalid!");
        }
    }
}
