using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class WhosThatPokemon
    {
        public static IPokemon GetPokemon(string yourType)
        {
            switch (yourType.ToLower())
            {
                case "tacos":
                    return new Water();
                case "fire":
                    return new Water();
                case "cookies":
                    return new Water();
                case "candy":
                    return new Water();
                case "peanuts":
                    return new Water();
                case "seafood":
                    return new Water();
                case "pizza":
                    return new Fire();
                case "leaf":
                    return new Fire();
                case "steak":
                    return new Fire();
                case "burger":
                    return new Fire();
                case "fries":
                    return new Fire();
                case "ice cream":
                    return new Fire();
                case "chips":
                    return new Leaf();
                case "water":
                    return new Leaf();
                case "salad":
                    return new Leaf();
                case "mushrooms":
                    return new Leaf();
                case "carrots":
                    return new Leaf();
                case "muffins":
                    return new Leaf();
                case "0":
                    return new Mew();
                case "1":
                    return new Mew();
                case "2":
                    return new Mew();
                case "3":
                    return new Mew();
                default:
                    return new Normal();
            }
        }
    }
}
   

