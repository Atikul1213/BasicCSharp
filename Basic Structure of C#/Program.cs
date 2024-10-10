
string name = "Atikul Islam";

Console.WriteLine(name);
Console.WriteLine("Hello " + name);
Console.Write($"Hello {name}\n");

string name1 = Console.ReadLine();
Console.WriteLine(name1);

int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("sum is: " + (n1 + n2));
Console.WriteLine($"sum is {n1 + n2}");


Console.WriteLine("Enter your Employee Information");

Console.WriteLine("Enter your employee Id");
int employeeId = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Name: ");

string employeeName = Console.ReadLine();

Console.WriteLine("Enter your Salary ");
int salary = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Address");
string address = Console.ReadLine();

Console.WriteLine("Enter your department");

string department = Console.ReadLine();


Console.WriteLine($"EID: {employeeId}");
Console.WriteLine($"Name: {employeeName}");
Console.WriteLine($"salary : {salary}");
Console.WriteLine($"Address: {address}");
Console.WriteLine($"Department: {department}");



int var1 = Console.Read();

ConsoleKeyInfo var2 = Console.ReadKey();

Console.WriteLine($"\n Entered key {var2.Key} KeyChar: {var2.KeyChar} ASCII: {(int)var2.KeyChar}");



Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.White;
Console.Title = "Understanding console class";

Console.Beep();








