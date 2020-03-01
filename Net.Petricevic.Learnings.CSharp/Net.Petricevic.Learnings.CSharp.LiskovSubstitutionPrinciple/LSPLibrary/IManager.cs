using System;
using System.Collections.Generic;
using System.Text;

namespace Net.Petricevic.Learnings.CSharp.LiskovSubstitutionPrinciple.LSPLibrary
{
    public interface IManager : IEmployee
    {
        void GeneratePerformanceReview();
    }
}
