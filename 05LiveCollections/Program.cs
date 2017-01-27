using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _05LiveCollections
{
    class Program
    {
        enum color { red, green, blue}
        static void Main(string[] args)
        {
            int[] arrayOfInts = new int[] { 1, 2, 2, 43, 5 };
            List<int> aList = new List<int>();
            aList.Add(6);
            aList.Add(12);
            aList.Add(123);
            aList.Add(12);
            aList.Add(6);

            Console.WriteLine(aList[3] + "\n");

            foreach (var item in aList)
            {
                Console.WriteLine(item);
            }

            Dictionary<color, int> myDictionary = new Dictionary<color, int>();
            myDictionary.Add(color.blue, 1);
            myDictionary.Add(color.green, 5);
            myDictionary.Add(color.red, 3);

            foreach (color c in myDictionary.Keys)
            {
                Console.WriteLine("\n" + c);
                Console.WriteLine("\n" + myDictionary[c]);
            }

            foreach (var v in myDictionary)
            {
                Console.WriteLine("You have {0} gallon(s) of {1} paint", v.Value, v.Key);
            }
            Console.ReadLine();
        }
    }
}
