using System;
using System.Collections.Generic;
using System.Text;

namespace OopLiveDemo
{
    public class Car: Vehicle
    {
        private string brand;
        private string model;

        public Car(int startFuel, string startBrand, string startModel) 
            : base(startFuel)
        {
            brand = startBrand;
            model = startModel;
        }

        public Car(int startFuel, string buildNumber)
            : base(startFuel)
        {
            brand = buildNumber;
        }

        public string FullName {    
            get
            {
                return brand + " " + model;
            }
        }

        public void Drift()
        {
            fuel -= 2;
            Console.WriteLine("Slide slide!");
        }
    }
}
