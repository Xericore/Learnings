using System;

namespace Net.Petricevic.Learnings.CSharp.InterfaceSegregationPrinciple.ISPLibrary
{
    public interface ILibraryItem
    {
        string LibraryId { get; set; }
        string Title { get; set; }
    }
}