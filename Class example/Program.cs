using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Department dept = new Department();
            
            dept.dname = "CSE";
            dept.Code = "001";

            Student sobj = new Student();

            sobj.Name = "Atikul Islam";
            sobj.RegNo = "12345";
            sobj.Address = "Dinajpur";

            
            dept.AddStudent(sobj);
            


          Console.WriteLine("Show the list: ");
          foreach(var obj in dept.students)
          {
              Console.WriteLine("Name: "+obj.Name+" dept: "+obj.department+" Add: "+obj.Address);
          }

          /**
        
          Car privcar = new Car("Toyota", "Red");

          Engine engine = new Engine("Yokoma", "E001", "1000CC");

          privcar.AddEngine(engine); 
          

          Console.WriteLine(privcar.On());
          Console.WriteLine(privcar.MoveForward());
          privcar.ShowCar();
          Console.WriteLine(privcar.Stop());
          */


        }
    }
}
