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

            SortedList<int, string> slist = new SortedList<int, string>();

            slist.Add(1, "Atikul");
            slist.Add(3, "Atik");
            slist.Add(4, "Mominul");
            slist.Add(2, "Ismail");

            foreach(var kvp in slist)
            {
                Console.WriteLine("Key: " + kvp.Key + " Value: " + kvp.Value); ;
            }


            Console.ReadLine();
        }
 
    }


  
}
