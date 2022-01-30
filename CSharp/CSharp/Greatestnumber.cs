using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Greatestnumber
    {
        public void Greatestnum()
        {
            Console.WriteLine("Enter the first number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            int third = Convert.ToInt32(Console.ReadLine());

            if (first > second && first > third)
            {
                Console.WriteLine(first + " is the greatest number");
            }
            if (second > first && second > third)
            {
                Console.WriteLine(second + " is the greatest number");
            }
            if (third > first && third > second)
            {
                Console.WriteLine(third + " is the greatest number");
            }
            
        }
    }
}
