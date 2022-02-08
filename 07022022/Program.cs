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
    }
}