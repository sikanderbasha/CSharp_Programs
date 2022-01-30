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
            Console.WriteLine("4 For: Select the Harmonic Number");
            Console.WriteLine("5 For: Select Factor of number");
            Console.WriteLine("6 For: Select Quotient and Remainder");
            Console.WriteLine("7 For: Select Swap the Numbers");
            Console.WriteLine("8 For: Select Even and Odd number");
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
                case 4:
                    //Harmonic Series
                    Harmonic HarmonicNumber = new Harmonic();
                    HarmonicNumber.HarmonicSeries();
                    break;
                case 5:
                    //Prime Factor
                    Primefactor Prime = new Primefactor();
                    Prime.Factorial();
                    break;
                case 6:
                    //QuotientRemainder
                    QuotientRemainder QRem = new QuotientRemainder();
                    QRem.QuotientRem();
                    break;
                case 7:
                    //Swap 2 number
                    Swapnumbers Swap = new Swapnumbers();
                    Swap.Swapnumber();
                    break;
                case 8:
                    // Even Or odd
                    Evenodd EvenOdd = new Evenodd();
                    EvenOdd.CheckEvenodd();
                    break;
                default:
                    Console.WriteLine("Invalid Selection.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
