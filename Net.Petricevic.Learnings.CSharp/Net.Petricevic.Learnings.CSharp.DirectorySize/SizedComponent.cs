using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Net.Petricevic.Learnings.CSharp.DirectorySize
{
    public abstract class SizedComponent
    {
        public long SizeInBytes { get; set; }
        public string Path { get; protected set; }

        protected SizedComponent(string path)
        {
            Path = path;
        }
    }
}
