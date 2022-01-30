using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Powerof2
    {
        public int num = 0;
        public void Power()
        {

            Console.Write("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = num * 2; 
            Console.WriteLine("Power of " +num +" is " +result);
            Console.ReadLine();
        }
    }
}
