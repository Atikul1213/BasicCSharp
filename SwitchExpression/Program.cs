
using SwitchExpression;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(MyClass.OldSwitch("vanilla"));
        Console.WriteLine(MyClass.NewSwitch("vanilla"));
    }
}