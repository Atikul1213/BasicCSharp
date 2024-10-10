using System.Collections;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Atikul ");

            int n = 10;
            switch (n)
            {
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }


            for (int i = 1; i <= 10; i++)
                Console.WriteLine("i: " + i);


            int[] nums = new int[] { 10, 20, 30 };

            foreach (var x in nums)
                Console.WriteLine(x);


            Console.WriteLine(nums.Length);


            Array.Sort(nums);
            Array.Reverse(nums);

            var numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);

            var idx = numbers.IndexOf(10);
            numbers.RemoveAt(idx);
            numbers.Clear();
            List<int> lst = new List<int>();
            lst.Add(10);
            lst.Add(20);
            lst.Add(30);


            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(10, "Atikul");
            foreach (var x in dict)
                Console.WriteLine("key: " + x.Key + " value: " + x.Value);

            SortedList<int, string> slst = new SortedList<int, string>();

            slst.Add(20, "Atikul");
            foreach (var x in slst)
            {
                Console.WriteLine("key: " + x.Key + " value: " + x.Value);
            }

            Stack<string> stack = new Stack<string>();

            stack.Push("Atikul");
            stack.Pop();


            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Atikul");
            queue.Dequeue();

            foreach (var x in queue)
                Console.WriteLine(x);
            queue.Peek();
            stack.Peek();


            Hashtable hashtable = new Hashtable();

            hashtable.Add(1, "Atikul");
            hashtable.Add(2, "Islam");

            foreach (DictionaryEntry kvp in hashtable)
                Console.WriteLine(kvp.Key + " " + kvp.Value);



            Console.ReadLine();
        }
    }
}
