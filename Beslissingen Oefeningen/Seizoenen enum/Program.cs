using System;

namespace Seizoenen_enum
{
    class Program
    {
        enum Seasons { Winter, Lente, Zomer, Herfst}
        static void Main(string[] args)
        {
            Console.WriteLine($"Maandnummer: ");
            double monthToSeason = Math.Floor((Convert.ToDouble(Console.ReadLine()) -1) / 3);
            Seasons season = new();

            switch (monthToSeason)
            {
                case 0:
                    season = Seasons.Winter;
                    break;
                case 1:
                    season = Seasons.Lente;
                    break;
                case 2:
                    season = Seasons.Zomer;
                    break;
                case 3:
                    season = Seasons.Herfst;
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    Environment.Exit(1);
                    break;
            }

            Console.WriteLine($"Het seizoen van die maand is de {season}.");

            if (season == Seasons.Lente || season == Seasons.Zomer)
            {
                Console.WriteLine("Het is een warm seizoen.");
            }
            else
            { 
                Console.WriteLine("Het is een koud seizoen.");
            }
        }
    }
}
