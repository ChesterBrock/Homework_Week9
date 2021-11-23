/// Chapter No. 9		Exercise No. 1
/// File Name: Odometer.cs
/// @author: Chester Brock 
/// Date:  Nov 19, 2021
///
/// Problem Statement: Define a class called Odometer that will be used to track fuel usage and miles per gallon. 
/// 
/// 
/// Overall Plan:
/// 1) Create two constructors,
/// 2) 1 constructor should be the no-argument constructor the other will set the two instance variables
/// 3) The class should have instance variables for mileage driven and fuel used
/// 4) Include a reset method that sets the mileage drive and the fuel used to zero
/// 5) Include an add method which takes two parameters that add to the fuel consumed and the miles driven
/// 6) create a method that returns the miles per gallon and an appropriate ToString method
/// 7) Write a driver program that tests all the methods and constructors
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Week9_Project1
{
    class Odometer
    {
        // two instance variables 
        private int miles;
        private double fuelUsed;

        // default constructor 
        public Odometer() 
        { 
            Miles = 0; 
          fuelUsed = 0; 
        }

        //parameterized constuctor
        public Odometer(int miles, double fuelUsed) 
        {
            this.Miles = miles;
            this.fuelUsed = fuelUsed;
        }

        public int Miles { get => miles; set => miles = value; }
        public double FuelUsed { get => fuelUsed; set => fuelUsed = value; }

        // Methods
        public void reset()
        {
            miles = 0;
            fuelUsed = 0;
        }
        public void add(int milesDriven, double fuel)
        {
            miles += milesDriven;
            fuelUsed += fuel;
        }
        public double MPG()
        {
            return miles / fuelUsed;
        }

        public String toString()
        {
            return "miles[" + this.miles + "] fuel used [ " + this.fuelUsed + "] ";
        }
    }
}
