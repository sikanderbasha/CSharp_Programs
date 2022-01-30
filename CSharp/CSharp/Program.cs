using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice between 1 to 10: ");
            Console.WriteLine("1 For: Flip a Coin Head and Tail. ");
            Console.WriteLine("2 For: Check Leap Year Or not");
            Console.WriteLine("3 For: Select Power of 2 Number");
            int selection = Convert.ToInt32(Console.ReadLine());
            // user selection

            switch (selection)
            {
                case 1:
                    //FLIP COIN
                    Flipcoin Coin = new Flipcoin();
                    Coin.HeadTailPercentage();
                    break;
                case 2:
                    //LEAP YEAR
                    Leapyear LeapYearOrNot = new Leapyear();
                    LeapYearOrNot.Checkleapyear();
                    break;
                case 3:
                    //POWEROF2
                    Powerof2 Power = new Powerof2();
                    Power.Power();
                    break;
                default:
                    Console.WriteLine("Invalid Selection.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
