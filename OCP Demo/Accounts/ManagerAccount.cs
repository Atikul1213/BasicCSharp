using OCP_Demo.Applicants;

namespace OCP_Demo.Accounts
{
    public class ManagerAccount : IAccount
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"manager {person.FirstName.Substring(0, 1)} {person.LastName}@gmail.comm";
            output.IsManager = true;
            return output;
        }
    }
}
