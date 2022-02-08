using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Characters
{
    internal class Archer : Character
    {
        public Archer()
        {
            base.HP = 100;       // свойства  родителя доступны в наследнике
            base.Attack = 10;
            base.Defense = 7;
        }

        public override string ToString()
        {
            return $"Archer ({base.ToString()})";
        }
    }
}
