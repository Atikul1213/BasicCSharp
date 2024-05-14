using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Reuse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Atikul", "Islam", "Atik");
            Console.WriteLine(person.GetFullName());
        }
    }

    public class Person
    {
        private string firstName;
        private string lastName;
        private string middleName;
        private string Id;

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string _firstName)
        {
            this.firstName = _firstName; 
        }

        public Person()
        {
            Id = "001";
        }

        public Person(string _firstName) : this()
        {
            this.firstName = _firstName;
        }

        public Person(string _firstName, string _lastName) : this(_firstName)
        {
            this.lastName = _lastName;
        }

        public Person(string _firstName, string _middleName, string _lastName) : this(_firstName, _lastName)
        {
            this.middleName = _middleName;
        }

        public string GetFullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }



    }
}
