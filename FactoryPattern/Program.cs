namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n" +
                "");
            Console.WriteLine("---------------------------------------------------------\n" +
                "");
            Console.WriteLine("Would you like to find out what type of Pokemon you are?");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                  YES      NO");
            Console.WriteLine("\n" +
                "");
            var userYesNo = Console.ReadLine().ToLower();
            if (userYesNo == "yes") 
            {
                Console.WriteLine("\n" +
                    "\n" +
                    "");
                Console.WriteLine("Nice! I can find this out very easily");
                Console.WriteLine("" +
                    "");
                Console.WriteLine("PRESS ENTER");
                Console.ReadLine();
            }
            else 
            {
                return;
            }
            Console.WriteLine("" +
                "");
            Console.WriteLine("Would you believe me if I told you I can find your pokemon type through your favorite food?");
            Console.WriteLine();
            Console.WriteLine("PRESS ENTER");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("It's true and I have a 95% accuracy rating.");
            Console.WriteLine();
            Console.WriteLine("PRESS ENTER");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("And if you doubt my abilities then go ahead and tell me your favorite food..... be specific");
            Console.WriteLine();
            Console.WriteLine("Go on, what's your favorite food then?");
            Console.WriteLine();
            string userType = Console.ReadLine().ToLower();
            IPokemon instance = WhosThatPokemon.GetPokemon(userType);

            Console.Beep(480, 200);

            Console.Beep(1568, 200);

            Console.Beep(1568, 200);

            Console.Beep(1568, 200);



            Console.Beep(734, 200);

            Console.Beep(784, 200);

            Console.Beep(784, 200);

            Console.Beep(784, 200);


            Console.Beep(370, 200);

            Console.Beep(392, 200);

            Console.Beep(370, 200);

            Console.Beep(392, 200);

            Console.Beep(392, 400);

            Console.Beep(37, 2020);

            Console.WriteLine($"\n" +
                $"\n" +
                $"YOU ARE AAAAAAAAA..... ");

            Console.Beep(37, 3000);

            Console.WriteLine("\n" +
                "&$#!!$^&*%!!#@!@\n" +
                "");

            Console.Beep(37, 1200);

            //Console.WriteLine($"{WhosThatPokemon.}");
            instance.Type();
            Console.WriteLine();
            instance.Strength();
            Console.WriteLine();
            instance.Weakness();
            Console.Beep(37, 2000);
            Console.ReadLine();
        }
    }
}
