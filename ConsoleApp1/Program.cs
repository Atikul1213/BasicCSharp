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

            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "Atikul");
            dict.Add(3, "Ismail");
            dict.Add(4, "Mominul");
            dict.Add(2, "Atik");

            foreach(var kvp in dict)
            {
                Console.WriteLine("Key: " + kvp.Key + " Value: " + kvp.Value); ;
            }


            Console.ReadLine();
        }
 
    }


  
}
