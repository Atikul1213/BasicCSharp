using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.firstName = "Atikul";
            person.lastName = "Islam";

            person.Introduce();

            Console.ReadLine();

        }
    }

    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public void Introduce()
        {
            Console.WriteLine("My Name is " + firstName + " " + lastName);
        }

    }
}
