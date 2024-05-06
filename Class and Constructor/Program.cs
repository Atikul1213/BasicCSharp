using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.model = "R15";
            car.color = "Blue";
            car.year = 2024;
            car.ShowValue();

            Car carSec = new Car("Yeama", "red", 2023);
            carSec.ShowValue();

        }
    }

    public class Car
    {
        public string model;
        public string color;
        public int year;

        public Car(string _model, string _color, int _year)
        {
            this.model = _model;
            this.color = _color;
            this.year = _year;
        }

        public Car()
        {
            this.model = "Hunda";
            this.color = "Green";
            this.year = 2000;
        }

        public void SetValue(string _model, string _color, int _year)
        {
            this.model = _model;
            this.color = _color;
            this.year = _year;
        }

        public void ShowValue()
        {
            Console.WriteLine("Mode: " + model + "  color: " + color + "  Year: " + year);
        }

        public void Greeting()
        {
            Console.WriteLine("The car is going as fast as it can"); ;
        }
    }
}
