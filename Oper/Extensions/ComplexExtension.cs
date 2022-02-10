using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oper.Extensions
{
    public static  class ComplexExtension
    {
        public static DataTypes.Complex Reflect(this DataTypes.Complex c)
        {
            return new DataTypes.Complex { Re = c.Im, Im = c.Re };
        }
    }
}
