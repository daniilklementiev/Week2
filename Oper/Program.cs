using System;

namespace Oper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operations");
            /*var c0 = new DataTypes.Complex { Re = 0, Im = 0 };
            var c1 = new DataTypes.Complex { Re = 1, Im = -2 };
            var c2 = new DataTypes.Complex { Re = 2, Im = -3 };
            var c3 = new DataTypes.Complex { Re = 0, Im = 1 };
            Console.WriteLine($"{c1} + {c2} = {c1+c2}");
            Console.WriteLine();
            Console.WriteLine($"{c1} - {c2} = {c1-c2}");
            Console.WriteLine();
            Console.WriteLine($"{c3} x {c3} = {c3*c3}");
            Console.WriteLine();
            try
            {
                Console.WriteLine($"{c1} / {c3} = {c1 / c3}");
                Console.WriteLine($"{c3} / {c3} = {c1 / c3}");
               // Console.WriteLine($"{c3} / {c0} = {c3 / c0}");
            }
            catch (Exceptions.ComplexException ex)
            {
                Console.WriteLine("Выброшено исключение: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Неизвестное исключение: " + ex.Message);
            }*/

           // var f0 = new DataTypes.Fraction { Denominator = 0, Numerator = 1 };
            var f1 = new DataTypes.Fraction { Numerator = 1, Denominator = 2 };
            var f2 = new DataTypes.Fraction { Numerator = 2, Denominator = 3 };
            try
            {
                Console.WriteLine(f1[0]); 
                Console.WriteLine(f1[1]); 
                
                Console.WriteLine($"{f1} + {f2} = {f1 + f2}");
                Console.WriteLine($"{f1} - {f2} = {f1 - f2}");
                Console.WriteLine($"{f1} * {f2} = {f1 * f2}");
                Console.WriteLine($"{f1} / {f2} = {f1 / f2}");
                Console.WriteLine($"{0} / {f1} = {0 / f1}");
                Console.WriteLine($"{f1} / {0} = {f1 / 0}");
                Console.WriteLine(f1[2]);

            }
            catch (Exceptions.FractionException ex)
            {
                Console.WriteLine("Выброшено исключение: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Неизвестное исключение: " + ex.Message);
            }

        }
    }
}