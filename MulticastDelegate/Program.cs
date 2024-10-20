

using MulticastDelegate;

class Program
{
    public delegate void RecatangleDelegate(double Width, double Height);
    public static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        RecatangleDelegate recatangleDelegate = new RecatangleDelegate(rect.GetArea);
        recatangleDelegate += rect.GetPerimeter;

        Delegate[] InvocationList = recatangleDelegate.GetInvocationList();

        Console.WriteLine("InvocationList: ");

        foreach (var item in InvocationList)
        {
            Console.WriteLine($" {item}");
        }

        Console.WriteLine();
        Console.WriteLine("Invoking multicast delegate");
        recatangleDelegate(10.2, 23.3);

        Console.WriteLine();
        Console.WriteLine("Invoking multicast delegate after removing one pipeline");

        recatangleDelegate -= rect.GetPerimeter;
        recatangleDelegate.Invoke(10.2, 10.3);

    }
}