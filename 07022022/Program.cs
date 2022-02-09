using System;

namespace Week2
{
    class Services
    {
        public static Random random = new Random();
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            try { ExDemo();  }
            catch { Console.WriteLine("Method fault"); }
                
            return;

            Console.WriteLine("Hello World!");

            var world = new World();
            Console.WriteLine(world[1]);
            // Задача: выбрать двух случайных персонажей, "столкнуть" их
            int i1 = Services.random.Next(5);
            int i2;
            do { i2 = Services.random.Next(5); } while (i1 == i2);

            int damage = world[i1] * world[i2];
            Console.WriteLine($"{i1} vs {i2}: {world[i1]} {world[i2]}");
        }

        static void ExDemo()
        {
            Console.Write("Enter name: ");
            String name = Console.ReadLine();
            try
            {
                if(String.IsNullOrEmpty(name))
                {
                    throw new ArgumentException("Name is empty");
                }
                if (name.Contains(" "))
                {
                    throw new InvalidOperationException("Name contains space(s)");
                }
                Console.WriteLine($"Hello, {name}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}