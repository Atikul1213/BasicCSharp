using OCP_Demo.Accounts;

namespace OCP_Demo.Applicants
{
    public interface IApplicantModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccount AccountProcessor { get; set; }
    }
}