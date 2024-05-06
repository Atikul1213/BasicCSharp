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

            SortedList slist = new SortedList();

            slist.Add(2, "Atikul");
            slist.Add(4, "Ismail");
            slist.Add(1, "Atik");
            slist.Add(3, "Mominul");
            

            foreach(DictionaryEntry d in slist)
            {
                Console.WriteLine("Key: "+d.Key+"  value: "+d.Value);
            }


            Console.ReadLine();
        }

         



        
    }
}
