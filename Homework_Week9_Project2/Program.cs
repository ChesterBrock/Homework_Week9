using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Week9_Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            // testing all 4 constructors 
            Temperature temp1 = new Temperature();
            Temperature temp2 = new Temperature(101);
            Temperature temp3 = new Temperature('C');
            Temperature temp4 = new Temperature(120,'F');

            // get amd set for 1 
            Console.WriteLine(temp1.TemperatureValue);
            // setting new value 
            temp1.TemperatureValue = 90.9;
            // displaying that new value 
            Console.WriteLine(temp1.TemperatureValue);

            // setting both values 
            temp1.setBoth(60.0, 'F');
            Console.WriteLine(temp1.toString());

            // the equals method 
            Console.WriteLine(temp1.Equals(temp2)+ " - true is same / false if different. ");

            Console.ReadLine();

        }
    }
}
