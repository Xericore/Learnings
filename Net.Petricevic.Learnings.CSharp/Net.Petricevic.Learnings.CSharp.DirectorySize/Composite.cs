using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Petricevic.Learnings.CSharp.DirectorySize
{
    public abstract class Composite : SizedComponent
    {
        protected List<SizedComponent> Children = new List<SizedComponent>();

        public Composite(string path) : base(path)
        {
            AddDirectoriesToChildren();
            AddFilesToChildren();
        }

        private void AddDirectoriesToChildren()
        {
            string[] directories = Directory.GetDirectories(Path);

            foreach (string directory in directories)
            {
                Children.Add(new DirectoryComponent(directory));
            }
        }

        private void AddFilesToChildren()
        {
            string[] files = Directory.GetFiles(Path);

            foreach (string file in files)
            {
                Children.Add(new FileComponent(file));
            }
        }
    }
}
