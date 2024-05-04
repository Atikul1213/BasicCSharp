using ConsoleApp1.Math;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            int num1 = AddInt(10, 20);

            double num2 = AddDouble(23.33, 43.44);

            Console.WriteLine("num1: "+num1);
            Console.WriteLine("num2: "+num2);


            Console.ReadLine();
        }


        static int AddInt(int x,int y)
        {
            return x + y;
        }

        static double AddDouble(double x,double y)
        {
            return x + y;
        }


        
    }

     
}
