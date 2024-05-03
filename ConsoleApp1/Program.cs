using ConsoleApp1.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var builder = new StringBuilder();
            builder.Append('-', 10);

            
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            Console.WriteLine(builder);

            builder.Replace('-', '+');
            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);


            Console.ReadLine();
        }

        
    }
}
