using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.Education.ExtensionMethods.Factory;
using UnluCo.Education.ExtensionMethods.Interface;

namespace UnluCo.Education.ExtensionMethods.Extension
{
    public static class StringExtensions
    {
        
        // 5 parametre alan zamanla da artabilen bir metod haline getirlecek, parametre sayısı artsa da içerideki kod bloğu değişmemeli 
        // Gang of 4, 24-25 tasarım deseni var. Her duruma karşı bir best practise geliştirilmiş, bunlara bak

        public static bool IsValidPassword(this string str, ValidatorsEnum validatorsEnum)
        {
            var validatorFactory = new ValidatorFactory();
            var validator = validatorFactory.FactoryMethod(validatorsEnum);
            
            return validator.isValid(str);

        }
    }
}
