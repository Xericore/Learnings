namespace Net.Petricevic.Learnings.CSharp.DirectorySize.Util
{
    public static class FileSizeConverter
    {
        public static long ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024) / 1024L;
        }
    }
}
