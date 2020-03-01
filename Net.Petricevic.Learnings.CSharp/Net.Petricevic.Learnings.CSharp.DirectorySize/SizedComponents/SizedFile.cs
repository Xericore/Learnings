using System.IO;

namespace Net.Petricevic.Learnings.CSharp.DirectorySize.SizedComponents
{
    internal class SizedFile : SizedComponent
    {
        public SizedFile(string path) : base(path)
        {
            FileInfo fi = new FileInfo(Path);

            SizeInBytes = fi.Length;
        }

    }
}
