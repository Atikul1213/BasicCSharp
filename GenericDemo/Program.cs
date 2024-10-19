using System.Collections;

namespace GenericDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> ages = new List<int>();
            ages.Add(10);
            ages.Add(20);
            ages.Add(49);

            ArrayList lst = new ArrayList();
            lst.Add(10);
            lst.Add(20);
            lst.Add(49);
            lst.Add("atikul");
            lst.Add(3.30);

            foreach (var item in lst)
                Console.WriteLine("value: " + item);






            Console.WriteLine("Hello World!");
        }
    }
}
