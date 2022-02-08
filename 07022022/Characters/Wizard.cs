using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Characters
{
    internal class Wizard : Character
    {
        public Wizard()
        {
            base.HP = 100;
            base.Attack = 7;
            base.Defense = 10;
        }
        public override string ToString()
        {
            return $"Wizard ({base.ToString()})";
        }
    }
}
