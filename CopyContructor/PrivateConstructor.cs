namespace CopyContructor
{
    public class PrivateConstructor
    {

        public PrivateConstructor()
        {
            Console.WriteLine("This is a private Constructor");
        }
        static void Main(string[] args)
        {
            PrivateConstructor prv = new PrivateConstructor();

            Console.WriteLine("Main method");

            Console.ReadKey();
        }

    }
}
