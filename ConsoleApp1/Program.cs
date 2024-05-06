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

            ArrayList arrlist = new ArrayList();

            arrlist.Add(30);
            arrlist.Add(20);

            string str = "Like Share subscrible";
            int x = 11;
            DateTime d = DateTime.Now;

            arrlist.Add(str);
            arrlist.Add(x);
            arrlist.Add(d);


            foreach(var obj in arrlist)
            {
                Console.WriteLine("Obj: "+obj);
            }



            Console.ReadLine();
        }

         



        
    }
}
