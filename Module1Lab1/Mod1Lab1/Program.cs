﻿using System;

namespace Mod1Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            var Car1= new Car();
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            Console.WriteLine($"This car is painted {Car1.Color}, was built in {Car1.Year}, and has {Car1.Mileage} miles on it.");

            Console.WriteLine("Hello World!");
        }
    }
    public class Car
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
    }
}
