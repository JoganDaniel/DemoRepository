using System;

namespace DemoRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Table\n2.Vowel or Aphabet \n3.Swap\n4.Exit");
                int ch = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case 1:
                        Table table = new Table();
                        table.MultiplicationTable();
                        break;
                    case 2:
                        Vowel vowel = new Vowel();
                        vowel.VowelOrAlpha();
                        break;
                    case 3:
                        Swap swap = new Swap();
                        swap.Swap2Nums();
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter a number from 1-4");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}