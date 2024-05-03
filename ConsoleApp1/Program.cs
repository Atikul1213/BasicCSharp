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

            var fullName = "Atikul Islam ";
            Console.WriteLine("Trim: '{0}'",fullName.Trim());

            Console.WriteLine("ToUpper: '{0}'",fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);

            var lastName = fullName.Substring(index + 1);

            Console.WriteLine("firstName: "+firstName);
            Console.WriteLine("lastName: "+lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("firstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            var nname = fullName.Replace("Atikul", "Atik");
            fullName.Replace(' ', '?');
            Console.WriteLine("full Name: "+nname);

            if(String.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid");


            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");


            var num = Console.ReadLine();
            int dec = Convert.ToInt32(num);
            Console.WriteLine("dec: "+dec);


            Console.ReadLine();
        }

        
    }
}
