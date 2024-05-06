using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_generic
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


            foreach (DictionaryEntry d in slist)
            {
                Console.WriteLine("Key: " + d.Key + "  value: " + d.Value);
            }


            Stack stack = new Stack();

            stack.Push("Rare");
            stack.Push("Medium Rear");
            stack.Push("Atikul");
            stack.Push("Ismail");
            stack.Push("Mominul");

            foreach (var x in stack)
            {
                Console.WriteLine("value: " + x);
            }


            Queue queue = new Queue();

            queue.Enqueue("Mark");
            queue.Enqueue("Atikul");
            queue.Enqueue("Ismail");
            queue.Enqueue("Mominul");
            queue.Enqueue("Alamin");


            var str = queue.Dequeue();
            Console.WriteLine("str: " + str);
            Console.WriteLine("Peek: " + queue.Peek());

            foreach (var x in queue)
            {
                Console.WriteLine("value: " + x);
            }



            Hashtable menu = new Hashtable();

            menu.Add(1, "Sadikul");
            menu.Add(4, "Atikul");
            menu.Add(3, "Ismail");
            menu.Add(2, "Atik");

            foreach (DictionaryEntry kvp in menu)
            {
                Console.WriteLine("Key: " + kvp.Key + "  Value: " + kvp.Value);
            }




            SortedList<int, string> stlist = new SortedList<int, string>();

            stlist.Add(1, "Atikul");
            stlist.Add(3, "Atik");
            stlist.Add(4, "Mominul");
            stlist.Add(2, "Ismail");

            foreach (var kvp in stlist)
            {
                Console.WriteLine("Key: " + kvp.Key + " Value: " + kvp.Value); ;
            }


            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "Atikul");
            dict.Add(3, "Ismail");
            dict.Add(4, "Mominul");
            dict.Add(2, "Atik");

            foreach (var kvp in dict)
            {
                Console.WriteLine("Key: " + kvp.Key + " Value: " + kvp.Value); ;
            }


        }
    }
}
