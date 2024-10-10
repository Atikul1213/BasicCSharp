using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_List_DateTime
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


            var numb = new List<int>();
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



            DateTime dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            var hour = now.Hour;
            var minute = now.Minute;

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            Console.ReadLine();

        }
    }
}
