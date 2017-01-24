using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LiveCode02Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car pinto = new Car(5);//constructor - call to help create
            int milesDriven = pinto.Drive(5);
            Console.WriteLine("You drove: " + milesDriven + " miles");
            pinto.Drive(10);
            pinto.Drive();
            pinto.Drive(14);
            pinto.Drive();
            pinto.Drive(56);
            milesDriven = pinto.Drive();
            Console.WriteLine("You drove: " + pinto.Odometer);
            Console.WriteLine("Pinto drove: {0}", pinto.Odometer);

            //Debug.WriteLine("Current Oil level is ");

            Car maverick = new Car(45);
            maverick.Drive();
            maverick.Drive();
            maverick.Drive();

            int currentMiles = pinto.Odometer;
            pinto.Odometer = 4000;

            //Console.WriteLine("The maverick has been driven: " + maverick.ReportTotalMilesDriven() + " miles");


            Console.ReadLine();
        }
    }
}
