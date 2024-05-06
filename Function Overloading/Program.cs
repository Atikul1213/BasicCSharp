using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = AddInt(10, 20);

            double num2 = AddDouble(23.33, 43.44);

            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);
        }

        static int AddInt(int x, int y)
        {
            return x + y;
        }

        static double AddDouble(double x, double y)
        {
            return x + y;
        }

    }
}
