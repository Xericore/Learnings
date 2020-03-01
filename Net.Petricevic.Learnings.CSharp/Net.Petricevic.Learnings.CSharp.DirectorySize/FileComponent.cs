using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Petricevic.Learnings.CSharp.DirectorySize
{
    internal class FileComponent : SizedComponent
    {
        public FileComponent(string path) : base(path)
        {
            FileInfo fi = new FileInfo(Path);

            SizeInBytes = fi.Length;
        }

    }
}
