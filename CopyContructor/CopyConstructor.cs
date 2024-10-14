namespace CopyContructor
{
    public class Employee
    {
        public int Id, Age;
        public string Address, Name;
        public bool IsPermanent;

        public Employee(int id, int age, string name, string address, bool isPermanent)
        {
            Id = id;
            Age = age;
            Name = name;
            Address = address;
            IsPermanent = isPermanent;
        }

        public Employee(Employee emp)
        {
            Id = emp.Id;
            Age = emp.Age;
            Name = emp.Name;
            Address = emp.Address;
            IsPermanent = emp.IsPermanent;
        }

        public void Display()
        {
            Console.WriteLine("Employee Is is : " + Id);
            Console.WriteLine("Employee Name is : " + Name);
            Console.WriteLine("Employee Address is : " + Address);
            Console.WriteLine("Employee Age is : " + Age);
            Console.WriteLine("Is Employee Permanent" + IsPermanent);
        }
    }
}
