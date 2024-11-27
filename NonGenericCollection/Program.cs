
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
        alist.Add(true);
        alist.Add(null);
        alist.Insert(0, "FirstElement");
        alist.Sort();
        foreach (var item in alist)
        {
            Console.WriteLine("Arraylist value: " + item);
        }

        for (int i = 0; i < alist.Count; i++)
        {
            Console.WriteLine("arraylist: " + alist[i]);
        }

        ArrayList alist2 = new ArrayList()
        {
            "atikul",
            "sadikul"
        };

        ArrayList cloneAlist = (ArrayList)alist.Clone();

        alist.InsertRange(0, alist2);
        alist.RemoveAt(1);
        alist.RemoveRange(0, 2);
        alist.Contains("atikul");
        alist.Clear();




        // HashTable 
        Hashtable htable = new Hashtable();
        htable.Add(2, "Soda");
        htable.Add(1, "Burger");
        htable.Add(4, "Fries");
        htable.Add(3, "Onion Rings");

        if (htable.Contains(3))
        {
            htable.Remove(3);
        }
        htable.ContainsKey(3);
        htable.ContainsValue("Soda");

        foreach (DictionaryEntry ht in htable)
        {
            Console.WriteLine("Hashtable key: " + ht.Key + " value: " + ht.Value);
        }

        Hashtable cloneHashtable = (Hashtable)htable.Clone();

        htable.Clear();




        //Sorted list
        // key not duplicate and  key not support different data type 
        SortedList slist = new SortedList();
        slist.Add("America", "Burgerr");
        slist.Add("Lime", "Soda");
        slist.Add("French", "Fries");
        slist.Add("Onion", "Rings");

        foreach (DictionaryEntry sl in slist)
        {
            Console.WriteLine("SortedList key: " + sl.Key + "  value: " + sl.Value);
        }


        for (int i = 0; i < slist.Count; i++)
        {
            Console.WriteLine("Key: " + slist.GetKey(i) + " value: " + slist.GetByIndex(i));
        }
        slist.Remove("Onion");
        slist.RemoveAt(1);
        if (slist.Contains("Onion"))
        {

        }
        if (slist.ContainsKey("Onion"))
        {

        }
        if (slist.ContainsValue("Onion"))
        {

        }
        var cloneSlist = (SortedList)slist.Clone();
        slist.Clear();





        //Stack

        Stack st = new Stack();
        st.Push("Rare");
        st.Push("Medium Rare");
        st.Push("Medium");
        st.Push("Well done");
        st.Push(12);
        st.Push(67.4);
        st.Push(true);

        foreach (var item in st)
        {
            Console.WriteLine("Stack value: " + item);
        }

        if (st.Contains(12))
        {

        }
        var peek = st.Peek();
        var cloneStack = (Stack)st.Clone();
        st.Clear();



        // Queue 
        Queue queue = new Queue();
        queue.Enqueue("Mark");
        queue.Enqueue("Bill");
        queue.Enqueue("Xavier");
        queue.Enqueue("Michael");
        queue.Enqueue(67.5);
        queue.Enqueue(true);

        queue.Dequeue();
        var peekValue = queue.Peek();

        foreach (var item in queue)
        {
            Console.WriteLine("queue value: " + item);
        }

        var cloneQueue = (Queue)queue.Clone();
        queue.Clear();
    }

}