using Net.Petricevic.Learnings.CSharp.OpenClosedPrinciple.OCPLibrary.Accounts;

namespace Net.Petricevic.Learnings.CSharp.OpenClosedPrinciple.OCPLibrary.Applicants
{
    public class ManagerModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new ManagerAccounts();
    }
}
