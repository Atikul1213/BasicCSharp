using Extension_Method.Extension;
using Extension_Method.Model;
using System;

namespace Extension_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(); ;

            int res = calculator.Add(20, 30);
            Console.WriteLine(res);

            int res1 = calculator.Multiply(3, 66);
            Console.WriteLine(res1);

            string myWord = "Welcome to Dotnet Tutorials Extension Methods Article";
            int wordCount = myWord.GetWordCount();
            Console.WriteLine("Word count: " + wordCount);
        }
    }
}
