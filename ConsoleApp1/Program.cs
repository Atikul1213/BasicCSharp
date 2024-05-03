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

            var season = Season.Antumn;
            switch (season)
            {
                case Season.Antumn:
                    Console.WriteLine("It is antumn");
                    break;
                case Season.Spring:
                    Console.WriteLine("it is Spring");
                    break;
                default:
                    Console.WriteLine("It is other");
                    break;
            }




            Console.ReadLine();
        }

        
    }
}
