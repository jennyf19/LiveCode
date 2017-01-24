using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04LiveLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
            {
                if (i % 2 == 0) continue;

                Console.WriteLine(i);

                if (i == 37) break;
            }

            int k = 5;
            while (k == 5)
            {
                Console.WriteLine("while loop");
                k--;
            }

            int j = 16;
            do
            {
                Console.WriteLine("my do while loop");

            } while (j < 10);

            for (int jj = 0; jj < 5; jj++)
            {

                switch (jj)
                {
                    case 0:
                        Console.WriteLine("0");
                        break;
                    case 1:
                        Console.WriteLine("1");
                        break;
                    default:
                        Console.WriteLine("not 0 or 1");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
