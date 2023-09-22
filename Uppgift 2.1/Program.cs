using System;

namespace uppgift
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken är din favoritbok?");
            string favvobok = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Din favoritbok är " + favvobok + ".");
            Console.ReadKey();


        }


    }

}