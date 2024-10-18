using DemoLibrary;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AccessDemo demo = new AccessDemo();

            demo.PublicDemo();

            BadClass bad = new BadClass();

            bad._CreditCardNumber = "2341";
            Console.WriteLine("Value: " + bad._CreditCardNumber);

            bad._Age = 23;
            Console.WriteLine("Age: " + bad._Age);

        }


        private static void SayHello()
        {
            Console.WriteLine("Hello user");
        }

    }
}
