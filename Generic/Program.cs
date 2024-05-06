using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 0, 99, 1, 40, 3, 70, 23 };

            SortArray<int> sortArray = new SortArray<int>();
            sortArray.Bubblesort(arr);

            foreach (var num in arr)
            {
                Console.WriteLine(num);
            }



            string[] name = new string[] { "sadikul", "zahid", "ripa", "sadika", "atikul", "ismail" };
            SortArray<string> sortName = new SortArray<string>();
            sortName.Bubblesort(name);

            foreach (string nam in name)
            {
                Console.WriteLine("name: " + nam);
            }
        }
    }


    public class SortArray<T> where T : IComparable
    {
        public void Bubblesort(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[j - 1].CompareTo(arr[j]) > 0)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
        }


    }
}
