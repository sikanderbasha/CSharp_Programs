using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Swapnumbers
    {
        public void Swapnumber()
        {

            int first = 5, second = 10;
            Console.WriteLine("first = " + first + " second = " + second);
            first = first + second;
            second = first - second;
            first = first - second;
            Console.Write("After swapping first = " + first + " second = " + second);
        }
    }
}
