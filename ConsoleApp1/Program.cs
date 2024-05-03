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

            var number = new List<int>();
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            numbers.Add(10);
            numbers.AddRange(new int[3] { 11, 12, 14 });
            var idx = numbers.IndexOf(14);
            idx = numbers.LastIndexOf(14);
            var count = numbers.Count();
            numbers.Remove(14);
            numbers.RemoveAt(0);
            numbers.Clear();

            foreach (var x in numbers)
            {
                Console.WriteLine("x: " + x);
            }




            Console.ReadLine();
        }
    }
}
