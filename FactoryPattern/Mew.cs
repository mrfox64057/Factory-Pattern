using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Mew : IPokemon
    {
        public Mew()
        {
        }
        public void Type()
        {
            Console.WriteLine("I've never seen this pokemon...");
        }

        public void Strength()
        {
            Console.WriteLine("N/A");
            Console.WriteLine();
        }
        public void Weakness()
        {
            Console.WriteLine($"N/A");
            Console.Beep(750, 1200);
            Console.Beep(1000, 200);
            Console.Beep(600, 300);
            Console.Beep(1400, 92);
            Console.Beep(900, 200);
            Console.Beep(1500, 100);
            Console.Beep(800, 250);
        }
    }
}
