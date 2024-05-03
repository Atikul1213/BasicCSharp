using ConsoleApp1.Math;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            var smallests = GetSmallests(numbers, 3);

            foreach(var num in smallests)
                Console.WriteLine("num: "+num);

            Console.ReadLine();
        }

        public static List<int> GetSmallests(List<int>list,int count)
        {
            var smallests = new List<int>();
            
            while(smallests.Count < count)
            {
                var min = GetSmallests(list);
                smallests.Add(min);
                list.Remove(min);
            }
            return smallests;
        }

        public static int GetSmallests(List<int> list)
        {
            var Min = list[0];
            foreach(var x in list)
            {
                if (x < Min)
                    Min = x;
            }

            return Min;
        }



        
    }
}
