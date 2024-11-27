
public class GenericCollection
{
    public static void Main(string[] args)
    {
        Console.WriteLine("atikul");

        //List
        List<int> lst = new List<int>();
        lst.Add(1);
        lst.Add(2);
        lst.Add(3);
        lst.Add(4);
        lst.Add(5);

        foreach (var item in lst)
        {
            Console.WriteLine("list value: " + item);
        }



        //Dictionary
        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(1, "Atikul");
        dict.Add(3, "Ismail");
        dict.Add(2, "Ripa");
        dict.Add(4, "Atik");

        foreach (KeyValuePair<int, string> kvp in dict)
        {
            Console.WriteLine("dictionary key: " + kvp.Key + "  value: " + kvp.Value);
        }


        // SortedDictionary
        SortedDictionary<int, string> sdict = new SortedDictionary<int, string>();
        sdict.Add(1, "Atikul");
        sdict.Add(3, "Ismail");
        sdict.Add(2, "Ripa");
        sdict.Add(4, "Atik");
        foreach (KeyValuePair<int, string> kvp in sdict)
        {
            Console.WriteLine("sort Dictionary key: " + kvp.Key + " value: " + kvp.Value);
        }





        // Sorted List

        SortedList<string, string> slist = new SortedList<string, string>();

        slist.Add("American", "Burger");
        slist.Add("LIme", "soda");
        slist.Add("French", "Fries");
        slist.Add("Onion", "Rings");

        foreach (KeyValuePair<string, string> kvp in slist)
        {
            Console.WriteLine("SortedList key: " + kvp.Key + " value: " + kvp.Value);
        }



        //Stack 
        Stack<string> st = new Stack<string>();
        st.Push("Rare");
        st.Push("Medium Rare");
        st.Push("Medium");
        st.Push("Well done");
        st.Pop();
        st.Peek();


        foreach (var item in st)
        {
            Console.WriteLine("Stack value: " + item);
        }

        st.Clear();

        //Queue
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Mark");
        queue.Enqueue("Bill");
        queue.Enqueue("Xavier");
        queue.Enqueue("Micheal");
        queue.Dequeue();
        queue.Peek();

        foreach (var item in queue)
        {
            Console.WriteLine("queue value: " + item);
        }

        queue.Clear();

        // HashSet

        HashSet<int> hset = new HashSet<int>();
        hset.Add(11);
        hset.Add(22);
        hset.Add(55);
        hset.Add(65);
        hset.Add(55);

        foreach (var item in hset)
        {
            Console.WriteLine("value: " + item);
        }



        // Sorted set
        SortedSet<int> sset = new SortedSet<int>();

        sset.Add(11);
        sset.Add(22);
        sset.Add(55);
        sset.Add(88);
        sset.Add(22);
        sset.Add(77);


        foreach (var item in sset)
        {
            Console.WriteLine("value: " + item);
        }



        //Linked list

        LinkedList<string> linkList = new LinkedList<string>();
        linkList.AddLast("one");
        linkList.AddFirst("two");
        linkList.AddLast("three");
        linkList.AddFirst("four");

    }

}