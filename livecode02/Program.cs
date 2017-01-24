using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livecode02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.Write("Insert 35 cents");
            int input = int.Parse(Console.ReadLine());
            Console.Write("You have intersted: ");
            Console.Write(input);

            Console.WriteLine(" cents, thanks. here is your soda");
            Console.ReadLine();
        }
    }
}
