using System;

namespace Beslissingen_Oefeningen
{
    class Program
    {
        enum SoortenGewichten { Ondergewicht, Normaal, Overgewicht, Zwaarlijvig, Obees}
        static void Main(string[] args)
        {
            Console.Write("Lengte in m: ");
            double lengte = Convert.ToDouble(Console.ReadLine());
            Console.Write("Gewicht: ");
            double gewicht = Convert.ToDouble(Console.ReadLine());
            double bmi = Math.Round(gewicht / Math.Pow(lengte, 2), 1, MidpointRounding.AwayFromZero);
            SoortenGewichten soort;

            Console.Write("BMI: ");
            if (bmi <= 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(bmi);
                soort = SoortenGewichten.Ondergewicht;
                Console.WriteLine($"{soort}.");
            }
            else if (bmi > 18.5 && bmi <= 24.9)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(bmi);
                soort = SoortenGewichten.Normaal;
                Console.WriteLine($"{soort} gewicht.");
            }
            else if (bmi > 24.9 && bmi <= 29.9)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(bmi);
                soort = SoortenGewichten.Overgewicht;
                Console.WriteLine($"{soort}. Je loopt niet echt een risico, maar je mag niet dikker worden.");
            }
            else if (bmi > 29.9 && bmi <= 39.9)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(bmi);
                soort = SoortenGewichten.Zwaarlijvig;
                Console.WriteLine($"{soort} (obesitas). Verhoogde kans op allerlei aandoeningen zoals diabetes, hartaandoeningen en rugklachten. Je zou 5 tot 10 kg moeten vermageren.");
            }
            else if (bmi > 39.9)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(bmi);
                soort = SoortenGewichten.Obees;
                Console.WriteLine($"{soort}. Ernstige zwaarlijvigheid. Je moet dringend vermageren want je gezondheid is in gevaar (of je hebt je lengte of gewicht in verkeerde eenheid ingevoerd).");
            }
            Console.ResetColor();
        }
    }
}
