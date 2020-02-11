using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    public class Car
    {
        public Car(string model)
        {
            Model = model;
        }

        public string Model { get; set; }

        public void Drive()
        {
            Console.WriteLine("Vroom vroom");
        }
    }
}
