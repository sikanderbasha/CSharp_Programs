﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Leapyear
    {
        public void Checkleapyear()
        {
            Console.WriteLine("Enter the Year to Check if it is Leap Year or Not: ");
            int Checkyear = Convert.ToInt32(Console.ReadLine()); 

            if ((Checkyear % 400 == 0) || (Checkyear % 4 == 0 && Checkyear % 100 != 0))
                Console.WriteLine(Checkyear + " is a Leap Year");
            else
                Console.WriteLine(Checkyear + " is not a Leap Year");
        }
    }
}
