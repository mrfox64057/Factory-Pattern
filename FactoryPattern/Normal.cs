using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Normal : IPokemon
    {
        public Normal() 
        {
        }

        public void Type()
        {
            Console.Beep(37, 3500);
            Console.WriteLine("sighs* another normie");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Beep(37, 15000);
        } 
        public void Strength()
        {
            Console.WriteLine("\n" +
                "Oh you are still here... \n" +
                "");
            Console.WriteLine("You are not strong against any other type");
        }
        public void Weakness()
        {
            Console.WriteLine("You are not weak to any other type.");
            Console.Beep(240, 700);
            Console.Beep(329, 350);
            Console.Beep(379, 300);
            Console.Beep(319, 350);
            Console.Beep(389, 300);
            Console.Beep(339, 350);
            Console.Beep(369, 300);
            Console.Beep(309, 620);
            Console.Beep(250, 800);
        }
    }
}
