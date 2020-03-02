using System;
using System.Collections.Generic;
using System.Text;

namespace Net.Petricevic.Learnings.CSharp.InterfaceSegregationPrinciple.ISPLibrary
{
    public interface IBook : ILibraryItem
    {
        string Author { get; set; }
        int Pages { get; set; }
    }
}
