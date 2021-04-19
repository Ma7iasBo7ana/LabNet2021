using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsExtensionMethods.Exceptions
{
    class CustomException:Exception
    {
        public CustomException(string mensaje):base($"{mensaje} esto es una Custom Exception")
        {
            
        }
    }
}
