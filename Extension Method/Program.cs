using Extension_Method.Extension;
using Extension_Method.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        }
    }
}
