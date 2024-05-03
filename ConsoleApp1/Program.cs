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


            int[] number = new int[3] { 10, 20, 30 };
            number[0] = 10;
            number[1] = 20;
            number[2] = 30;

            foreach(var x in number)
            {
                Console.WriteLine("x : "+x);
            }

            var numbers = new int[] { 3, 7, 9, 10, 11, 12, 13 };

            var len = numbers.Length;
            var index = Array.IndexOf(numbers, 9);
            Array.Clear(numbers, 0, 2);

            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Array.Sort(numbers);
            Array.Reverse(numbers);



            Console.ReadLine();
        }
    }
}
