﻿using ConsoleApp1.Math;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("Rare");
            stack.Push("Medium Rear");
            stack.Push("Atikul");
            stack.Push("Ismail");
            stack.Push("Mominul");

            foreach (var x in stack)
            {
                Console.WriteLine("value: " + x);
            }
            Console.ReadLine();
        }

         



        
    }
}
