using ConsoleApp1.Math;
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
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Mark");
            queue.Enqueue("Atikul");
            queue.Enqueue("Ismail");
            queue.Enqueue("Mominul");
            queue.Enqueue("Alamin");


            var str = queue.Dequeue();
            Console.WriteLine("str: "+str);
            Console.WriteLine("Peek: " + queue.Peek());

            foreach(var x  in queue)
            {
                Console.WriteLine("value: "+x);
            }

            Console.ReadLine();
        }

         



        
    }
}
