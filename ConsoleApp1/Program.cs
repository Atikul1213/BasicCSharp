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


            Calculator calculator = new Calculator();
            var result = calculator.Add(10, 20);

            Console.WriteLine("Result: " + result);


            Console.ReadLine();
        }
    }
}
