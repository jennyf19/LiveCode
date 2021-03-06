﻿using System;

namespace _05LiveCodeStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The next available serial number is {Car.NextAvailableSerialNumber}");
            Car pinto = new Car();
            Console.WriteLine($"pinto is {pinto.SerialNumber}");

            Car maverick = new Car();
            Console.WriteLine($"maverick is {maverick.SerialNumber}");
            Console.WriteLine($"The next available serial number is {Car.NextAvailableSerialNumber}");

            Console.ReadLine();
        }
    }

    class Car
    {
        //field associated with a class
        //Not associated with an object - so only one copy of this field
        private static int _nextSerialNumber = 1;
        //instance field that tells serial #
        private int _serialNumber;

        static Car() //static constructor
        {
            _nextSerialNumber = 1643;
        }

        //constructor
        public Car(int _serialNumber) //instance constructor
        {
            this._serialNumber = _serialNumber;
        }

        public Car(Car rhs)
        {
            this._serialNumber = rhs._serialNumber;
        }

        public static int NextAvailableSerialNumber
        {
            get { return _nextSerialNumber; }
        }
        //no set needed so people outside can't modify the value
        public int SerialNumber
        {
            get { return this._serialNumber; }
        }//no set needed so people outside can't modify the value
    }

    //static class only has static things in it
    static class x
    {
        //static field
        private static int y;

        //static constructor
        static x() { y = 0; }

        //property to tell value of y
        public static int Y { get { return y; } }
    }
}
