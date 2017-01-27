using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05LiveEnum
{
    class Program
    {
        enum color { red, green, blue};
        static void Main(string[] args)
        {
            //IsDefined is testing to see if the typeof(color) and the string match
            Console.WriteLine(Enum.IsDefined(typeof(color), "red"));
            Console.WriteLine(Enum.IsDefined(typeof(color), "11123"));
            Console.WriteLine(Enum.IsDefined(typeof(color), "Green"));
            Console.ReadLine();
        }
    }
}
