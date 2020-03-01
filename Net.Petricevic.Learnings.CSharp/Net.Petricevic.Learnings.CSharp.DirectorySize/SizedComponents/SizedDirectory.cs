using System.Collections.Generic;
using System.IO;

namespace Net.Petricevic.Learnings.CSharp.DirectorySize.SizedComponents
{
    public class SizedDirectory : SizedComponent
    {
        protected List<SizedComponent> Children = new List<SizedComponent>();

        public SizedDirectory(string path) : base(path)
        {
            AddSubDirectoriesToChildren();
            AddFilesToChildren();

            CalculateSizeInBytes();
        }

        private void AddSubDirectoriesToChildren()
        {
            string[] directories = Directory.GetDirectories(Path);

            foreach (string directory in directories)
            {
                Children.Add(new SizedDirectory(directory));
            }
        }

        private void AddFilesToChildren()
        {
            string[] files = Directory.GetFiles(Path);

            foreach (string file in files)
            {
                Children.Add(new SizedFile(file));
            }
        }

        private void CalculateSizeInBytes()
        {
            foreach (var sizedComponent in Children)
            {
                SizeInBytes += sizedComponent.SizeInBytes;
            }
        }
    }
}
