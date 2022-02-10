using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oper.DataTypes
{
    public class Complex : ICloneable
    {
        public double Re { get; set; }  // Действительная час
        public double Im { get; set; }  // Мнимая часть
        public double Abs { get => Math.Sqrt(this.Re * this.Re + this.Im * this.Im); }
        public Complex Conjugate
        {
            get => new Complex { Re = this.Re, Im = -this.Im };
        }
        public override string ToString()
        {
            return $"({this.Re}" + (this.Im > 0 ? " + " : " - ") + $"{Math.Abs(this.Im)}i)";
        }

        public object Clone()
        {
            return new Complex { Re = this.Re, Im = this.Im };
        }

        public static Complex operator + (Complex c1, Complex c2)
        {
            return new Complex
            {
                Re = c1.Re + c2.Re,
                Im = c1.Im + c2.Im
            };
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex
            {
                Re = c1.Re - c2.Re,
                Im = c1.Im - c2.Im
            };
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex
            {
                Re = c1.Re * c2.Re - c1.Im * c2.Im,
                Im = c1.Im * c2.Re + c1.Re * c2.Im
            };
        }
        public static Complex operator /(Complex c1, Complex c2)
        {
            if(c2.Abs == 0)
            { // Исключительная ситуация
                throw new Exceptions.ComplexException("Complex division by 0");
            }
            return new Complex
            {
                Re = (c1.Re * c2.Re + (c1.Im * c2.Im)) / (c2.Re * c2.Re + c2.Im * c2.Im),
                Im = ((c1.Im * c2.Re) - (c1.Re * c2.Im)) / (c2.Re * c2.Re + c2.Im * c2.Im)
            };
        }

        public static Complex operator + (Complex c1, double r) {return new Complex { Re = c1.Re + r, Im = c1.Im }; }
        public static Complex operator * (Complex c1, double r) { return new Complex { Re = c1.Re * r, Im = c1.Im * r };}
        public static Complex operator - (Complex c1, double r) { return new Complex { Re = c1.Re - r, Im = c1.Im }; }
        public static Complex operator / (Complex c1, double r)
        {
            if (r == 0) throw new Exceptions.ComplexException("Complex divided by real 0");
            return new Complex { Re = c1.Re / r, Im = c1.Im / r };
        }
    }
}
