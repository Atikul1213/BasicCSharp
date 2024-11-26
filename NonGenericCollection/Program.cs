
using System.Collections;

public class GenericCollection
{
    public static void Main(string[] args)
    {
        Console.WriteLine("atikul");

        // Array List

        ArrayList alist = new ArrayList();
        string str = "I am atikul";
        int x = 11;
        DateTime dt = DateTime.Parse("3-dec-1999");
        alist.Add(str);
        alist.Add(x);
        alist.Add(dt);

        foreach (var item in alist)
        {
            Console.WriteLine("Arraylist value: " + item);
        }



        // HashTable 
        Hashtable htable = new Hashtable();
        htable.Add(2, "Soda");
        htable.Add(1, "Burger");
        htable.Add(4, "Fries");
        htable.Add(3, "Onion Rings");

        foreach (DictionaryEntry ht in htable)
        {
            Console.WriteLine("Hashtable key: " + ht.Key + " value: " + ht.Value);
        }


        //Sorted list
        SortedList slist = new SortedList();
        slist.Add("America", "Burgerr");
        slist.Add("Lime", "Soda");
        slist.Add("French", "Fries");
        slist.Add("Onion", "Rings");

        foreach (DictionaryEntry sl in slist)
        {
            Console.WriteLine("SortedList key: " + sl.Key + "  value: " + sl.Value);
        }


        //Stack

        Stack st = new Stack();
        st.Push("Rare");
        st.Push("Medium Rare");
        st.Push("Medium");
        st.Push("Well done");

        foreach (var item in st)
        {
            Console.WriteLine("Stack value: " + item);
        }


        // Queue 
        Queue queue = new Queue();
        queue.Enqueue("Mark");
        queue.Enqueue("Bill");
        queue.Enqueue("Xavier");
        queue.Enqueue("Michael");

        foreach (var item in queue)
        {
            Console.WriteLine("queue value: " + item);
        }
    }

}