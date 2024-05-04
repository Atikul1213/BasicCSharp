using ConsoleApp1.Math;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Salaries salaries = new Salaries();

            ArrayList salarylist = salaries.GetSalaries();

            var salary = salarylist[0];
            Console.WriteLine("salary: "+salary);

            Console.ReadLine();
        }
        
    }

    public class Salaries
    {
        ArrayList _salaryList = new ArrayList();

        public Salaries()
        {
            _salaryList.Add(34.45);
            _salaryList.Add(34.45);
            _salaryList.Add(34.45);
            _salaryList.Add(34.45);
        }

        public ArrayList GetSalaries()
        {
            return _salaryList;
        }
    }
}
