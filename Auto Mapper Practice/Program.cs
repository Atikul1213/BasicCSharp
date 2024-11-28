using Auto_Mapper_Practice;

public class AutoMapperPractice
{
    public static void Main(string[] args)
    {
        var mapper = MapperConfig.InitializeAutomapper();
        var address = new Address()
        {
            City = "Dinajpur",
            State = "Khansama",
            Country = "Bangladesh"
        };
        var emp = new Employee()
        {
            Name = "Atikul Islam",
            Salary = 2133,
            Address = address,
            Department = "CSE"
        };

        var empDTO1 = mapper.Map<EmployeeDTO>(emp);
        var empDTO2 = mapper.Map<Employee, EmployeeDTO>(emp);


    }
}