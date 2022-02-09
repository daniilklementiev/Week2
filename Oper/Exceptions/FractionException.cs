using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oper.Exceptions
{
    internal class FractionException : Exception
    {
        public FractionException() : base("Invalid operation with Fraction(s)")
        {

        }
        public FractionException(String message) : base(message)
        {

        }
    }
}
