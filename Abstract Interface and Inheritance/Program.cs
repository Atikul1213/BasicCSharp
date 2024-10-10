using Inheritance.Contracts;
using Inheritance.SuperHero;
using Inheritance.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {


      
            Animal animal = new Animal();

            Console.WriteLine("Eat: "+animal.Eat());


            Eagle eagle = new Eagle();

            Console.WriteLine(eagle.Speak());

            Animal animal1 = new Eagle();   /// Upcasting 

            Eagle eagle1 = (Eagle)animal1;

            Console.WriteLine(eagle1.Fly());



            Console.WriteLine(eagle.Call());


            Animal animal2 = new Tiger();
            // Console.WriteLine(animal2.Fly());


            List<Animal> zoo = new List<Animal>();
            zoo.Add(new Tiger());
            zoo.Add(new Eagle());


            foreach(Animal var in zoo)
            {
                Console.WriteLine(var.Speak());
            }
            


            // Interface using 

            IFlyable flyobj = new Eagle();
            

            Console.WriteLine(flyobj.Fly());

            List<IFlyable> flst = new List<IFlyable>();

            flst.Add(new Eagle());
            flst.Add(new Parrot());
            flst.Add(new Superman());
            flst.Add(new Ironman());
            flst.Add(new Roket());

            foreach(IFlyable fobj in flst)
            {
                Console.WriteLine(fobj.Fly());
            }






        }
    }
}
