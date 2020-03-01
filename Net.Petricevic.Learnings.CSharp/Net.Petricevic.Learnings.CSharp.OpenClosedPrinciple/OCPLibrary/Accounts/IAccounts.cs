using Net.Petricevic.Learnings.CSharp.OpenClosedPrinciple.OCPLibrary.Applicants;

namespace Net.Petricevic.Learnings.CSharp.OpenClosedPrinciple.OCPLibrary.Accounts
{
    public interface IAccounts
    {
        EmployeeModel Create(IApplicantModel person);
    }
}
