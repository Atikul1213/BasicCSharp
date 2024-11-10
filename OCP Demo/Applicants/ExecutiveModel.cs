using OCP_Demo.Accounts;

namespace OCP_Demo.Applicants
{
    public class ExecutiveModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccount AccountProcessor { get; set; } = new ExecutiveAccount();
    }
}
