using Net.Petricevic.Learnings.CSharp.OpenClosedPrinciple.OCPLibrary.Applicants;

namespace Net.Petricevic.Learnings.CSharp.OpenClosedPrinciple.OCPLibrary.Accounts
{
    public class ManagerAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{person.LastName}@acme.com";

            output.IsManager = true;

            return output;
        }
    }
}
