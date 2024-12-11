using System.Reflection;

internal class Program
{
    public static void Main(string[] args)
    {

        Assembly asmbly = Assembly.GetExecutingAssembly();
        Type t;

        Type[] types = asmbly.GetTypes();

        foreach (Type type in types)
        {
            Console.WriteLine("type: " + type.FullName);
            var interfaces = type.GetInterfaces();

            if (interfaces.Any(x => x.Name == "IPurchable"))
            {
                ConstructorInfo? constructor = type.GetConstructor([typeof(string), typeof(double), typeof(double)]);
                object? obj = constructor?.Invoke(["Atikul Islam", 3000, 10]);

                MethodInfo? method1 = type.GetMethod("CalculatePriceAfterTax", BindingFlags.Instance | BindingFlags.Public);
                MethodInfo? method2 = type.GetMethod("CalculateDiscount", BindingFlags.Instance | BindingFlags.Public, [typeof(double)]);

                double? result1 = (double)method1?.Invoke(obj, []);  /// Instance, parameter
                double? result2 = (double)method2?.Invoke(obj, [5]);

                Console.WriteLine("result1: " + result1);
                Console.WriteLine("result2: " + result2);

            }
        }


        // Another example
        var simpleAssembly = Assembly.LoadFrom(@"C:\Users\BS-Test\Music\Practice\ConsoleApp1\Reflection Practise\bin\Debug\net8.0\Reflection Practise.dll");

        foreach (var type in simpleAssembly.GetTypes())
        {
            Console.WriteLine("Type: " + type.Name);

            var simpleInstance = Activator.CreateInstance(type);

            foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic))
            {
                Console.WriteLine("Fields: " + field.Name);
                field.SetValue(simpleInstance, "Atikul");

            }

            foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic))
            {
                if (method.GetParameters().Length > 0)
                {
                    method.Invoke(simpleInstance, new[] { "atikul" });
                }
                else if (method.ReturnType.Name != "void")
                {
                    var returnedValue = method.Invoke(simpleInstance, null);
                }
                else
                {
                    method.Invoke(simpleInstance, null);
                }
            }

            foreach (var property in type.GetProperties())
            {
                Console.WriteLine("Property" + property.Name);
                var propertyValue = property.GetValue(simpleInstance);
                Console.WriteLine("Property value: " + propertyValue);
            }
        }

    }
}