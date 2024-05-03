using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
}
