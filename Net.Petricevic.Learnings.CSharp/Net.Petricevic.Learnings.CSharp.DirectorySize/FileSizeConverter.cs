using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Petricevic.Learnings.CSharp.DirectorySize
{
    public static class FileSizeConverter
    {
        public static long ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024) / 1024L;
        }
    }
}
