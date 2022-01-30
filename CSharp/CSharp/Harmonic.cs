using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Harmonic
    {
        public int num = 0;
        double Result = 0.0;
        public void HarmonicSeries()
        {

            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int var_i = 1; var_i <= num; var_i++)
            {
                Result += 1 / (float)var_i;
                Console.Write("1/{0} + ", var_i);
            }
            Console.WriteLine($"= {Result}");
            Console.ReadLine();
        }
    }
}
