using System;
using System.Collections.Generic;
using System.Text;
using Net.Petricevic.Learnings.CSharp.OpenClosedPrinciple.OCPLibrary.Accounts;

namespace Net.Petricevic.Learnings.CSharp.OpenClosedPrinciple.OCPLibrary.Applicants
{
    public class TechnicianModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new Accounts.Accounts();
    }
}
