using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaswordExtensionProject.ValidationMethos
{
    public interface IPasswordValidation
    {
        public bool isValid(string str);
    }
}
