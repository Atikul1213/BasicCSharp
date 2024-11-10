using OCP_Demo.Applicants;

namespace OCP_Demo.Accounts
{
    public interface IAccount
    {
        EmployeeModel Create(IApplicantModel person);
    }
}