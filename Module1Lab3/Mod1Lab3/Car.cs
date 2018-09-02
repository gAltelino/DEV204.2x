using System;

namespace Mod1Lab3
{
    class Car
    {

        private static int instances = 0;
        
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        public Car(string color, int year){
            instances++;
            this.Color = color;
            this.Year = year;
        }

        public Car(int year, int mileage){
            instances++;
            this.Year = year;
            this.Mileage = mileage;
        }

        public Car(){
            instances++;
        }

        public static int CountCars(){
            return instances;
        }
    }
}