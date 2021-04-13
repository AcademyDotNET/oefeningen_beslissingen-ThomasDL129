using System;

namespace Schrikkeljaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vul een jaar in:");
            int jaar = Convert.ToInt32(Console.ReadLine());

            if (jaar % 4 == 0)
            {
                if (jaar % 100 != 0 || jaar % 100 == 0 && jaar % 400 == 0)
                {
                    Console.WriteLine($"{jaar} is een schrikkeljaar!");
                }
                else
                { 
                    Console.WriteLine($"{jaar} is geen schrikkeljaar.");
                }
            }
            else
            {
                Console.WriteLine($"{jaar} is geen schrikkeljaar.");
            }
        }
    }
}
