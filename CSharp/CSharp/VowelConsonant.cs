using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class VowelConsonant
    {
        public char Alphabet;
        public void Vowelcon()
        {
            Console.Write("Write the alphabet :\n"); 
            Alphabet = Convert.ToChar(Console.ReadLine());
            if (Alphabet == 'a' | Alphabet == 'A' | Alphabet == 'i' | Alphabet == 'I' | Alphabet == 'U' | Alphabet == 'u' | Alphabet == 'E' | Alphabet == 'e' | Alphabet == 'O' | Alphabet == 'o')
                Console.WriteLine(Alphabet + " is a Vowel");
            else
                Console.WriteLine(Alphabet + " is a Consonant"); 
        }
    }
}
