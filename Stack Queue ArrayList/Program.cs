using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue_ArrayList
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

            foreach (var v in stack)
            {
                Console.WriteLine("value: " + v);
            }



            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Mark");
            queue.Enqueue("Atikul");
            queue.Enqueue("Ismail");
            queue.Enqueue("Mominul");
            queue.Enqueue("Alamin");


            var str = queue.Dequeue();
            Console.WriteLine("str: " + str);
            Console.WriteLine("Peek: " + queue.Peek());

            foreach (var item in queue)
            {
                Console.WriteLine("value: " + item);
            }



            ArrayList arrlist = new ArrayList();

            arrlist.Add(30);
            arrlist.Add(20);

            string str1 = "Like Share subscrible";
            int x = 11;
            DateTime d = DateTime.Now;

            arrlist.Add(str1);
            arrlist.Add(x);
            arrlist.Add(d);


            foreach (var obj in arrlist)
            {
                Console.WriteLine("Obj: " + obj);
            }




        }
    }
}
