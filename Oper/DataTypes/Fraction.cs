using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oper.DataTypes
{
    internal class Fraction
    {
        private int _denominator;
        public int Numerator { get; set; }
        public int Denominator { 
            get { return _denominator; } 
            set
            {
                if (value == 0) throw new Exceptions.FractionException("Denominator zero");
                else _denominator = value;
            }
        }
        public Fraction reduce()
        {
            int g = gcd(this.Numerator, this.Denominator);
            return new Fraction
            {
                Numerator = this.Numerator / g,
                Denominator = this.Denominator / g
            };
        }
        public override string ToString()
        {
            return $"({this.Numerator} / {this.Denominator})";
        }
        public static int gcd(int a, int b)
        {
            if (a == b)
            {
                return a;
            }
            else if (a > b)
            {
                if (b == 0) return a;
                else return gcd(b, a % b);
            }
            else
            {
                if (b == 0) return a;
                else return gcd(b, a % b);
            }
        }
        public static int lcm(int a, int b)
        {
            int n = a * b;
            n /= gcd(a, b);
            return n;
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction { Numerator = f1.Numerator * f2.Numerator, Denominator = f1.Denominator * f2.Denominator }.reduce();
        }
        public static Fraction operator *(Fraction f1, int n)
        {
            return new Fraction { Numerator = f1.Numerator * n, Denominator = f1.Denominator }.reduce();
        }
        public static Fraction operator *(int n, Fraction f1)
        {
            return new Fraction { Numerator = f1.Numerator * n, Denominator = f1.Denominator }.reduce();
        }

        public static Fraction operator /(Fraction f1, int n)
        {
            if(n == 0)
            {
                throw new Exceptions.FractionException("Divided by 0");
            }
            else
                return new Fraction { Numerator = f1.Numerator, Denominator = f1.Denominator * n }.reduce();
        }
        public static Fraction operator /(int n, Fraction f1)
        {
            if(n == 0)
            {
                return new Fraction { Numerator = 0, Denominator = f1.Numerator }.reduce();
            }
            else 
                return new Fraction { Numerator = f1.Numerator, Denominator = f1.Denominator * n }.reduce();
        }
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            return new Fraction { Numerator = f1.Numerator * f2.Denominator, Denominator = f1.Denominator * f2.Numerator }.reduce();
        }

        public static Fraction operator + (Fraction f1, Fraction f2)
        {
            return new Fraction { Numerator = (f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator), Denominator = f1.Denominator * f2.Denominator }.reduce();
        }
        public static Fraction operator +(Fraction f1, int n)
        {
            return ((new Fraction { Numerator = n, Denominator = 1 }) + f1).reduce();
        }
        public static Fraction operator +(int n, Fraction f1)
        {
            return ((new Fraction { Numerator = n, Denominator = 1 }) + f1).reduce();
        }

        public static Fraction operator - (Fraction f1, Fraction f2)
        {
            return (new Fraction { Numerator = f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator, Denominator =  f1.Denominator * f2.Denominator }).reduce();
        }
        public static Fraction operator - (Fraction f1, int n)
        {
            int res = n - (2 * n);
            return (f1 + res).reduce();
        }
        public static Fraction operator -(int n, Fraction f1)
        {
            int res = n - (2 * n);
            return (res + f1).reduce();
        }
    }
}
