using ConsoleApp1.Math;
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

            var n = 4;

            if (n < 10)
                Console.WriteLine("Less than 10");

            else if (n == 10)
                Console.WriteLine("number is 10");

            else
                Console.WriteLine("Greater than 10");


            int res = (n < 10) ? -10 : 10;
            Console.WriteLine("res: " + res);


            int choice = 3;
            switch (choice)
            {
                case 1:
                    Console.WriteLine(" Case 1");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;

            }




            Console.ReadLine();
        }
    }
}
