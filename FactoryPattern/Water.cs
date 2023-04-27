using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Water : IPokemon
    {
        public Water() 
        {
        }

        public void Type() 
        {
            Console.WriteLine("WATER, the best class there is!");
        }
        public void Strength()
        {
            Console.WriteLine("Fire types should be eeeeeeeeeaaaaassyyy pickins");
        }
        public void Weakness()
        {
            Console.WriteLine($"I'd keep my eye out for a leaf type pokemon..."); 
            Console.Beep(815, 1900);
            Console.Beep(780, 900);
        }
    }
}
