using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oper.Exceptions
{
    internal class ComplexException : Exception
    {
        public ComplexException() : base("Invalid operation with Complex number(s)")
        {

        }
        public ComplexException(String message) : base(message)
        {
                
        }
    }
}
