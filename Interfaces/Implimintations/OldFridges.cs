using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Implimintations
{
    internal class OldFridges : Fridge, Interfaces.IDiscountable
    {
        public float Discount { get; set; }
        public float newPrice { get { return (Price - (Price * (Discount / 100))); } }
        
        public void PrintDisc()
        {
            Console.WriteLine($"{Name} with {Discount}% costs {newPrice}. Old price : {Price}");
        }
    }
}
