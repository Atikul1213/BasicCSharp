using Microsoft.Build.BuildEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_example
{
    public class Car
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        private  Engine engine {get; set;}
        public bool AddEngine(Engine _engine)
        {
            engine = _engine;
            engine.status = true;
            return true;
        }
        


        public Car()
        {

        }
        public Car(string _brand, string _color)
        {
            this.Brand = _brand;
            this.Color = _color;
        }


        public void ShowCar()
        {
            if(engine.status)
                Console.WriteLine("Brand: "+Brand+" Color: "+Color+" Engine "+engine.Brand+" Hourse power: "+engine.HorsePower+ "Engine No: "+engine.No);
            else
                Console.WriteLine("Your engine is currenty offf");
        }
        public string On()
        {
            if (engine.status)
                return "Car has started";
            else
                return "Onn your engine";
        }

        public string MoveForward()
        {
            if (engine.status)
            {
                return "Car is moving forward";
            }
            else
            return "You should start your engine";
        }

        public string Stop()
        {
            if (engine.status)
            {
                engine.status = false;
                return "Car has stopped";
            }
            return "Car already stoped";
        }

        private bool isValid()
        {
            if (engine == null)
                return false;
            return true;
        }
        
    }
}
