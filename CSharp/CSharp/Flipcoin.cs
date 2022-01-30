using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Flipcoin
    {
        public int Heads = 0;
        public int Tails = 0;
        const double C = 0.5;


        public void HeadTailPercentage()
        {
            Console.WriteLine("How many times you want to Flip a Coin : ");
            int FlipNumber = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int coinFlip = 1; coinFlip <= FlipNumber; coinFlip++)
            {

                //Check Reandom 
                double CheckFlipCoin = random.Next(0, 2);
                if (CheckFlipCoin < C)
                {
                    //If head
                    Console.WriteLine("Result: Head");
                    Heads++;
                }
                else
                {
                    //if tail 
                    Console.WriteLine("Result: Tail");
                    Tails++;
                }
            }
            //Calculating Percentage
            double PercentageTails = (Tails * 100) / FlipNumber;
            double PercentageHeads = (Heads * 100) / FlipNumber;
            Console.WriteLine("percentage : " + PercentageTails + " % Tails" + " " + PercentageHeads + " % Heads");
            Console.ReadKey();
        }

    }
}
