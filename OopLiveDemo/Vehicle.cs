using System;
using System.Collections.Generic;
using System.Text;

namespace OopLiveDemo
{
    public class Vehicle
    {
        protected int fuel;

        public Vehicle(int startFuel)
        {
            fuel = startFuel;
        }

        public void Drive()
        {
            fuel--;
            Console.WriteLine("Vroom Vroom!");
        }

        public void FuelRemaining()
        {
            Console.WriteLine(fuel);
        }
    }
}
