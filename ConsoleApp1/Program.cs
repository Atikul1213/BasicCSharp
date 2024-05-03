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
            int n = 5;
            int i = 0;
            while (i < n)
            {
                Console.WriteLine(i);
                i = i + 1;
            }

            for (i = 0; i <= n; i++)
            {
                Console.WriteLine(i);
            }


            int[] number = new int[3] { 10, 20, 30 };

            foreach (var num in number)
                Console.WriteLine(num);




            Console.ReadLine();
        }
    }
}
