using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    internal class World
    {
        List<Characters.Character> Characters;
        public World()
        {
            Characters = new List<Characters.Character>();

            for (int i = 0; i < 5; i++)
            {
                switch (Services.random.Next(3))
                {
                    case 0: Characters.Add(new Characters.Archer()); break;
                    case 1: Characters.Add(new Characters.Rider()); break;
                    default: Characters.Add(new Characters.Wizard()); break;
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var ch in Characters)
            {
                sb.Append(ch);
                sb.Append('\n');
            }
            return sb.ToString();
        }
        public Characters.Character this[int i]
        {
            get
            {
                return Characters[i];
            }
        }

        public void Go()
        {
            Console.WriteLine(this);
            int res = Characters[0] * Characters[1];
            Console.WriteLine(this);
        }
    }
}
