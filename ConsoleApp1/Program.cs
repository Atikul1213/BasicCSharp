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

            try
            {
                int[] myNumber = new int[]{ 1, 2, 3 };
                Console.WriteLine(myNumber[10]);
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }

            finally
            {
                Console.WriteLine("The try catch is finished");
            }


            Console.ReadLine();
        }
 
    }


  
}
