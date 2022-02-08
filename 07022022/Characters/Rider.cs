using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Characters
{
    internal class Rider : Character
    {
        public Rider()
        {
            base.HP = 100;
            base.Attack = 10;
            base.Defense = 7;
        }

        public override string ToString()
        {
            return $"Rider  ({base.ToString()})";
        }
    }
}
