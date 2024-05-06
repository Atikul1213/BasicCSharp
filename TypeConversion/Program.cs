using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int n = 10;
            double d = 5.25;
            bool ck = true;
            Console.WriteLine(Convert.ToString(n));
            Console.WriteLine(Convert.ToDouble(n));
            Console.WriteLine(Convert.ToInt32(n));
            Console.WriteLine(Convert.ToString(ck));


            float f = 1.0f;
            int i = (int)f;

            string s = "1";
            int j = Convert.ToInt32(s);
            Console.ReadLine();
        }
    }
}
