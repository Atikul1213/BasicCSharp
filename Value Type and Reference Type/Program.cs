using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Type_and_Reference_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int b = i;

            Console.WriteLine("b: " + b);

            i = 11;
            Console.WriteLine("b: " + b);

            int num = 20;

            int value = Increase(ref num);

            Console.WriteLine("num: " + num);


            // class 

            Person p1 = new Person();    /// Allocate memory
            p1.Id = 10; 
            p1.Name = "Atikul Islam";
            p1.age = 24;

            p1.Show();


            Person p2 = p1;  /// Not Allocate any memory
            p2.Name = "Mominul";
            p2.Show();
            p1.Show();



        }


        public static int Increase(ref int value)
        {
            value = value + 10;
            return value;
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int age { get; set; }

        public void Show()
        {
            Console.WriteLine("Id: "+Id+"  Name: "+Name+"  Age: "+age);
        }
    }
}
