using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Fire : IPokemon
    {
        public Fire() 
        {
        }
        public void Type() 
        {
            Console.WriteLine("Congratulations, fire types are pretty busted");
        }

        public void Strength() 
        {
            Console.WriteLine("You eat leaf pokemon for breakfast");
        }
        public void Weakness()
        {
            Console.WriteLine($"Look out for them water types though.");
            Console.Beep(550, 1300);
            Console.Beep(700, 500);
            Console.Beep(500, 300);
            Console.Beep(300, 1300);
        }
    }
}
