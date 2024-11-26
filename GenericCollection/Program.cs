
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

        foreach (var item in st)
        {
            Console.WriteLine("Stack value: " + item);
        }



        //Queue
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Mark");
        queue.Enqueue("Bill");
        queue.Enqueue("Xavier");
        queue.Enqueue("Micheal");

        foreach (var item in queue)
        {
            Console.WriteLine("queue value: " + item);
        }
    }

}