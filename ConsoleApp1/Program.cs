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

            Person person = new Person("Atikul", "Islam", "Atik");

            Console.WriteLine("Full Name: " + person.GetFullName()); ;

            Console.ReadLine();
        }
 
    }


  
}
