using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_and_Lambda_Expression
{
    internal class Program
    {

        delegate int AddHandler(int num1, int num2);

        static void Main(string[] args)
        {


            //AddHandler addhandle = Add;
            AddHandler addhandle = Multiply;
            int result = addhandle(3, 9);
            Console.WriteLine("res: "+result);


            // Shortcut way
            AddHandler addhandle1 = delegate (int num1, int num2)
            {
                return num1 + num2;
            };


            // another way , it has return type
            Func<int, int, int> addhandle2 = delegate (int num1, int num2)
            {
                return num1 + num2;
            };

            Func<int> addhandle3 = delegate ()
            {
                return 20;
            };



            // Action has no return type
            Action addHandle4 = delegate ()
            {
                Console.WriteLine("Action Delegate");
            };

            addHandle4();

            Action<int, string> addHandle5 = delegate (int num, string name)
            {
                Console.WriteLine("num: " + num + " name: " + name);
            };


            addHandle5(20, "Atikul");



            // Lamda expression
            Func<int, int, int> addhandle6 = (int x, int y) => x + y;

            Console.WriteLine("lamda: "+addhandle6(49,4));



            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Laptop"
                },

                new Product()
                {
                    Id = 2,
                    Name = "Monitor"
                }
            };



            foreach(Product var in products)
            {
                Console.WriteLine("Id: "+var.Id + " Name: "+var.Name);
            }


            int id = 2;
            var prd = products.FirstOrDefault(u => u.Id == id);

            Console.WriteLine("prd: "+prd.Id);



            // LINK

            var fetchproduct = from p in products
                               where p.Id >= 1 && p.Id <= 100
                               select p;

            foreach(var x in fetchproduct)
            {
                Console.WriteLine("FetchData: "+x.Id);
            }


            // another way
            var fetchproduct1 = products.Where(u => u.Id >= 1 && u.Id <= 100);

            foreach (var x in fetchproduct1)
            {
                Console.WriteLine("FetchData1: " + x.Id);
            }


        }




        static int Add(int fnum, int snum)
        {

            return fnum + snum;
        }

        public static int Multiply(int fnum,int snum)
        {
            return fnum * snum;
        }


    }
}
