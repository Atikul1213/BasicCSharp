using OCP_Demo;
using OCP_Demo.Applicants;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Open closed principle");

        List<IApplicantModel> applicants = new List<IApplicantModel>()
        {
            new PersonModel{ FirstName="Tim", LastName="Corey" },
            new ManagerModel{ FirstName="Atikul", LastName="Islam" },
            new ExecutiveModel{ FirstName="Ismail", LastName="Hosan" },
        };

        List<EmployeeModel> employees = new List<EmployeeModel>();


        foreach (var person in applicants)
        {
            employees.Add(person.AccountProcessor.Create(person));
        }

        foreach (var emp in employees)
        {
            Console.WriteLine($"{emp.FirstName} {emp.LastName} : {emp.EmailAddress} IsManager: {emp.IsManager}  IsExecutive: {emp.IsExecutive}");
        }


    }
}