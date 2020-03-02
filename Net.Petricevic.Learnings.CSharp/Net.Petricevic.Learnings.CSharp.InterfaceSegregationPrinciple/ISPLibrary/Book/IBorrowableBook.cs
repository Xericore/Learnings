using System;
using System.Collections.Generic;
using System.Text;

namespace Net.Petricevic.Learnings.CSharp.InterfaceSegregationPrinciple.ISPLibrary
{
    interface IBorrowableBook : IBorrowable, IBook
    {
    }
}
