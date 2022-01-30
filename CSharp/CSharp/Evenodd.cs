using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Evenodd
    {
        public int Num;
        public int Rem;
        public void CheckEvenodd()
        {

            Console.Write("Enter Number :\n"); 
            Num = Convert.ToInt32(Console.ReadLine());
            Rem = Num % 2;
            if (Rem == 0)
                Console.WriteLine("{0} is a Even Number.", Num);
            else
                Console.WriteLine("{0} is a Odd Number.", Num);
        }
    }
}
