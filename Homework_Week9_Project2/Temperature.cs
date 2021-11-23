/// Chapter No.9	Exercise No. 2
/// File Name: Temperature.cs
/// @author: Chester Brock 
/// Date:  Nov 19, 2021
///
/// Problem Statement: Write a Temperature class that has two instance variables: a temperature value (a floating-point number) and a character for the scale, either C for Celsius of F for Fahrenheit
/// 
/// 
/// 
/// Overall Plan:
/// 1) The class should have 4 constructor methods: one for each instance variable
/// 2) one with two parameters for the two instance variables, and a no-argument constructor 
/// 3) Two getter methods to return the temperature
/// 4) Three setter methods, one to set the temperature, one to set the scale and one to set both instance variables.
/// 5) A suitable ToString method.
/// 6) An Equals method that compares two temperatures. 
/// 7) A driver program that tests each of the constructors
///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Week9_Project2
{
    class Temperature
    {
        // two instance variables 
        private double temperatureValue;
        private char scale;

        // default constructor 
        public Temperature()
        {
            TemperatureValue = 0.0;
            Scale = 'C';
        }
        public Temperature(double temperatureValue)
        {
            this.TemperatureValue = temperatureValue;
            Scale = 'C';
        }
        public Temperature(char scale)
        {
            TemperatureValue = 0.0;
            this.Scale = scale;
        }
        // full constructor 
        public Temperature(double temperatureValue, char scale)
        {
            this.TemperatureValue = temperatureValue;
            this.Scale = scale;
        }

        public double TemperatureValue { get => temperatureValue; set => temperatureValue = value; }
        public char Scale { get => scale; set => scale = value; }

        public override bool Equals(object obj) // equals method 
        {
            return obj is Temperature temperature &&
                   temperatureValue == temperature.temperatureValue &&
                   scale == temperature.scale;
        }

        // set method for both 
        public void setBoth(double temperatureValue, char scale)
        {
            this.scale = scale;
            this.temperatureValue = temperatureValue;
        }

        // toString method 
        public String toString()
        {
            return "Temp [ " + this. temperatureValue + "] Scale [ " + this.scale + "] ";
        }


    }
}
