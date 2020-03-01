using System;

namespace Net.Petricevic.Learnings.CSharp.DirectorySize
{
    internal class DirectoryComponent : Composite
    {
        public DirectoryComponent(string path) : base(path)
        {
            foreach (var sizedComponent in Children)
            {
                SizeInBytes += sizedComponent.SizeInBytes;
            }
        }

    }
}