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

            //reference variable called list, which points to an array, which contains 3 elements, 10, 11, 12
            int[] list = new int[] { 10, 11, 12 , 15, -3, 10};
            list[0] = 3; //changes '10' to a 3
            list[list.Length - 3] = 4; //change '12' to 4
            Console.WriteLine(list[2]);

            processMyList(list);

            Console.ReadLine();
        }

        private static void processMyList(int[] listp)
        {
            listp[0] = 123;
            foreach (int element in listp)
            {
                Console.Write(element + " ");
            }
            //original list is unaffected, but pointer to the reference is gone w/null
            listp = null;
        }
    }
}
