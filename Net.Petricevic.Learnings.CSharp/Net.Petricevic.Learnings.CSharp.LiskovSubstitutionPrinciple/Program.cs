using System;
using Net.Petricevic.Learnings.CSharp.LiskovSubstitutionPrinciple.LSPLibrary;

namespace Net.Petricevic.Learnings.CSharp.LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IManager accountingVP = new CEO();

            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);

            IManaged emp = new Manager();

            emp.FirstName = "Tim";
            emp.LastName = "Corey";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");
        }
    }
}
