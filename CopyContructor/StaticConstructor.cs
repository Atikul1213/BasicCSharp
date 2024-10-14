namespace CopyContructor
{
    public class StaticConstructor
    {
        int i;
        static int j;

        public StaticConstructor()
        {
            Console.WriteLine("Default constructor Executed");
            i = 100;
        }

        static StaticConstructor()
        {
            Console.WriteLine("Static constructor executed");
            j = 100;
        }

        public void Increment()
        {
            i++;
            j++;
        }

        public void Display()
        {
            Console.WriteLine("The value of i " + i + " Value of j: " + j);
        }
    }
}
