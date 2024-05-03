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

            byte Num = 3;
            int count = 10;
            float totalPrice = 10.34f;
            char character = 'A';
            string firstName = "Atikul";
            bool isWorking = true;


            Console.WriteLine("Hello World");
            Console.WriteLine("Num: " + Num);
            Console.WriteLine("count: " + count);
            Console.WriteLine("totalPrice: " + totalPrice);
            Console.WriteLine("Character: " + character);
            Console.WriteLine("firstName: " + firstName);
            Console.WriteLine("isWorking: " + isWorking);


            var lastName = "Islam";     // Take any type of dataType
            Console.WriteLine("LastName: " + lastName);

            Console.WriteLine("{0} {1}", byte.MaxValue, byte.MinValue);


            const float pi = 3.1416f;
            Console.WriteLine("Constant: " + pi);

            Console.ReadLine();
        }
    }
}
