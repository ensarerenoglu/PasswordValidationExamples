using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCo.Education.ExtensionMethods.Interface
{
    public interface ICustomPasswordValidator
    {
        bool isValid(string str);
    }
}
