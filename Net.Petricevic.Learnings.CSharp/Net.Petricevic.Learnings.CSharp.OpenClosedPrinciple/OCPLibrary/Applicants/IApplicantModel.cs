using Net.Petricevic.Learnings.CSharp.OpenClosedPrinciple.OCPLibrary.Accounts;

namespace Net.Petricevic.Learnings.CSharp.OpenClosedPrinciple.OCPLibrary.Applicants
{
    public interface IApplicantModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccounts AccountProcessor { get; set; }
    }
}
