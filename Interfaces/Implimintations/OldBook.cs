﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Implimintations
{
    internal class OldBook : Product, Interfaces.IDiscountable, Interfaces.IPrintable
    {
        public float Discount { get; set; }
        public float newPrice { get { return (Price - (Price * (Discount / 100))); } }
        public void Print()
        {
            Console.WriteLine($"The oldbook: {Name}");
        }
    }
}
