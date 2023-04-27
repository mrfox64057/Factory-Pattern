using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Leaf : IPokemon
    {
        public Leaf() 
        {
        }

        public void Type()
        {
            Console.WriteLine("LEAF POKEMON!");
        } 
        public void Strength()
        {
            Console.WriteLine("You would absolutely destroy a water type.");
        }
        public void Weakness()
        {
            Console.WriteLine($"You are also weak to the fire type poke mans.");
            Console.Beep(450, 500);
            Console.Beep(900, 100);
            Console.Beep(800, 100);
            Console.Beep(420, 200);
            Console.Beep(300, 400);
            Console.Beep(200, 500);
        }
    }
}
