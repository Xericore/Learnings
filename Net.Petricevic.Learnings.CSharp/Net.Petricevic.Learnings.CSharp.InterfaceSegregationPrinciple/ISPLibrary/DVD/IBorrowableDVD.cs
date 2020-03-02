using System;
using System.Collections.Generic;
using System.Text;

namespace Net.Petricevic.Learnings.CSharp.InterfaceSegregationPrinciple.ISPLibrary
{
    public interface IBorrowableDVD : IDVD, IBorrowable
    {
    }
}
