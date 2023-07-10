using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRepository
{
    internal class Table
    {
        public void MultiplicationTable()
        {
            Console.WriteLine("Enter a number for generating table");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " * " + n + " = " + i * n);
            }
        }
    }
}
