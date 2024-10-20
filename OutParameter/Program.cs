public class Program
{
    public static void Main(string[] args)
    {
        int n1 = 10;
        int n2 = 4;
        int res = Substraction(n1, n2);
        Console.WriteLine("res: " + res);

        int addition, substraction, multiplication, division;
        AllInOne(n1, n2, out addition, out substraction, out multiplication, out division);
        Console.WriteLine("addition: " + addition);
        Console.WriteLine("substraction: " + substraction);
        Console.WriteLine("multiplication: " + multiplication);
        Console.WriteLine("division: " + division);

        Console.WriteLine("Hello, World!");
    }

    public static void AllInOne(int n1, int n2, out int addition, out int substraction, out int multiplication, out int division)
    {
        addition = n1 + n2;
        substraction = n1 - n2;
        multiplication = n1 * n2;
        division = n1 / n2;
    }

    public static int Substraction(int n1, int n2)
    {
        return n1 - n2;
    }
}