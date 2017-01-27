using System;

namespace _05LiveCodeStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Car pinto = new Car();
            Console.WriteLine($"pinto is {pinto.SerialNumber}");

            Car maverick = new Car();
            Console.WriteLine($"maverick is {maverick.SerialNumber}");
            Console.ReadLine();
        }
    }

    class Car
    {
        private int _nextSerialNumber = 1;
        //field that tells serial #
        private int _serialNumber;

        //constructor
        public Car()
        {
            _serialNumber = _nextSerialNumber++;
        }

        public int SerialNumber
        {
            get { return _serialNumber; }
        }
    }
}
