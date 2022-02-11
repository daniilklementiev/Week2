﻿
namespace Interfaces
{
    using Implimintations;
    using Interfaces;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Shop!");
            var Products = new List<Product>();
            Products.Add(new Fridge     { Name = "Dnepr",                 Price = 100500 });
            Products.Add(new Fridge     { Name = "Frost",                 Price = 100499 });
            Products.Add(new OldFridges { Name = "Sniege",                Price = 10499, Discount = 25 });
            Products.Add(new Book       { Name = "Knuth",                 Price = 500 });

            Console.WriteLine("\bAll products");
            foreach (var item in Products)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nPrintable Products");
            foreach (var item in Products)
            {
                if (item is IPrintable)
                {
                    (item as IPrintable)?.Print();
                }
            }
            Console.WriteLine("\nWith discount");
            foreach (var item in Products)
            {
                if (item is IDiscountable)
                {
                    OldFridges ip = item as OldFridges;
                    Console.WriteLine($"{item.Name} with {ip?.Discount}% costs {ip?.newPrice}. Old price : {item.Price}");
                }
            }
        }
    }
}