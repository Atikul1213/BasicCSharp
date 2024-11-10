using OCP_Demo.Applicants;

namespace OCP_Demo.Accounts
{
    public class Account : IAccount
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)} {person.LastName}@gmail.comm";

            //if (person.TypeOfEmployee == EmployeeType.Manager)
            //    output.IsManager = true;

            //switch (person.TypeOfEmployee)
            //{
            //    case EmployeeType.Staff:

            //        break;
            //    case EmployeeType.Manager:
            //        output.IsManager = true;
            //        break;

            //    case EmployeeType.Executive:
            //        output.IsExecutive = true;
            //        break;
            //}

            return output;
        }
    }
}
