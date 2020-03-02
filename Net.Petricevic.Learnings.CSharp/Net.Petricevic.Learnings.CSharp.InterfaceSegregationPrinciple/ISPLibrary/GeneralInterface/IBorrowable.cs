using System;
using System.Collections.Generic;
using System.Text;

namespace Net.Petricevic.Learnings.CSharp.InterfaceSegregationPrinciple.ISPLibrary
{
    public interface IBorrowable : ILibraryItem
    {
        DateTime BorrowDate { get; set; }
        string Borrower { get; set; }
        int CheckOutDurationInDays { get; set; }

        void CheckIn();
        void CheckOut(string borrower);
        DateTime GetDueDate();
    }
}
