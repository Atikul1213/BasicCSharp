
using DelegateDemo;
using System.Reflection;

public delegate void DoSomeWorkHandler(string msg);

class Program
{
    static void Main(string[] args)
    {
        SomeClass obj = new SomeClass();
        DoSomeWorkHandler del1 = new DoSomeWorkHandler(obj.DoSomeWork);

        MethodInfo method = del1.Method;
        object target = del1.Target;
        Delegate[] InvocationList = del1.GetInvocationList();

        Console.WriteLine($"Method property: {method}");
        Console.WriteLine($"Target property: {target}");

        foreach (var item in InvocationList)
        {
            Console.WriteLine($"Invocationlist: {item}");
        }
    }
}