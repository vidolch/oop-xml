using System;

namespace OopLiveDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car(80, "B12717");

            Console.WriteLine(car.FullName);

            //car.Drive();
            //car.Drift();
            //Console.WriteLine("Fuel remainig:");
            //car.FuelRemaining();
        }
    }
}
