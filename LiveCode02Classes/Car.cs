using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCode02Classes
{
    class Car
    //classes contain fields, methods
    //classes have access specifiers: public and private
    //everything is automatically private
    {
        //state of the car, data, nouns
        private int _wheelCount = 4;//field wheelCount ... "_" means the field is private
        private int _milesDriven = 0;

        public Car(int initialOilLevel)//constructor, initialization, parameterless
        {
            OilLevel = initialOilLevel;
        }
        
        //functionality of the car, methods, verbs/actions, something "to do"
        public int Drive(int distance)
        {
            _milesDriven = _milesDriven + 100;
            return 100;
        }

        public int Drive()//overload of Drive() - two methods w/ same name w/different parameters
        {
            Drive(100);
            return 100;
        }
        //property is half-way between a method and a field
        public int Odometer
        {
            get
            {
                return _milesDriven;
            }
            set { if (value > _milesDriven) _milesDriven = value; }
        }

        public int OilLevel //auto-implemented property
        {
            get; set;
        }

        private int _vin = 1234567890;
        public int VIN//transparent property
        {
            get { return _vin; }
            set { _vin = value; }
        }
    }
}
