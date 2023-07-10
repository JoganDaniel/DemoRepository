using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRepository
{
    internal class Vowel
    {
        public void VowelOrAlpha()
        {
            Console.WriteLine("Enter any letter");
            char a = (Console.ReadLine().ToLower())[0];
            if (char.IsLetter(a))
            {
                if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
                {
                    Console.WriteLine("It is a vowel");
                }
                else
                {
                    Console.WriteLine("It is a consonant");
                }
            }
            else
            {
                Console.WriteLine("Enter only a letter");
            }
        }
    }
}
