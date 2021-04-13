using System;

namespace Schoenverkoper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoeveel paar schoenen?");
            int shoeAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Na hoeveel paar schoenen is er een korting?");
            int bargainAmount = Convert.ToInt32(Console.ReadLine());

            int shoePrice = 20, bargainPrice = 10;
            int totalPrice = shoePrice*bargainAmount;

            if(shoeAmount > bargainAmount)
            {
                int amountDif = shoeAmount - bargainAmount;
                totalPrice += amountDif*bargainPrice;
                Console.WriteLine($"{shoeAmount} schoenen kosten {bargainAmount}x{shoePrice} + {amountDif}x{bargainPrice} = {totalPrice}");
            }
            else
            {
                Console.WriteLine($"{shoeAmount} schoenen kosten {shoeAmount}x{shoePrice} = {totalPrice}");
            }
        }
    }
}
