using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
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
