using System.Reflection;

public class LinqExample
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atikul");

        string[] words = { "hello", "wonderful", "LINQ", "beautiful", "world" };
        words.Distinct().Count();
        words.Distinct().Count();
        words.Sum(x => x.Length);



        var longWords = words.Where(x => x.Length > 5);
        var myLinqQuery = from w in words
                          where w.Length > 5 && w.Contains("LINQ")
                          select w;
        var myLInqQuery1 = words.Where(x => x.Contains("LINQ"));

        IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13}};

        var ans1 = from s in studentList
                   where s.Age > 12 && s.Age < 18
                   orderby s.StudentID descending
                   select s;



        var ans2 = studentList.Where(x => x.Age >= 12 && x.Age <= 18).OrderByDescending(x => x.StudentID).ThenBy(x => x.StudentName);
        var ans3 = studentList.Where((s, i) =>
        {
            if (i % 2 == 0)
                return true;
            return false;
        });

        var innerJoin = from s in studentList
                        join s1 in studentList
                        on s.StudentID equals s1.StudentID
                        select new
                        {
                            StudentName = s.StudentName,
                            Age = s1.Age
                        };

        var ans5 = from s in studentList
                   select new
                   {
                       StudentName = s.StudentName + "Mr",
                       StudentId = s.StudentID
                   };



        var ans4 = from w in words.OfType<string>()
                   select w;
        var ans6 = studentList.Any(x => x.StudentName.Contains("LINQ"));
        var ans7 = studentList.All(x => x.StudentID == 2);

        int ageSum = studentList.Aggregate<Student, int>(0, (totalAge, s) => totalAge += s.Age);
        int ageSum1 = studentList.Aggregate<Student, int>(0, (totalAge, s) => totalAge += s.Age);

        var agvAge = studentList.Average(s => s.Age);
        var count = studentList.Count(x => x.Age >= 18);
        var sum = studentList.Sum(x => x.Age);

        IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
        intList.ElementAt(0);
        intList.ElementAtOrDefault(2);
        intList.FirstOrDefault(x => x % 2 == 0);
        intList.LastOrDefault(x => x % 2 == 0);

        intList.Concat(intList);
        intList.Distinct();
        intList.Intersect(intList);
        intList.Union(intList);

        intList.AsEnumerable();
        intList.AsQueryable();
        intList.ToArray();
        intList.ToList();

        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        var sortedNumber = from n in numbers
                           orderby n ascending
                           select n;
        numbers.ToArray();
        numbers.OrderByDescending(x => x);
        for (int i = 0; i < numbers.Length; i++)
            Console.WriteLine(numbers[i]);

        string[] Digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };


        Digits.First(s => s[0] == 'o');
        Digits.First(x => x == "one");

        var ansNumber = from n in numbers
                        group n by n % 5 into g
                        select (Remainder: g.Key, Number: g);



        int oddNumber = numbers.Count(x => x % 2 == 1);

        var ans9 = from s in studentList
                   select (
                   s.StudentName, studentid: s.StudentName.Count());

        numbers.Aggregate((a, b) => a * b);
        numbers.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);
        double startBalance = 100.0;

        double endBalance = numbers.Aggregate(startBalance, (balance, nextWidthdrawal) =>
                ((nextWidthdrawal <= balance) ? (balance - nextWidthdrawal) : balance));



        var sum1 = numbers.Sum();
        numbers.Count();
        numbers.Min();
        numbers.Max();
        numbers.Sum();

        words.Min(x => x.Length);
        words.Max(x => x.Length);
        words.Sum(x => x.Length);

        Assembly asmbly = Assembly.GetExecutingAssembly();
        Type[] types1 = asmbly.GetTypes();

        foreach (Type type in types1)
        {
            ConstructorInfo cns = type.GetConstructor([typeof(string), typeof(double), typeof(int)]);
            object? obj3 = cns.Invoke(["atikul", 23.32, 22]);
        }

        Assembly assembly = Assembly.GetExecutingAssembly();
        Type t;
        Type[] types = assembly.GetTypes();
        foreach (Type type in types)
        {
            Console.WriteLine(type.FullName);

            type.GetInterfaces();
            type.GetProperties();
            type.GetMethods();
            type.GetConstructors();

            var interfaces = type.GetInterfaces();
            if (interfaces.Any(x => x.Name == "IService"))
            {
                ConstructorInfo constructorInfo = type.GetConstructor([typeof(string), typeof(double), typeof(int)]);
                object? obj = constructorInfo.Invoke(["atikul", 232.3, 10]);
                object? obj1 = constructorInfo.Invoke(["sadikul", 23.23, 43]);

                MethodInfo methodInfo = type.GetMethod("AddMethod", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                MethodInfo method1 = type.GetMethod("MyMethod", BindingFlags.Public | BindingFlags.NonPublic);

                method1.Invoke(obj, []);
                method1.Invoke(obj, [4]);

                var simpleInstance = Activator.CreateInstance(type);
                var simpleInstance1 = Activator.CreateInstance(type);
                var simpleInstance2 = Activator.CreateInstance(type);

                foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                {
                    var name = field.Name;
                    field.SetValue(simpleInstance, "Atikul");
                }

                foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                {
                    var name = field.Name;
                    field.SetValue(simpleInstance, "atikul");
                }

                foreach (var property in type.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public))
                {
                    var name = property.Name;
                    var value = property.GetValue(simpleInstance);
                    var name1 = property.Name;
                    var value1 = property.GetValue(simpleInstance);
                }
            }
        }


    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}