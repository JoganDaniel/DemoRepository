using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRepository
{
    internal class Swap
    {
        public void Swap2Nums()
        {
            Console.WriteLine("Enter 1st number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Swaped nums");
            Console.WriteLine("1st num : " + a);
            Console.WriteLine("2nd num : " + b);
        }
    }
}
