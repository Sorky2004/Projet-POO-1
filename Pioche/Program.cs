using System;
using Pioche;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player("Doe", "John");
            Player p2 = new Player("Smith", "Jane");

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
        }
    }
}