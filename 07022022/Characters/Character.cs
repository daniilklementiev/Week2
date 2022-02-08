using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Characters
{
    internal class Character
    {
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public override string ToString()
        { 
            return String.Format("HP: {0}, AT: {1}, DEF: {2}", HP, Attack, Defense);
        }

        public static int operator * (Character c1, Character c2)
        {
            int damage1 = c2.Attack - c1.Defense;
            if (damage1 > 0) c1.HP -= damage1;
            else c1.HP -= 1;
            int damage2 = c1.Attack - c2.Defense; 
            if(damage2 > 0) c2.HP -= damage2;
            else c2.HP -= 1;
            return damage1 + damage2;
        }
        
        
    }

}
