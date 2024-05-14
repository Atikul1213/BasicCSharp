using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_example
{
    public class Department
    {
        public Department()
        {
            students = new List<Student>();
        }
        public string dname { get; set; }
        public string Code { get; set; }
        public List<Student> students { get; set; }

        public void AddStudent(Student _student)
        {
            students.Add(_student);
            
             
        }
    }
}
