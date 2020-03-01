namespace Net.Petricevic.Learnings.CSharp.DirectorySize.SizedComponents
{
    public abstract class SizedComponent
    {
        public long SizeInBytes { get; protected set; }
        public string Path { get; protected set; }

        protected SizedComponent(string path)
        {
            Path = path;
        }
    }
}
