using System;

namespace Kleurcode_weerstand
{
    class Program
    {
        enum Colour { zwart, bruin, rood, oranje, geel, groen, blauw, paars, grijs, wit}
        static void Main(string[] args)
        {
            Console.WriteLine("Geef de drie kleuren op van de weerstand:");
            int ring1 = ColourChecker(Console.ReadLine());
            int ring2 = ColourChecker(Console.ReadLine());
            int ring3 = ColourChecker(Console.ReadLine());

            Console.WriteLine($"De weerstand heeft een waarde van {ring1 * 10 + ring2 * Math.Pow(10, ring3)} Ohm");
        }

        public static int ColourChecker(string colour)
        {
            Colour myColour = new();

            switch (colour)
            {
                case "zwart":
                    myColour = Colour.zwart;
                    break;
                case "bruin":
                    myColour = Colour.bruin;
                    break;
                case "rood":
                    myColour = Colour.rood;
                    break;
                case "oranje":
                    myColour = Colour.oranje;
                    break;
                case "geel":
                    myColour = Colour.geel;
                    break;
                case "groen":
                    myColour = Colour.groen;
                    break;
                case "blauw":
                    myColour = Colour.blauw;
                    break;
                case "paars":
                    myColour = Colour.paars;
                    break;
                case "grijs":
                    myColour = Colour.grijs;
                    break;
                case "wit":
                    myColour = Colour.wit;
                    break;
                default:
                    Console.WriteLine("Kan invoer niet lezen.");
                    Environment.Exit(1);
                    break;
            }
            return (int)myColour;
        }
    }
}
