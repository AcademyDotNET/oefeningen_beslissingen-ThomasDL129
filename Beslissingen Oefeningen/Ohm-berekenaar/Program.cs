using System;

namespace Ohm_berekenaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat wil je berekenen? Spanning (U), Stroomsterkte (I) of Weerstand (R)?");
            string input = Console.ReadLine().ToLower();
            double voltage, current, resistance;

            if (input == "spanning" || input == "u")
            {
                Console.WriteLine("Wat bedraagt de stroomsterkte?");
                current = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Wat bedraagt de weerstand?");
                resistance = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"De spanning bedraagt: {current * resistance} V");
            }
            else if (input == "stroomsterkte" || input == "i")
            {
                Console.WriteLine("Wat bedraagt de spanning?");
                voltage = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Wat bedraagt de weerstand?");
                resistance = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"De spanning bedraagt: {voltage / resistance} A");
            }
            else if (input == "weerstand" || input == "r")
            {
                Console.WriteLine("Wat bedraagt de spanning?");
                voltage = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Wat bedraagt de stroomsterkte?");
                current = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"De spanning bedraagt: {voltage * current} Ohm");
            }
            else
            {
                Console.WriteLine("Geen geldige invoer. Het programma gaat nu sluiten.");
                Environment.Exit(1);
            }
        }
    }
}
