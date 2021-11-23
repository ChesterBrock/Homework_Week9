using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Week9_Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Odometer trip1 = new Odometer();
            trip1.add(50, 10);
            Console.WriteLine("Fuel used for trip 1 is : " + trip1.MPG());
            Odometer trip2 = new Odometer();
            trip2.add(100, 20);
            Console.WriteLine("Fuel used for trip 2 is : " + trip2.MPG());

            trip1.reset();
            Console.WriteLine("Fuel used for trip 1 is : " + trip1.toString());
            trip2.add(150, 0);
            Console.WriteLine("Fuel used for trip 2 is : " + trip2.MPG());




            Console.ReadLine();
        }
    }
}
