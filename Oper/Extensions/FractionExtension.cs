using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oper.Extensions
{
    public static class FractionExtension
    {
        public static DataTypes.Fraction Inverse(this DataTypes.Fraction f)
        {
            return new DataTypes.Fraction { Numerator = f.Denominator, Denominator = f.Numerator };
        }
        public static DataTypes.Fraction Abs(this DataTypes.Fraction f)
        {
            return new DataTypes.Fraction { Numerator = Math.Abs(f.Numerator), Denominator = Math.Abs(f.Denominator) };
        }
    }
}
