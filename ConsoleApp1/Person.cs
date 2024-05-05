using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string middleName;
        private string Id;
        
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string MiddleName {
            get { return middleName; }
            set { middleName = value; }
        }

        public Person()
        {
            Id = "001";    
        }

        public Person(string _firstName) :this()
        {
            this.firstName = _firstName;
        }
        
        public Person(string _firstName, string _lastName) :this(_firstName)
        {
            this.lastName = _lastName;
        }

        public Person(string _firstName, string _middleName, string _lastName) :this(_firstName,_lastName)
        {
            this.MiddleName = _middleName;
        }

        public string GetFullName()
        {
            return firstName +" "+ MiddleName +" "+ lastName;
        }



    }
}
