using ConsoleApp1.Math;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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

            Hashtable menu = new Hashtable();

            menu.Add(1, "Sadikul");
            menu.Add(4, "Atikul");
            menu.Add(3, "Ismail");
            menu.Add(2, "Atik");

            foreach(DictionaryEntry kvp in menu)
            {
                Console.WriteLine("Key: "+kvp.Key+"  Value: "+kvp.Value);
            }


            Console.ReadLine();
        }

         



        
    }
}
