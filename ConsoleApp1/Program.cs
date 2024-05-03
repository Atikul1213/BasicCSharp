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

            var timeSpan = new TimeSpan(1, 2, 3);

            var minite = timeSpan.Minutes;
            var totalMinute = timeSpan.TotalMinutes;

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);

            var duration = end - start;
            Console.WriteLine("duration: "+duration);



            Console.ReadLine();
        }

        
    }
}
