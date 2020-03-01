using Net.Petricevic.Learnings.CSharp.OpenClosedPrinciple.OCPLibrary.Applicants;

namespace Net.Petricevic.Learnings.CSharp.OpenClosedPrinciple.OCPLibrary.Accounts
{
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName}.{person.LastName}@acme.com";

            output.IsManager = true;
            output.IsExecutive = true;

            return output;
        }
    }
}