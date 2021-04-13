using System;

namespace Orakel_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Man of vrouw?");
            bool gender = GenderChecker(Console.ReadLine().ToLower());
            Console.WriteLine("Hoe oud bent u?");
            int age = Convert.ToInt32(Console.ReadLine());
            int maxAge;
            int minPrediction = 5;

            if (gender)
            {
                maxAge = 150;
            }
            else
            {
                maxAge = 120;
            }

            if ((maxAge - age) < minPrediction)
            {
                Console.WriteLine("Amai ge ziet er nog goed uit!");
            }
            else
            {
                Random years = new Random();
                Console.WriteLine($"Je zal nog {years.Next(minPrediction, maxAge - age + 1)} jaar leven.");
            }
        }
        public static bool GenderChecker(string gender)
        {
            if (gender == "man" || gender == "m")
            {
                return false;
            }
            else if (gender == "vrouw" || gender == "v")
            {
                return true;
            }
            else
            {
                Environment.Exit(1);
            }
            return false;
        }
    }
}
