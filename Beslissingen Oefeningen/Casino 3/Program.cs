using System;

namespace Casino_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random die = new Random();

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Take your pick (1-6):");
                int number = Convert.ToInt32(Console.ReadLine());
                int dieroll = die.Next(1, 7);
                
                if (number == dieroll)
                //if(true)
                {
                    Console.WriteLine("Good guess.");
                }
                else
                {
                    Console.WriteLine("You lose.");
                    Environment.Exit(0);
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nA WINNER IS YOU!\n");
            Console.ResetColor();
        }
    }
}
