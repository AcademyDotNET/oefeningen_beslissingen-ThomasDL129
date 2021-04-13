using System;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Take your pick (1-6):");
            int number = Convert.ToInt32(Console.ReadLine());
            Random die = new();
            int dieroll = die.Next(1, 7);

            if(number == dieroll)
            {
                Console.WriteLine("A WINNER IS YOU!");
            }
            else
            {
                Console.WriteLine("You lose.");
            }
        }
    }
}
