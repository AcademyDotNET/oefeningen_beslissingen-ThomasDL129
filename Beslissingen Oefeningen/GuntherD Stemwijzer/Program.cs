using System;

namespace GuntherD_Stemwijzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Werk je veel?");

            if (Affirmation())
            {
                Console.WriteLine("Koop je soms bruin brood?");
                if (Affirmation())
                {
                    Console.WriteLine("Ben je een seut?");
                    if (Affirmation())
                    {
                        Console.WriteLine("Stem maar op CD&V.");
                    }
                    else
                    {
                        Console.WriteLine("Heb je vrienden?");
                        if (Affirmation())
                        {
                            Console.WriteLine("Staat jouw wagen, huis,... op naam van jouw ouders?");
                            if (Affirmation())
                            {
                                Console.WriteLine("Stem maar op OpenVLD.");
                            }
                            else
                            {
                                Console.WriteLine("Stem maar blanco.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Stem maar op de NVA.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Stem maar op het vlaams behang.");
                }
            }
            else
            {
                Console.WriteLine("Eet je vaak Quinoa?");
                if (Affirmation())
                {
                    Console.WriteLine("Stem maar op Groen.");
                }
                else
                {
                    Console.WriteLine("Krijg je vaak de schuld van alles?");
                    if (Affirmation())
                    {
                        Console.WriteLine("Stem maar op sp.a.");
                    }
                    else
                    {
                        Console.WriteLine("Geloof je nog in Sinterklaas?");
                        if (Affirmation())
                        {
                            Console.WriteLine("Stem maar op de PVDA.");
                        }
                        else
                        {
                            Console.WriteLine("Stem maar blanco.");
                        }
                    }
                }
            }
        }
        public static bool Affirmation()
        {
            string input = Console.ReadLine().ToLower();
            if (input == "ja" || input == "j")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
