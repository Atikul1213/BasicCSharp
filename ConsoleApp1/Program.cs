using ConsoleApp1.Math;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 0, 99, 1, 40, 3, 70, 23 };

            SortArray<int> sortArray = new SortArray<int>();
            sortArray.Bubblesort(arr);

            foreach (var num in arr)
            {
                Console.WriteLine(num);
            }


            
            string[] name = new string[] { "sadikul","zahid", "ripa", "sadika", "atikul", "ismail" };
            SortArray<string> sortName = new SortArray<string>();
            sortName.Bubblesort(name);

            foreach(string nam in name)
            {
                Console.WriteLine("name: " + nam);
            }

            

            Employee[] Emparr = new Employee[4]
            {
                new Employee{Id=4, Name ="Zahid" },
                new Employee{Id = 3, Name = "atikul" },
                new Employee{Id = 1, Name = "sadika" },
                new Employee{Id = 2, Name = "Ismail"}
            };

           // SortArray<Employee> empSort = new SortArray<Employee>();
           // empSort.Bubblesort(Emparr);




            Console.ReadLine();
        }
        
    }

    public class Employee  
    {
        public int Id { get; set; }
        public string Name { get; set; }

       
         
    }


    public class SortArray<T> where T:IComparable
    {
        public void Bubblesort(T[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                for(int j = 1; j < arr.Length; j++)
                {
                    if (arr[j - 1].CompareTo(arr[j]) >0)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j-1];
                        arr[j-1] = temp;
                    }
                }
            }
        }

         
    }
}
