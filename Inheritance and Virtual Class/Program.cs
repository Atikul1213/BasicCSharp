using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Virtual_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(100, "blue");
            car.Print();

            Bmw bmw = new Bmw(200, "Red", "R34");
            bmw.Print();
            bmw.Repair();


            Audi audi = new Audi(300, "Yellow", "K322");
            audi.Print();
            audi.Repair();
        }
    }


    public class Car
    {
        public int hp { get; set; }
        public string color { get; set; }

        public Car(int _hp, string _color)
        {
            this.hp = _hp;
            this.color = _color;
        }

        public virtual void Print()
        {
            Console.WriteLine("Hp: " + hp + " color: " + color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }

    }



    class Bmw : Car
    {
        private string brand = "bmw";
        public string Model { get; set; }

        public Bmw(int _hp, string _color, string _Model) : base(_hp, _color)
        {
            this.Model = _Model;
        }

        public override void Print()
        {
            Console.WriteLine("Brand: " + brand + " Hp: " + hp + " color: " + color + " Model: " + Model);

        }

        public override void Repair()
        {
            Console.WriteLine("Bmw {0} car was repaired", brand);
        }
    }


    class Audi : Car
    {
        private string brand = "Audi";
        public string Model { get; set; }

        public Audi(int _hp, string _color, string _Model) : base(_hp, _color)
        {
            this.Model = _Model;
        }

        public override void Print()
        {
            Console.WriteLine("Brand: " + brand + " Model: " + Model + " hp: " + hp + " color:" + color);

        }

        public override void Repair()
        {
            Console.WriteLine("Bmw{0} car was repaired", brand);
        }
    }

}
