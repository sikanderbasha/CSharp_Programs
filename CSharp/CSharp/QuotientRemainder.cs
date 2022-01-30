using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class QuotientRemainder
    {
        public int Dividend = 0;
        public int Divisor = 0;
        public void QuotientRem()
        {
            Console.Write("Calculate the Dividend:"); 
            Dividend = Convert.ToInt32(Console.ReadLine());

            Console.Write("Calculate the Divisor:"); 
            Divisor = Convert.ToInt32(Console.ReadLine());
            int Quot = Dividend / Divisor;  
            int Rem = Dividend % Divisor; 

            Console.WriteLine("Dividend:{0} Divisor:{1}", Dividend, Divisor); 
            Console.WriteLine("Quotient = " + Quot); 
            Console.WriteLine("Remainder = " + Rem); 
            Console.ReadLine();
        }
    }
}
