using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Primefactor
    {
        public int var_i = 0;
        public int num = 0;
        public int factorial = 1;
        public void Factorial()
        {
            Console.Write("Calculate the factorial of a given number:"); 
            num = Convert.ToInt32(Console.ReadLine());
            for (var_i = 1; var_i <= num; var_i++) 
                factorial *= var_i; 
            Console.Write("The Factorial of {0} is: {1}\n", num, factorial); 
        }
    }
}
